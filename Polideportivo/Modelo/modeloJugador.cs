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
        public string equipo { get; set; }
        public string rol { get; set; }

        public modeloJugador(){}

        public modeloJugador(int Id, string Nombre, string Equipo, string Rol)
        {
            id = Id;
            nombre = Nombre;
            equipo = Equipo;
            rol = Rol;
            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }
    }
}
