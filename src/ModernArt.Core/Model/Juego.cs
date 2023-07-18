using ModernArt.Core.Enums;
using ModernArt.Core.Negocio;
using System.Collections.Generic;
using System.Linq;

namespace ModernArt.Core.Model
{
    public class Juego
    {
        public List<Jugador> Jugadores { get; set; }
        public List<Cuadro> Mazo { get; set; }
        public int RondaActual { get; set; }
        public int Turno { get; set; }
        public int TurnoSubasta { get; set; }

        public Juego(List<Jugador> jugs)
        {
            Jugadores = jugs;
            Mazo = GameHelper.GetCuadros().ToList();
            RondaActual  = 1;

            Repartir();
            Turno = GameHelper.PrepararJugadorInicial(Jugadores.Count);
        }

        public void Repartir()
        {
            foreach (Jugador jug in Jugadores)
            {
                foreach (int num in Enumerable.Range(0, GameHelper.NumCartas(RondaActual, Jugadores.Count)))
                {
                    jug.Mano.Add(Mazo.First());
                    Mazo.Remove(Mazo.First());
                }
            }
        }
        public Jugador ElTurno() => Jugadores[Turno];
        public Jugador ElTurnoSubasta() => Jugadores[TurnoSubasta];
        public Jugador GetJugador(int id) => Jugadores.Find(x => x.Id == id);

        /// <summary>
        /// El turno pasa al siguiente jugador
        /// </summary>
        public void AvanzaTurno()
        {
            Turno = (Turno == Jugadores.Count - 1) ? 0 : Turno + 1;
            TurnoSubasta = Turno;
        }

        public int NumeroCuadros(Author autor, int ronda, Jugador jugador = null)
        {
            //Cuadros de todos los jugadores
            if (jugador == null) 
                Jugadores.SelectMany(x => x.Mano).Count(x => x.Vendido && x.Ronda == ronda && x.Pintor.GetAuthor.Equals(autor));

            //cuadros de un jugador en concreto
            return Jugadores.SelectMany(x => x.Mano).Count(x => x.Vendido && 
                                                                x.Ronda == ronda && 
                                                                x.Pintor.GetAuthor.Equals(autor) &&
                                                                x.Ganador().Value == jugador.Id);
        }
    }
}
