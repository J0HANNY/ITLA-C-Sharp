using System;
using System.Collections.Generic;
using System.Linq;

class Alumno
{

    public string Nombre { get; set; }
    public string Matricula { get; set; }
    public string Carrera { get; set; }
    public List<int> Calificaciones { get; set; } 
    
    public Alumno()
    {
        Calificaciones = new List<int>();
    }


    public double CalcularPromedio()
    {
        if (Calificaciones.Count == 0)
        {
            return 0;
        }
        return Calificaciones.Average();
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Matrícula: " + Matricula);
        Console.WriteLine("Carrera: " + Carrera);
        Console.WriteLine("Promedio: " + CalcularPromedio().ToString("F2"));
    }

    static void Main(string[] args)
    {
        Alumno alumno = new Alumno();

        Console.WriteLine("Ingrese el nombre del alumno:");
        alumno.Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la matrícula del alumno:");
        alumno.Matricula = Console.ReadLine();

        Console.WriteLine("Ingrese la carrera del alumno:");
        alumno.Carrera = Console.ReadLine();

        Console.WriteLine("Ingrese las calificaciones del alumno separadas por comas:");
        string[] calificacionesInput = Console.ReadLine().Split(',');
        alumno.Calificaciones = calificacionesInput.Select(int.Parse).ToList();

        alumno.MostrarInformacion();
        
        Console.ReadKey(true);
    }
}
