namespace Modelo.DTO
{
    public class dtoAnotacion
    {
        public int pkId { get; set; }
        public int cantidad { get; set; }
        public int fkIdJugador { get; set; }
        public int fkIdPartido { get; set; }

        public dtoAnotacion()
        {
        }

        public dtoAnotacion(int Id, int Cantidad, int IdJugador, int IdPartido)
        {
            pkId = Id;
            cantidad = Cantidad;
            fkIdJugador = IdJugador;
            fkIdPartido = IdPartido;
        }
    }
}