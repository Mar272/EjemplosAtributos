using System;

public class AtributosPorDefecto
{
    // -------------------------------------------
    //  Ejemplo de custom 1
    // Este atributo permite añadir una descripción a una clase.
    [AttributeUsage(AttributeTargets.Class)]
    public class DescripcionAttribute : Attribute
    {
        public string Texto { get; }

        public DescripcionAttribute(string texto)
        {
            Texto = texto;
        }
    }

    // -------------------------------------------
    // Ejemplo de custom 2
    // Este atributo indica si se deben registrar cambios en una clase
    [AttributeUsage(AttributeTargets.Class)]
    public class CambiosAttribute : Attribute
    {
        public bool Activo { get; }

        public CambiosAttribute(bool activo = true)
        {
            Activo = activo;
        }
    }
}

