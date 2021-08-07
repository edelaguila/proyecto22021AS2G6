namespace Modelo
{
    public class modeloTipoCampeonato
    {
        public int pkId { get; set; }
        public string tipo { get; set; }

        public modeloTipoCampeonato()
        {
        }

        public modeloTipoCampeonato(int Id, string Tipo)
        {
            pkId = Id;
            tipo = Tipo;
        }
    }
}