namespace Modelo.DTO
{
    public class dtoEquipo
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public int fkIdDeporte { get; set; }

        public dtoEquipo()
        {
        }

        public dtoEquipo(int Id, string Nombre, int IdDeporte)
        {
            pkId = Id;
            nombre = Nombre;
            fkIdDeporte = IdDeporte;
        }
    }
}