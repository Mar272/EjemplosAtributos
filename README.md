# Ejemplos de Atributos en C#

Este repositorio contiene ejemplos prácticos del uso de atributos en C#, tanto por defecto del lenguaje como personalizados. Los atributos permiten agregar metadatos a clases, métodos, propiedades, etc., y son ampliamente utilizados para propósitos como validación, serialización, interoperabilidad y configuración de controladores web.

## Estructura del Repositorio

- `AtributosPorDefecto.cs`: Contiene ejemplos comentados de atributos predefinidos en C#, incluyendo:
  - `[Obsolete]`
  - `[Serializable]`
  - `[NonSerialized]`
  - `[DllImport]`
  - `[StructLayout]`
  - `[Required]`
  - `[Key]`
  - `[Range]`
  - `[HttpGet]`, `[HttpPost]`

- `AtributosCustom.cs`: Archivo independiente con dos atributos personalizados:
  - `DescripcionAttribute`: Permite agregar una descripción a una clase.
  - `CambiosAttribute`: Este atributo indica si se deben registrar cambios en una clase.
