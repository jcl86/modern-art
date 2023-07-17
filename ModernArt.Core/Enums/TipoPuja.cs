using ModernArt.Core.Attributes;
using System.ComponentModel;

namespace ModernArt.Core.Enums
{
    public enum TipoPuja
    {
        [Nombre("Abierta")]
        [Description("Todos los jugadores pueden pujar en cualquier orden")]
        Abierta = 1,

        [Nombre("A Una Vuelta")]
        [Description("De izquierda a derecha, todos los jugadores pueden pujar solo una vez, " +
        "terminando el jugador que ha sacado a subasta el cuadro")]
        UnaVuelta = 2,

        [Nombre("Secreta")]
        [Description("Los jugadores hacen su puja en secreto y muestran su apuesta a la vez")]
        Secreta = 3,

        [Nombre("Precio Fijo")]
        [Description("El subastador fija un precio para el cuadro. Los jugadores podrán optar, en orden, por comprarlo. " +
        "Si ninguno de los jugadores quiere hacerse con el, el subastador se verá obligado a comprar el cuadro.")]
        PrecioFijo = 4,

        [Nombre("Doble")]
        [Description("Permite sacar un segundo cuadro del mismo autor, el cual marcará el tipo de subasta para vender ambos")]
        Doble = 5
    }
}
