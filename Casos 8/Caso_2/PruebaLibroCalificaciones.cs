// Fig. 8.16: PruebaLibroCalificaciones.cs
using System;

public class PruebaLibroCalificaciones
{
    public static void Main(string[] args)
    {
        int[] arregloCalificaciones = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

        LibroCalificaciones miLibroCalificaciones =
            new LibroCalificaciones("CS101 Introducción a la programación en C#", arregloCalificaciones);

        miLibroCalificaciones.MostrarMensaje();
        miLibroCalificaciones.ProcesarCalificaciones();
    }
}
