/*
 * Creado por SharpDevelop.
 * Usuario: Johanny
 * Fecha: 1/12/2024
 * Hora: 19:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Caso_2
{
	class Program
	{
		static void Main()
 	   {
		
	        int[] calificaciones = { 85, 92, 78, 95, 88 };
	
	        Console.WriteLine("Calificaciones:");
	        foreach (var calificacion in calificaciones)
	        {
	            Console.WriteLine(calificacion);
	        }
	
	        // Calificación máxima
	        int max = int.MinValue;
	        int min = int.MaxValue;
	        int suma = 0;
	
	        foreach (var calificacion in calificaciones)
	        {
	            if (calificacion > max) max = calificacion;
	            if (calificacion < min) min = calificacion;
	            suma += calificacion;
	        }
	
	        double promedio = (double)suma / calificaciones.Length;
	
	        Console.WriteLine("Calificación más alta: " + max);
	        Console.WriteLine("Calificación más baja: " + min);
	        Console.WriteLine("Promedio: " + promedio);

			Console.ReadKey(true);
		}
	}
}