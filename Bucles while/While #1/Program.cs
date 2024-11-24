/*
 * Creado por SharpDevelop.
 * Usuario: Johanny
 * Fecha: 23/11/2024
 * Hora: 21:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace While__1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			/*Implementa una aplicación que solicite diez calificaciones numéricas y calcule la cantidad de 
			estudiantes que alcanzaron una calificación mínima de 7 y la cantidad que quedó por debajo de este límite.*/
			
			int aprobados = 0;
	        int reprobados = 0;
	        int calificacion;
	        int i = 0;
	
	        
	        while (i < 10)
	        {
	            Console.WriteLine("Ingrese la calificación del estudiante #" + (i + 1) + ": ");
	            calificacion = int.Parse(Console.ReadLine());
	
	            if (calificacion >= 0 && calificacion <= 10)
	            {
	                if (calificacion >= 7)
	                {
	                    aprobados++;
	                }
	                else
	                {
	                	reprobados++;
	                }
	                i++; 
	            }
	            else
	            {
	                Console.WriteLine("Por favor, ingrese una calificación válida entre 0 y 10.");
	            }
	        }
	
	        Console.WriteLine("\nResultados:");
	        Console.WriteLine("Estudiantes aprobados: " + aprobados);
	        Console.WriteLine("Estudiantes reprobados: " + reprobados);
			
			Console.ReadKey(true);
		}
	}
}