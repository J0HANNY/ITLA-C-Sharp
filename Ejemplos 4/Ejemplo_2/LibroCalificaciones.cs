// Fig. 4.4: LibroCalificaciones.cs
using System;

public class LibroCalificaciones
{
    public void MostrarMensaje(string nombreCurso)
    {
        Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!", nombreCurso);
        Console.ReadKey(true);
    }
}
