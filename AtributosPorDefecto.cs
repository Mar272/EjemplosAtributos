using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;

// -------------------------------------------
// Ejemplo 1: [Obsolete]
// Marca un método como obsoleto, mostrando advertencia si se usa.
public class EsObsoleto
{
    [Obsolete("Usa el método 'MetodoNuevo' en lugar de este.")]
    public void MetodoAntiguo()
    {
        Console.WriteLine("Este metodo es obsoleto.");
    }
}

// -------------------------------------------
// Ejemplo 2: [Serializable] y [NonSerialized]
// Permite serializar una clase, pero excluye ciertos campos.
[Serializable]
public class Usuario
{
    public string Nombre;

    [NonSerialized] // Este campo no será serializado
    public string Contrasena;
}

// -------------------------------------------
// Ejemplo 3: [DllImport]
// Permite llamar funciones de una librería externa (Win32 API, por ejemplo).
public class Sistema
{
    [DllImport("user32.dll")]
    public static extern int MessageBox(IntPtr hWnd, string texto, string titulo, uint tipo);
}

// -------------------------------------------
// Ejemplo 4: [StructLayout]
// Controla cómo se almacena un struct en memoria.
[StructLayout(LayoutKind.Sequential)]
public struct Punto
{
    public int X;
    public int Y;
}

// -------------------------------------------
// Ejemplo 5: [Required], [Key], [Range]
// Usados en ASP.NET Core para validación de modelos.
public class Producto
{
    [Key] // Marca como clave primaria en una base de datos
    public int Id { get; set; }

    [Required] // Este campo es obligatorio
    public string Nombre { get; set; }

    [Range(0, 1000)] // Solo se permiten valores entre 0 y 1000
    public double Precio { get; set; }
}

// -------------------------------------------
// Ejemplo 6: [HttpGet], [HttpPost]
// En un controlador ASP.NET Core para definir rutas.
[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    [HttpGet]
    public IActionResult ObtenerUsuarios()
    {
        return Ok(new[] { "Usuario1", "Usuario2" });
    }

    [HttpPost]
    public IActionResult CrearUsuario([FromBody] string nombre)
    {
        return Ok($"Usuario {nombre} creado");
    }
}


