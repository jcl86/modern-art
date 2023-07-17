using ModernArt.Core.Enums;
using System.Collections.Generic;

namespace ModernArt.Core.Model
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Dinero { get; set; }
        public Galeria GaleriaArte { get; set; }
        public string Ciudad { get; set; }
        public List<Cuadro> Mano { get; set; }
        public bool HaPasado { get; set; }

        public Jugador(int id, string nombre, Galeria galeriaArte, string ciudad)
        {
            Id = id;
            Nombre = nombre;
            GaleriaArte = galeriaArte;
            Ciudad = ciudad;
            Reset();
        }
        public void Reset()
        {
            Dinero = 100;
            Mano = new List<Cuadro>();
            HaPasado = false;
        }

        public override string ToString() => $"{Nombre} ({GaleriaArte.Nombre()})";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return (obj as Jugador).Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
