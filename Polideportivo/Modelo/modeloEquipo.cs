namespace Polideportivo.Modelo
{
    public class modeloEquipo
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public int fkIdDeporte { get; set; }

        public modeloEquipo()
        {
        }

        public modeloEquipo(int Id, string Nombre, int IdDeporte)
        {
            pkId = Id;
            nombre = Nombre;
            fkIdDeporte = IdDeporte;
        }
    }
}