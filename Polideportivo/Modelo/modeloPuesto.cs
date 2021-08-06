using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polideportivo.Modelo
{
    class modeloPuesto
    {
        public int pkId { get; set; }
        public string nombre { get; set; }

        public modeloPuesto() { }

        public modeloPuesto(int Id, string Nombre)
        {
            pkId = Id;
            nombre = Nombre;
 
        }


    }

}
