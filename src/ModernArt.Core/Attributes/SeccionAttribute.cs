using System;

namespace ModernArt.Core.Attributes
{
    public class SeccionAttribute : Attribute
    {
        public string Seccion { get; set; }

        public SeccionAttribute(string seccion)
        {
            Seccion = seccion;
        }
    }
}
