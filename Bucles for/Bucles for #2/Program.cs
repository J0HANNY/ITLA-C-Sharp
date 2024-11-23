/*
 * Creado por SharpDevelop.
 * Usuario: Johanny
 * Fecha: 22/11/2024
 * Hora: 23:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Bucles_for__2
{
	class Program
	{
		public static void Main(string[] args)
		{

			//2) Crear un programa que cuente cuántos números, de un conjunto de 10, son divisibles por 3 o por 5.
			
	        int contador = 0;
	
	        for (int i = 0; i < 10; i++)
	        {
	            Console.Write("Ingrese el número " + (i + 1) + ": ");
	            int numero = Convert.ToInt32(Console.ReadLine());
	
	            if (numero % 3 == 0 || numero % 5 == 0)
	            {
	                contador++;
	            }
	        }
	
	        Console.WriteLine("Cantidad de números divisibles por 3 o 5: " + contador);
			
			Console.ReadKey(true);
		}
	}
}