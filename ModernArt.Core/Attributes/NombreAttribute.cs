using System;

namespace ModernArt.Core.Attributes
{
    public class NombreAttribute : Attribute
    {
        public string Nombre { get; set; }

        public NombreAttribute(string nombre)
        {
            Nombre = nombre;
        }
    }
}
