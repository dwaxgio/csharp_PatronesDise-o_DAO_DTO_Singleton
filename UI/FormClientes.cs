using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PATRON_DAO_DTO_SINGLETON.DAO;// Referenciar a la carpeta DAO

namespace PATRON_DAO_DTO_SINGLETON.UI
{
    public partial class FormClientes : Form
    {
        // 9. PATRON SINGLETON, para que solo se abra un formulario
        private FormClientes() // 9.2 Constructor debe ser privado, para evitar que sea instanciado
        {
            InitializeComponent();
        }
        // 9.3 Se inicializa instancia como null
        private static FormClientes Instancia = null;

        // Condicional, si no existe instancia, se crea nuevo formulario
        public static FormClientes ObtenerInstancia() // Se encarga de obtener instancia única
        {
            if (Instancia == null){ Instancia = new FormClientes(); }
            return Instancia; // Se tetorna formulario como objeto
        }



        // MOSTRAR TODO 
        private void Clientes_Load(object sender, EventArgs e)
        {
            // 6.2 Al cargar formulario, se carga metodo VerRegistros()
            VerRegistros(""); // Como parametro se envia vacio, para que muestre todos los registros
        }
        // 6. Se crea método privado para ver listado de clientes
        
        // METODO VER REGISTROS
         private void VerRegistros(string condicion)
        {
            ClienteDao DAO = new ClienteDao();
            dataGridView1.DataSource = DAO.VerRegistros(condicion);
        }

        // BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // 7. Luego de agregar textBox y Boton buscar, agregar
            // Invocar el metodo de ver registros
            VerRegistros(txtBuscar.Text); // Se envia como parametro el texto del textBox
        }

        // FILTRAR
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // 8. Copiar el mismo método para realizar búsqueda
            VerRegistros(txtBuscar.Text);
        }
    }
}
