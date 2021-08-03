using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polideportivo.Modelo
{
    public class modeloPartido
    {
        public int pkId { get; set; }
        public string equipo1 { get; set; }
        public string equipo2 { get; set; }
        public string campo { get; set; }
        public DateTime  fecha{ get; set; }
        public string estado { get; set; }
        public string fase { get; set; }
        public int fkIdCampeonato { get; set; }
        public int fkIdEmpleado { get; set; }
        public int fkIdResultado { get; set; }

        public modeloPartido() { }

        public modeloPartido(int Id, string Equipo1, string Equipo2, string Campo, DateTime Fecha, string Estado, string Fase, int IdCampeonato, int IdEmpleado, int IdResultado)
        {
            pkId = Id;
            equipo1 = Equipo1;
            equipo2 = Equipo2;
            campo = Campo;
            fecha = Fecha;
            estado = Estado;
            fase = Fase;
            fkIdCampeonato = IdCampeonato;
            fkIdEmpleado = IdEmpleado;
            fkIdResultado = IdResultado;
            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }
    }
}