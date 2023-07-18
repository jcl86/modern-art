namespace ModernArt.Core.Model
{
    public class Puja
    {
        public int IdJugador { get; set; }
        public int Valor { get; set; }

        public Puja(int idJug, int valor)
        {
            IdJugador = idJug;
            Valor = valor;
        }
    }
}
