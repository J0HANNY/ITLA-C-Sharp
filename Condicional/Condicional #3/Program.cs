/*
 * Creado por SharpDevelop.
 * Usuario: Johanny
 * Fecha: 8/11/2024
 * Hora: 17:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Condicional__3
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*3) Desarrollar un programa que calcule el nivel de un postulante a partir de los resultados de un test. 
			 programa recibirá como entrada el número total de preguntas y las respuestas correctas,
			y devolverá un nivel según el porcentaje de aciertos.*/
			
	        Console.Write("Ingrese el número total de preguntas: ");
	        int totalPreguntas = Convert.ToInt32(Console.ReadLine());
	
	        Console.Write("Ingrese el número de respuestas correctas: ");
	        int respuestasCorrectas = Convert.ToInt32(Console.ReadLine());
	
	        double porcentaje = (double)respuestasCorrectas / totalPreguntas * 100;
	
	        Console.WriteLine("Porcentaje de aciertos: " + porcentaje + "%");
	
	        
	        if (porcentaje >= 90)
	        {
	            Console.WriteLine("Nivel máximo");
	        }
	        else if (porcentaje >= 75)
	        {
	            Console.WriteLine("Nivel medio");
	        }
	        else if (porcentaje >= 50)
	        {
	            Console.WriteLine("Nivel regular");
	        }
	        else
	        {
	            Console.WriteLine("Fuera de nivel");
	        }
				
			Console.ReadKey(true);
		}
	}
}