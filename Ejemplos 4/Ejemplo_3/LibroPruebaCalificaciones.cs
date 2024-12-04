// Fig. 4.8: PruebaLibroCalificaciones.cs
using System;

public class PruebaLibroCalificaciones
{
    public static void Main(string[] args)
    {
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones();

        Console.WriteLine("El nombre inicial del curso es: '{0}'\n",
                          miLibroCalificaciones.NombreCurso);

        Console.WriteLine("Por favor escriba el nombre del curso:");
        string elNombre = Console.ReadLine(); 
        miLibroCalificaciones.NombreCurso = elNombre;  
        Console.WriteLine(); 

        miLibroCalificaciones.MostrarMensaje();
    } 
}
