/*
 * Creado por SharpDevelop.
 * Usuario: Johanny
 * Fecha: 8/11/2024
 * Hora: 17:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Condicional_1

{
	class Program
	{
		public static void Main(string[] args)
		{
			// 1) Diseñar un programa que solicite al usuario dos números y, si el primer número es más grande, 
			//calcule y muestre su suma y resta. De lo contrario, calculará y mostrará su producto y cociente.
			
	        Console.Write("Ingrese el primer número: ");
	        double num1 = Convert.ToDouble(Console.ReadLine());
	        
	        Console.Write("Ingrese el segundo número: ");
	        double num2 = Convert.ToDouble(Console.ReadLine());
	

	        if (num1 > num2){
	            double suma = num1 + num2;
	            double resta = num1 - num2;
	            
	            Console.WriteLine("Suma: " + suma);
	            Console.WriteLine("Resta: " + resta);
	        }
	        else{

	        	if (num2 != 0){
	                double producto = num1 * num2;
	                double cociente = num1 / num2;
	                
	                Console.WriteLine("Producto: " + producto);
	                Console.WriteLine("Cociente: " + cociente);
	            }
	            else{
	                Console.WriteLine("El segundo número es cero, no se puede dividir.");
	            }
	        }
				
				Console.ReadKey(true);
		}
	}
}