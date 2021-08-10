namespace Modelo
{
    public class dtoTipoCampeonato
    {
        public int pkId { get; set; }
        public string tipo { get; set; }

        public dtoTipoCampeonato()
        {
        }

        public dtoTipoCampeonato(int Id, string Tipo)
        {
            pkId = Id;
            tipo = Tipo;
        }
    }
}