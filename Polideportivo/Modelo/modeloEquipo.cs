modelo



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polideportivo.Modelo
{
    public class modeloEquipo
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public int fkIdDeporte { get; set; }
        public int fkIdEntrenador { get; set; }

        public modeloEquipo() { }

        public modeloEquipo(int Id, string Nombre, int IdDeporte, int IdEntrenador)
        {
            pkId = Id;
            nombre = Nombre;
            fkIdDeporte = IdDeporte;
            fkIdEntrenador = IdEntrenador;
            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }
    }
}