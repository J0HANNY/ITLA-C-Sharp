/*
 * Creado por SharpDevelop.
 * Usuario: Johanny
 * Fecha: 22/11/2024
 * Hora: 23:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Bucles_for__3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//3) Desarrollar un programa que permita ingresar 10 números y luego muestre la suma de los últimos 5 números ingresados.
			
	        int[] numeros = new int[10];
	
	        for (int i = 0; i < 10; i++)
	        {
	            Console.Write("Ingrese el número " + (i + 1) + ": ");
	            numeros[i] = Convert.ToInt32(Console.ReadLine());
	        }

	        int sumaUltimos = 0;
	        for (int i = 5; i < 10; i++)
	        {
	            sumaUltimos += numeros[i];
	        }
	
	        Console.WriteLine("La suma de los últimos 5 números ingresados es: " + sumaUltimos);

			
			Console.ReadKey(true);
		}
	}
}