using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CryptSharp;       //Claves encriptadas
using BOL;

namespace DESIGNER
{
    public partial class frmLogin : Form
    {
        //Instancia de la clase
        Usuario usuario = new Usuario();
        DataTable dtRpta = new DataTable();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            dtRpta = usuario.iniciarSesion(txtEmail.Text);
            MessageBox.Show(dtRpta.Rows.Count.ToString());
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {

        }
    }
}
