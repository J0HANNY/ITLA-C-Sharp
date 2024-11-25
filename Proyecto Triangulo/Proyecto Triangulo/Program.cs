/*
 * Creado por SharpDevelop.
 * Usuario: Johanny
 * Fecha: 24/11/2024
 * Hora: 20:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_Triangulo
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			/*Desarrollar programa que calcule la base, altura y área de un triangulo
			Diseñar un algoritmo que:
			
			Solicite al usuario ingresar un número entero "n" que represente la cantidad de triángulos a procesar.
			Para cada triángulo, capture los valores de la base y la altura.
			Calcule el área de cada triángulo utilizando la fórmula correspondiente.
			Muestre en pantalla los datos de cada triángulo (base, altura y área).
			Determine y reporte la cantidad de triángulos con un área superior a 12 unidades cuadradas.*/
			
	        Console.Write("Ingrese la cantidad de triángulos a procesar: ");
	        int n = int.Parse(Console.ReadLine());
	
	        int countArea = 0;
	
	        for (int i = 1; i <= n; i++)
	        {
	            Console.WriteLine("\nTriángulo " + i + ":");
	
	            Console.Write("Ingrese la base del triángulo: ");
	            double baseTriangulo = double.Parse(Console.ReadLine());
	
	            Console.Write("Ingrese la altura del triángulo: ");
	            double alturaTriangulo = double.Parse(Console.ReadLine());
	
	            double area = (baseTriangulo * alturaTriangulo) / 2;
	
	            Console.WriteLine("Base: " + baseTriangulo + " Altura: " + alturaTriangulo +" Área: " + area);
	
	            if (area > 12)
	            {
	                countArea++;
	            }
	        }

	        Console.WriteLine("\nCantidad de triángulos con área superior a 12 unidades cuadradas: " + countArea);

			Console.ReadKey(true);
		}
	}
}