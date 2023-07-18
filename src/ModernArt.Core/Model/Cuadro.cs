using ModernArt.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ModernArt.Core.Model
{
    public class Cuadro
    {
        private string nombre;

        public int Id { get; private set; }
        public string Nombre { get; set; }
        public Autor Pintor { get; set; }
        public TipoPuja TipoDePuja { get; set; }
        public Valoracion Valor { get; set; }
        public int? IdSubastador { get; set; }
        public int? Ronda { get; set; }
        public List<Puja> Pujas { get; set; }
        public bool Vendido { get; set; }

        public Cuadro(int id, string nombre, Autor pintor, TipoPuja tipoDePuja, Valoracion valor)
        {
            Nombre = nombre;
            Id = id;
            Nombre = nombre;
            Pintor = pintor;
            TipoDePuja = tipoDePuja;
            Valor = valor;
            Pujas = new List<Puja>();
            Vendido = false;
        }

        public string Foto() => Pintor.ToString().ToLower() + Id;
        public override string ToString() => nombre;
        public string ToLongString() => $"{nombre} ({Pintor})" ;

        public int? PujaGanadora() => Pujas.Max(x => x.Valor);
        public int? Ganador() => Pujas.FirstOrDefault(x=> x.Valor == Pujas.Max(p => p.Valor))?.IdJugador;

        public void SacarSubasta(int idJugador, int ronda, int? precioInicial = null)
        {
            IdSubastador = idJugador;
            Ronda = ronda;
            if (TipoDePuja.Equals(TipoPuja.PrecioFijo))
            {
                if (precioInicial.HasValue)
                    throw new ArgumentException("Se debe determinar un precio inicial");
                Pujas.Add(new Puja(idJugador, precioInicial.Value));
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return (obj as Cuadro).Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
