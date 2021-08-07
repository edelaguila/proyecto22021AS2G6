namespace Modelo
{
    public class modeloPuesto
    {
        public int pkId { get; set; }
        public string nombre { get; set; }

        public modeloPuesto()
        {
        }

        public modeloPuesto(int Id, string Nombre)
        {
            pkId = Id;
            nombre = Nombre;
        }
    }
}