using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DTO
{
    public class dtoUsuario
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public int telefono { get; set; }
        public int fkIdTipo { get; set; }

        public dtoUsuario()
        {
        }

        public dtoUsuario(int Id, string Nombre, string Contraseña, int Telefono, int IdTipo)
        {
            pkId = Id;
            nombre = Nombre;
            contraseña = Contraseña;
            telefono = Telefono;
            fkIdTipo = IdTipo;
        }
    }
}