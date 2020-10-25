using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PATRON_DAO_DTO_SINGLETON.UI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 5. De doble click en el menustrip clientes, para crear lo siguiente
            FormClientes frm = FormClientes.ObtenerInstancia();
            frm.MdiParent = this;
            frm.Show();
            // Para que el formulario no se quede atras
            frm.BringToFront();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLibros frm = FormLibros.ObtenerInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }
    }
}
