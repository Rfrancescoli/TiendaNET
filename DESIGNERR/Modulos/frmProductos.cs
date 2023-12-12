using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ENTITIES;
using DESIGNER.Tools;
using BOL;


namespace DESIGNER.Modulos
{
    public partial class frmProductos : Form
    {
        EProducto entProducto = new EProducto();
        Producto producto = new Producto();
        Categoria categoria = new Categoria();
        Subcategoria subcategoria = new Subcategoria();
        Marca marca = new Marca();

        //Bandera = variable LÓGICA que controla estados
        bool categoriasListas = false;

        public frmProductos()
        {
            InitializeComponent();
        }

        #region Métodos para carga de datos

        private void actualizarMarcas()
        {
            cboMarca.DataSource = marca.listar();
            cboMarca.DisplayMember = "marca";   //Mostrar
            cboMarca.ValueMember = "idmarca";   //PK(guarda)
            cboMarca.Refresh();
            cboMarca.Text = "";
        }
        
        private void actualizarCategorias()
        {
            cboCategoria.DataSource = categoria.listar();
            cboCategoria.DisplayMember = "categoria";   //Mostrar
            cboCategoria.ValueMember = "idcategoria";   //PK(guarda)
            cboCategoria.Refresh();
            cboCategoria.Text = "";
        }

        private void actualizarProductos()
        {
            gridProductos.DataSource = producto.listar();
            gridProductos.Refresh();
        }
        #endregion

        private void frmProductos_Load(object sender, EventArgs e)
        {
            actualizarProductos();
            actualizarMarcas();
            actualizarCategorias();

            categoriasListas = true;
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoriasListas)
            {
                //Invocar el metodo que carga las subcategorias
                int idcategoria = Convert.ToInt32(cboCategoria.SelectedValue.ToString());
                cboSubcategoria.DataSource = subcategoria.listar(idcategoria);
                cboSubcategoria.DisplayMember = "subcategoria";
                cboSubcategoria.ValueMember = "idsubcategoria";
                cboSubcategoria.Refresh();
                cboSubcategoria.Text = "";
            }           
        }

        private void reiniciarInterfaz()
        {
            cboMarca.Text = "";
            cboCategoria.Text = "";
            cboSubcategoria.Text = "";
            txtGarantia.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void button1_Click(object sender, EventArgs e) //guardar
        {
            if (Aviso.Preguntar("¿Está seguro de registrar un nuevo producto?") == DialogResult.Yes)
            {
                entProducto.idmarca = Convert.ToInt32(cboMarca.SelectedValue.ToString());
                entProducto.idsubcategoria = Convert.ToInt32(cboSubcategoria.SelectedValue.ToString());
                entProducto.descripcion = txtDescripcion.Text;
                entProducto.garantia = Convert.ToInt32(txtGarantia.Text);
                entProducto.precio = Convert.ToDouble(txtPrecio.Text);
                entProducto.stock = Convert.ToInt32(txtStock.Text);

                if (producto.registrar(entProducto) > 0)
                {
                    reiniciarInterfaz();
                    actualizarProductos();
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //1. Crear instancia del reporte (CrystalReport)
            Reportes.CrystalReport1 reporte = new Reportes.CrystalReport1();

            //2. Asignar los datos del objeto reporte (creado en el paso 1)
            reporte.SetDataSource(producto.listar());
            reporte.Refresh();

            //3. Instanciar el formulario donde se mostraran los reportes
            Reportes.frmVisorReportes formulario = new Reportes.frmVisorReportes();

            //4. Pasamos el reporte al visor
            formulario.visor.ReportSource = reporte;
            formulario.visor.Refresh();

            //5. Mostramos el formulario conteniendo el reporte
            formulario.ShowDialog();
        }

        /// <summary>
        /// Genera un archivo fisico del reporte
        /// </summary>
        /// <param name="extension">Utilice: XLS o PDF</param>
        private void ExportarDatos(string extension)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Title = "Reporte de productos";
            sd.Filter = $"Archivos en formato {extension.ToUpper()}|*.{extension.ToLower()}";

            if (sd.ShowDialog() == DialogResult.OK)
            {
                //Creamos una version del reporte en formato PDF
                Reportes.CrystalReport1 reporte = new Reportes.CrystalReport1();

                //2. Asignar los datos al objeto reporte (creado en el paso 1)
                reporte.SetDataSource(producto.listar());
                reporte.Refresh();

                //3. El reporte creado y en memoria se ESCRIBIRA en el STORAGE
                if (extension.ToUpper() == "PDF")
                {
                    reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sd.FileName);
                }else if(extension.ToUpper() == "XLSX")
                {
                    reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.ExcelWorkbook, sd.FileName);
                }
                    

                //4. Notificar al usuario la creacion del archivo
                Aviso.Informar("Se ha creado el reporte correctamente");
            }
        }

        private void btnExportarXLS_Click(object sender, EventArgs e)
        {
            ExportarDatos("XLSX");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos("PDF");
        }
    }
}
