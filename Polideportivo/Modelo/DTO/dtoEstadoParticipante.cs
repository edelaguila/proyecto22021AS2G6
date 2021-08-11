namespace Modelo.DTO
{
    public class dtoEstadoParticipante
    {
        public int pkId { get; set; }
        public string nombre { get; set; }

        public dtoEstadoParticipante()
        {
        }

        public dtoEstadoParticipante(int Id, string Nombre)
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