/*
 * Creado por SharpDevelop.
 * Usuario: Johanny
 * Fecha: 22/11/2024
 * Hora: 23:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Bucles_for__1
{
	class Program
	{
		public static void Main(string[] args)
		{	
			//1) Dado un conjunto de datos representando las dimensiones de triángulos, calcular y contar aquellos cuya área excede un valor límite.

	        Console.Write("Ingrese el valor límite del área: ");
	        double limiteArea = Convert.ToDouble(Console.ReadLine());
	
	        int contador = 0;
	
	        for (int i = 0; i < 3; i++)
	        {
	        	Console.WriteLine("Ingrese las dimensiones del triángulo " + (i + 1) + ":");
	
	            Console.Write("Lado a: ");
	            double a = Convert.ToDouble(Console.ReadLine());
	            Console.Write("Lado b: ");
	            double b = Convert.ToDouble(Console.ReadLine());
	            Console.Write("Lado c: ");
	            double c = Convert.ToDouble(Console.ReadLine());
	
	            double s = (a + b + c) / 2;
	
	            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
	
	            Console.WriteLine("Área del triángulo " + (i + 1) + ": "+ area.ToString("F2"));
	
	            if (area > limiteArea)
	            {
	                contador++;
	            }
	
	            Console.WriteLine();
	        }
	
	        Console.WriteLine("Cantidad de triángulos con área mayor al límite:" + contador);
			
			Console.ReadKey(true);
		}
	}
}