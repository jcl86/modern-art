using ModernArt.Core.Attributes;
using ModernArt.Core.Enums;
using ModernArt.Core.Negocio;
using System;

namespace ModernArt.Core.Model
{
    public class Autor
    {
        private Author autor;

        public Autor(Author author)
        {
            autor = author;
        }

        public Author GetAuthor => autor;
        public string Nacionalidad => MetaDatos().Nacionalidad;
        public int Nacimiento => MetaDatos().YearNacimiento;
        public int Muerte => MetaDatos().YearMuerte;
        public string Descripcion => MetaDatos().Descripcion;

        private DetalleAutorAttribute MetaDatos()
        {
            Type type = autor.GetType();
            DetalleAutorAttribute atributo = Attribute.GetCustomAttribute(type.GetField(Enum.GetName(typeof(Author), autor)),
                               typeof(DetalleAutorAttribute)) as DetalleAutorAttribute;
            return atributo;
        }

        public override string ToString() => autor.ToString();

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return (obj as Autor).GetAuthor.Equals(autor);
        }

        public override int GetHashCode() => ((int)autor).GetHashCode();   
    }
}
