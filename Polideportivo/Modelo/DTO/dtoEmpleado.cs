using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DTO
{
    public class dtoEmpleado
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public int fkIdPuestoEmpleado { get; set; }

        public dtoEmpleado()
        {
        }

        public dtoEmpleado(int Id, string Nombre, int IdEquipo, int IdPuestoEmpleado)
        {
            pkId = Id;
            nombre = Nombre;
            fkIdPuestoEmpleado = IdPuestoEmpleado;
        }
    }
}