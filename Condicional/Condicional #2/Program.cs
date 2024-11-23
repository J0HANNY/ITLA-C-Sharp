/*
 * Creado por SharpDevelop.
 * Usuario: Johanny
 * Fecha: 8/11/2024
 * Hora: 17:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Condicional__2
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Leer tres calificaciones y calcular el promedio. Si el promedio es igual o superior a siete, 
			//imprimir un mensaje indicando que el alumno ha aprobado.
			
	        Console.Write("Ingrese la primera calificación: ");
	        double calificacion1 = Convert.ToDouble(Console.ReadLine());
	        
	        Console.Write("Ingrese la segunda calificación: ");
	        double calificacion2 = Convert.ToDouble(Console.ReadLine());
	        
	        Console.Write("Ingrese la tercera calificación: ");
	        double calificacion3 = Convert.ToDouble(Console.ReadLine());
	

	        double promedio = (calificacion1 + calificacion2 + calificacion3) / 3;
	
	
	        Console.WriteLine("Promedio: " + promedio);
	        if (promedio >= 7){
	            Console.WriteLine("El alumno ha aprobado.");
	        }
	        else{
	            Console.WriteLine("El alumno no ha aprobado.");
	        }
			
			Console.ReadKey(true);
		}
	}
}