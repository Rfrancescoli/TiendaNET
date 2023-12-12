
namespace DESIGNER.Modulos
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSubcategoria = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnExportarXLS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(25, 64);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.Size = new System.Drawing.Size(841, 245);
            this.gridProductos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboSubcategoria);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.cboMarca);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGarantia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del producto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(121, 30);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(439, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Descripcion:";
            // 
            // cboSubcategoria
            // 
            this.cboSubcategoria.FormattingEnabled = true;
            this.cboSubcategoria.Location = new System.Drawing.Point(121, 114);
            this.cboSubcategoria.Name = "cboSubcategoria";
            this.cboSubcategoria.Size = new System.Drawing.Size(188, 23);
            this.cboSubcategoria.TabIndex = 7;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(121, 85);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(188, 23);
            this.cboCategoria.TabIndex = 5;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(121, 56);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(188, 23);
            this.cboMarca.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(381, 112);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(179, 20);
            this.txtStock.TabIndex = 13;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(381, 85);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(179, 20);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Garantia:";
            // 
            // txtGarantia
            // 
            this.txtGarantia.Location = new System.Drawing.Point(381, 55);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(179, 20);
            this.txtGarantia.TabIndex = 9;
            this.txtGarantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subcategoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(748, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 27);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(748, 412);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(118, 27);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(748, 445);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 27);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(748, 478);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(45, 27);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "PDF";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnExportarXLS
            // 
            this.btnExportarXLS.Location = new System.Drawing.Point(821, 478);
            this.btnExportarXLS.Name = "btnExportarXLS";
            this.btnExportarXLS.Size = new System.Drawing.Size(45, 25);
            this.btnExportarXLS.TabIndex = 7;
            this.btnExportarXLS.Text = "XLS";
            this.btnExportarXLS.UseVisualStyleBackColor = true;
            this.btnExportarXLS.Click += new System.EventHandler(this.btnExportarXLS_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(883, 519);
            this.Controls.Add(this.btnExportarXLS);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Productos";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSubcategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExportarXLS;
    }
}