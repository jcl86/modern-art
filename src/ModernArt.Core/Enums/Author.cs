using ModernArt.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernArt.Core.Enums
{
    public enum Author
    {
        [DetalleAutor("Bélgica", 1900, 1964, 
        "Excelente exponente del arte moderno, con confictos extrasensoriales y problemas graves que le hicieron crear " +
            "obras maestras contemporáneas.")]
        Nex = 1,

        [DetalleAutor("Alemania", 1893, 1959,
        "Ilustre compositor de arte ordenado, parte fundamental del modernismo clásico, fue el primero de los grandes autores " +
            "del nuevo siglo, del que bebieron los artistas posteriores.")]
        Bahut = 2,

        [DetalleAutor("Francia", 1942, 1999,
        "Destacado artista conceptual enmarcado en la corriente pop art, con toques dadaistas e influencias knezieanas.")]
        Darmoir = 3,

        [DetalleAutor("Noruega", 1912, 1984,
        "Alumno abanderado de Rodalf Skwark, consiguió hacer creer a toda una generacíón que el simplismo y el cubismo eran una " +
            "caja de hacer dinero cuando se combinaban de manera inspiradora.")]
        Sadland = 4,

        [DetalleAutor("Japón", 1935, 1992,
        "Conocida como la jardinera del sol naciente, por dedicarse a esa actividad antes de alcanzar la fama con la novedosa " +
            "vuelta de tuerca que le dio al modernismo.")]
        Koriko = 5
    }
}
