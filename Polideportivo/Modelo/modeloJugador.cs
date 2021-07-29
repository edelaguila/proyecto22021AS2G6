using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polideportivo.Modelo
{
    public class modeloJugador
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public int anotaciones { get; set; }
        public int fkIdEquipo { get; set; }
        public int fkIdRol { get; set; }

        public modeloJugador(){}

        public modeloJugador(int Id, string Nombre, int Anotaciones, int IdEquipo, int IdRol)
        {
            pkId = Id;
            nombre = Nombre;
            anotaciones = Anotaciones;
            fkIdEquipo = IdEquipo;
            fkIdRol = IdRol;
            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }
    }
}
