using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polideportivo.Modelo
{
    public class modeloEntrenador
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public int fkIdEquipo { get; set; }

        public modeloEntrenador() { }

        public modeloEntrenador(int Id, string Nombre, int IdEquipo)
        {
            pkId = Id;
            nombre = Nombre;
            fkIdEquipo = IdEquipo;

            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }

    }
}