namespace Modelo.DTO
{
    public class dtoPuesto
    {
        public int pkId { get; set; }
        public string nombre { get; set; }

        public dtoPuesto()
        {
        }

        public dtoPuesto(int Id, string Nombre)
        {
            pkId = Id;
            nombre = Nombre;
        }
    }
}