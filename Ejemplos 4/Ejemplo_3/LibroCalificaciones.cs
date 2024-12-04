// Fig. 4.7: LibroCalificaciones.cs
using System;

public class LibroCalificaciones
{
    private string nombreCurso;

    public string NombreCurso
    {
        get
        {
            return nombreCurso;
        }
        set
        {
            nombreCurso = value;
        }
    }

    public void MostrarMensaje()
    {
        Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!",
                          NombreCurso); 
    	Console.ReadKey(true);
    } 
}
