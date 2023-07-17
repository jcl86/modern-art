namespace ModernArt.Core.Model
{
    public struct Valoracion
    {
        public int Fuerza;
        public int Color;
        public int Atrevimiento;

        public Valoracion(int fuerza, int color, int atrevimiento)
        {
            Fuerza = fuerza;
            Color = color;
            Atrevimiento = atrevimiento;
        }

        public double Media() => (Fuerza + Color + Atrevimiento) / 3;

        public int ValoracionTotal() => Fuerza + Color + Atrevimiento;
    }
}
