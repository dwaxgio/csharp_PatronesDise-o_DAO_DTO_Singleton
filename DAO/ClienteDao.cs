using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PATRON_DAO_DTO_SINGLETON.DTO;  // Accedo a DTO

namespace PATRON_DAO_DTO_SINGLETON.DAO
{
    class ClienteDao : ConexionDB // Heredan de ConexionDB
    {
        // 4. Esta clase sólo contiene métodos crud
        SqlDataReader LeerFilas; // Lee filas de tablas
        SqlCommand Comando = new SqlCommand(); // Para ejecutar sp o t-sql

        // METODOS CRUD
        public List<ClientesDTO> VerRegistros(string Condicion)
        {
            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros"; // Igual al SP de la DB
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", Condicion); // Parametro con el mismo valor de variable en sp. Se envia como parametro el metodo condicion 

            Conexion.Open();

            LeerFilas = Comando.ExecuteReader(); // Para ller filas de tablas
            List<ClientesDTO> ListaGenerica = new List<ClientesDTO>();

            // While: Mientras se leen filas, ir agregando registros a ListaGenerica
            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new ClientesDTO
                {
                    // Se asignan valores a los atributos de ClientesDTO
                    ID = LeerFilas.GetInt32(0), // Se envía como parametro el número de columna de la db que tiene el id (empezando desde 0)
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Ciudad = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Telefono = LeerFilas.GetString(6),
                    Ocupacion = LeerFilas.GetString(7),
                });
            }
            LeerFilas.Close();
            Conexion.Close();
            return ListaGenerica;
        }

        public void Insert()
        {

        }

        public void Edit()
        {

        }

        public void Delete()
        {

        }
    }
}
