using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PATRON_DAO_DTO_SINGLETON
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.FormPrincipal()); // Al arrojar error proque se elimino formualario que viene en la creacion del proyecto. Para solucion, se referencia formulario principal
        }
    }
}
