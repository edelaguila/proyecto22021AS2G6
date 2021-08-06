namespace Modelo
{
    public class modeloJugador
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public int anotaciones { get; set; }
        public int fkIdEquipo { get; set; }
        public int fkIdRol { get; set; }
        public int fkIdDeporte { get; set; }

        public modeloJugador()
        {
        }

        public modeloJugador(int Id, string Nombre, int Anotaciones, int IdEquipo, int IdRol, int IdDeporte)
        {
            pkId = Id;
            nombre = Nombre;
            anotaciones = Anotaciones;
            fkIdEquipo = IdEquipo;
            fkIdRol = IdRol;
            fkIdDeporte = IdDeporte;
            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }
    }
}