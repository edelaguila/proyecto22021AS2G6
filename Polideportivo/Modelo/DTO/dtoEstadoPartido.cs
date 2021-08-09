namespace Modelo.DTO
{
    public class dtoEstadoPartido
    {
        public int pkId { get; set; }
        public string nombre { get; set; }

        public dtoEstadoPartido()
        {
        }

        public dtoEstadoPartido(int Id, string Nombre)
        {
            pkId = Id;
            nombre = Nombre;
            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }
    }
}