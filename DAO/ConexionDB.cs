using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PATRON_DAO_DTO_SINGLETON.DAO
{
    class ConexionDB
    {
        // 3. Sera una super clase, que será heredada de todas las clases DAO
        protected SqlConnection Conexion = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB;Database=Practica_Patrones;User=sa;Pwd=Unemamad249");
    }
} 
