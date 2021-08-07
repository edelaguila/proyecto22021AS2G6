using System;

namespace Modelo
{
    public class modeloPartido
    {
        public int pkId { get; set; }
        public string equipo1 { get; set; }
        public string equipo2 { get; set; }
        public int anotacionesEquipo1 { get; set; }
        public int anotacionesEquipo2 { get; set; }
        public string campo { get; set; }
        public string fecha { get; set; }
        public string fase { get; set; }
        public int fkIdCampeonato { get; set; }
        public int fkIdEmpleado { get; set; }
        public int fkIdEstado { get; set; }

        public modeloPartido()
        {
        }

        public modeloPartido(int Id, string Equipo1, string Equipo2, string Campo, string Fecha, string Estado, string Fase, int IdCampeonato, int IdEmpleado, int IdResultado, int IdEstado, int anotacion1, int anotacion2)
        {
            pkId = Id;
            equipo1 = Equipo1;
            equipo2 = Equipo2;
            campo = Campo;
            fecha = Fecha;
            fase = Fase;
            fkIdCampeonato = IdCampeonato;
            fkIdEmpleado = IdEmpleado;
            fkIdEstado = IdEstado;
            anotacionesEquipo1 = anotacion1;
            anotacionesEquipo2 = anotacion2;

            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }
    }
}