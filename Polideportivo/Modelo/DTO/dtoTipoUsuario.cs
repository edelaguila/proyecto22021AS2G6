namespace Modelo.DTO
{
    public class dtoTipoUsuario
    {
        public int pkId { get; set; }
        public string nombre { get; set; }

        public dtoTipoUsuario()
        {
        }

        public dtoTipoUsuario(int Id, string Nombre)
        {
            pkId = Id;
            nombre = Nombre;
        }
    }
}