namespace Polideportivo.Modelo
{
    internal class modeloRol
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public int fkIdDeporte { get; set; }

        public modeloRol()
        {
        }

        public modeloRol(int Id, string Nombre, int FkIdDeporte)
        {
            pkId = Id;
            nombre = Nombre;
            fkIdDeporte = FkIdDeporte;
            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }
    }
}