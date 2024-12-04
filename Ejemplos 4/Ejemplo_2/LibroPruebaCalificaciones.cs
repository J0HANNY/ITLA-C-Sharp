// Fig. 4.5: LibroPruebaCalificaciones.cs
using System;

public class LibroPruebaCalificaciones
{
    public static void Main(string[] args)
    {
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones();

        Console.WriteLine("Por favor escriba el nombre del curso:");
        string nombreDelCurso = Console.ReadLine(); 
        Console.WriteLine();

        miLibroCalificaciones.MostrarMensaje(nombreDelCurso);
    } 
} 
