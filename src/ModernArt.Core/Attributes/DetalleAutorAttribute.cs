using System;

namespace ModernArt.Core.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class DetalleAutorAttribute : Attribute
    {
        public string Nacionalidad { get; set; }
        public int YearNacimiento { get; set; }
        public int YearMuerte { get; set; }
        public string Descripcion { get; set; }

        public DetalleAutorAttribute(string nacionalidad, int yearNacimiento, int yearMuerte, string descripcion)
        {
            Nacionalidad = nacionalidad;
            YearNacimiento = yearNacimiento;
            YearMuerte = yearMuerte;
            Descripcion = descripcion;
        }
    }
}
