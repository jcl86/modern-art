using ModernArt.Core.Attributes;
using System.ComponentModel;

namespace ModernArt.Core.Enums
{
    public enum Galeria
    {
        [Nombre("Esnobs")]
        [Description("Las apariencias son los más importante. Elegancia, distinción y saber estar son nuestras máximas.")]
        [Seccion("Conservadores")]
        Esnobs = 1,

        [Nombre("Góticos")]
        [Description("Oscuridad.La alternativa al camino establecido y a las directrices marcadas por la alta sociedad.Nos fascina el rechazo que provocamos en los conservadores, al vernos irrumpir en su mundo y rivalizar con ellos.")]
        [Seccion("Alternativos")]
        Goticos = 2,

        [Nombre("Modernos")]
        [Description("Las reglas están para cambiarlas.Nos encanta romper las modas y crear nuevas tendencias, a pesar de que el resto de las altas esferas pongan el grito en el cielo.Gafapasteo y leña al mono")]
        [Seccion("Innovadores")]
        Modernos = 3,

        [Nombre("Hippies")]
        [Description("La libertad en el arte. Paz, amor, fraternidad y psicodelia.")]
        [Seccion("Alternativos")]
        Hippies = 4,

        [Nombre("Ricachones")]
        [Description("El poder del dinero. Siempre en pos de lo mejor y lo que tenga más valor")]
        [Seccion("Conservadores")]
        Ricachones = 5
    }
}
