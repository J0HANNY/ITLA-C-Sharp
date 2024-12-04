// Fig. 8.20: LibroCalificaciones.cs
using System;

public class LibroCalificaciones
{
    private string nombreCurso;
    private int[,] calificaciones; 
    
    public LibroCalificaciones(string nombre, int[,] arregloCalificaciones)
    {
        nombreCurso = nombre;
        calificaciones = arregloCalificaciones;
    }

    public string NombreCurso
    {
        get { return nombreCurso; }
        set { nombreCurso = value; }
    }

    public void MostrarMensaje()
    {
        Console.WriteLine("¡Bienvenido al libro de calificaciones para {0}!\n", nombreCurso);
    }

    public void ProcesarCalificaciones()
    {
        ImprimirCalificaciones();
        Console.WriteLine("La calificación más baja es {0}", ObtenerMinimo());
        Console.WriteLine("La calificación más alta es {0}", ObtenerMaximo());
    }

    public int ObtenerMinimo()
    {
        int califBaja = calificaciones[0, 0];
        foreach (int calif in calificaciones)
        {
            if (calif < califBaja)
                califBaja = calif;
        }
        return califBaja;
    }

    public int ObtenerMaximo()
    {
        int califAlta = calificaciones[0, 0];
        foreach (int calif in calificaciones)
        {
            if (calif > califAlta)
                califAlta = calif;
        }
        return califAlta;
    }

    public void ImprimirCalificaciones()
    {
        Console.WriteLine("Las calificaciones son:\n");
        for (int i = 0; i < calificaciones.GetLength(0); i++)
        {
            Console.Write("Estudiante {0}: ", i + 1);
            for (int j = 0; j < calificaciones.GetLength(1); j++)
            {
                Console.Write("{0} ", calificaciones[i, j]);
            }
            Console.WriteLine();
        }
    }
}
