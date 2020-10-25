using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON_DAO_DTO_SINGLETON.DTO
{
    class ClientesDTO
    {
        // 1. Se crea db con sp
        // 2. Se crean carpetas DAO, DTO Y UI
        //Esta clase DTO contiene 
        // ATRIBUTOS
        // Atributos deberian ser privados, si no se especifica, vs lo toma como privado

        int _ID;
        string _Nombre;
        string _Apellido;
        string _Direccion;
        string _Ciudad;
        string _Email;
        string _Telefono;
        string _Ocupacion;

        // PROPIEDADES GETTERS Y SETTERS
        // Se encapsula, dando clic derecho - encapsular y usar propiedades
        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Ocupacion { get => _Ocupacion; set => _Ocupacion = value; }
    }
}
