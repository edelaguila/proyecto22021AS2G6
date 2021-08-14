namespace Modelo.DTO
{
    public class dtoEntrenador
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public int fkIdEquipo { get; set; }
        public int fkIdDeporte { get; set; }

        public dtoEntrenador()
        {
        }

        public dtoEntrenador(int Id, string Nombre, int IdEquipo, int IdDeporte)
        {
            pkId = Id;
            nombre = Nombre;
            fkIdEquipo = IdEquipo;
            fkIdDeporte = IdDeporte;
        }
    }
}