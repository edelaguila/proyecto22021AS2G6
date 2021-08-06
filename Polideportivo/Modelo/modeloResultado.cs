using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polideportivo.Modelo
{
    public class modeloResultado
    {
        public int pkId { get; set; }

        public int anotacionEquipo1 { get; set; }

        public int anotacionEquipo2 { get; set; }

        public modeloResultado()
        {
        }

        public modeloResultado(int Id, int AnotacionEquipo1, int AnotacionEquipo2)
        {
            pkId = Id;
            anotacionEquipo1 = AnotacionEquipo1 ;
            anotacionEquipo2 = AnotacionEquipo2;


            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }
    }
}
