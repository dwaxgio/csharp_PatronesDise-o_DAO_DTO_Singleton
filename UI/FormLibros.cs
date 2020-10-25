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
    public partial class FormLibros : Form
    {
        private FormLibros()
        {
            InitializeComponent();
        }

        private static FormLibros Instancia = null;

        public static FormLibros ObtenerInstancia()
        {
            if(Instancia == null)
            {
                Instancia = new FormLibros();
            }
            return Instancia;
        }
    }
}
