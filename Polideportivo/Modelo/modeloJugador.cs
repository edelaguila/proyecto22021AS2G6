using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polideportivo.Modelo
{
    class modeloJugador
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int anotaciones { get; set; }
        public int idRol { get; set; }
        public int idEquipo { get; set; }

        public modeloJugador(){}

        public modeloJugador(int Id, string Nombre, int Anotaciones, int IdRol, int IdEquipo)
        {
            id = Id;
            nombre = Nombre;
            anotaciones = Anotaciones;
            idRol = IdRol;
            idEquipo = IdEquipo;
            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }
    }
}
