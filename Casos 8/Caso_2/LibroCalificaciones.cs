// Fig. 8.15: LibroCalificaciones.cs
using System;

public class LibroCalificaciones
{
    private string nombreCurso;
    private int[] calificaciones; 

    public LibroCalificaciones(string nombre, int[] arregloCalificaciones)
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
        Console.WriteLine("¡Bienvenido al libro de calificaciones para {0}!", nombreCurso);
    }

    public void ProcesarCalificaciones()
    {
        ImprimirCalificaciones();
        Console.WriteLine("El promedio de la clase es {0:F}", ObtenerPromedio());
        Console.WriteLine("La calificación más alta es {0}", ObtenerMaximo());
        Console.WriteLine("La calificación más baja es {0}", ObtenerMinimo());
    }

    public int ObtenerMaximo()
    {
        int califAlta = calificaciones[0];
        foreach (int calif in calificaciones)
        {
            if (calif > califAlta)
                califAlta = calif;
        }
        return califAlta;
    }

    public int ObtenerMinimo()
    {
        int califBaja = calificaciones[0];
        foreach (int calif in calificaciones)
        {
            if (calif < califBaja)
                califBaja = calif;
        }
        return califBaja;
    }

    public double ObtenerPromedio()
    {
        int total = 0;
        foreach (int calif in calificaciones)
        {
            total += calif;
        }
        return (double)total / calificaciones.Length;
    }

    public void ImprimirCalificaciones()
    {
        Console.WriteLine("Las calificaciones son:\n");
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine("Estudiante {0,2}: {1}", i + 1, calificaciones[i]);
        }
    }
}
