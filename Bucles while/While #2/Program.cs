/*
 * Creado por SharpDevelop.
 * Usuario: Johanny
 * Fecha: 23/11/2024
 * Hora: 21:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace While__2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			/*Escribe un algoritmo que, para una empresa con 'n' empleados y un rango salarial de $100 a $500, cuente cuántos empleados se 
			encuentran en cada uno de los siguientes grupos: $100-$300 y mayor a $300. Asimismo, calcula el gasto total en nómina.*/
			
			int empleadosRango1 = 0;
	        int empleadosRango2 = 0;
	        double salario;
	        double nomina = 0;
	        int empleados;             
	
	        Console.Write("Ingrese el número de empleados: ");
	        empleados = int.Parse(Console.ReadLine());
	
	        int i = 0;

	        while (i < empleados)
	        {
	            Console.WriteLine("Ingrese el salario del empleado #" + (i + 1) + ": ");
	            salario = double.Parse(Console.ReadLine());
	
	            if (salario >= 100 && salario <= 500)
	            {
	                if (salario <= 300)
	                {
	                    empleadosRango1++;
	                }
	                else
	                {
	                    empleadosRango2++;
	                }
	
	                nomina += salario;
	                i++;
	            }
	            else
	            {
	                Console.WriteLine("El salario debe estar entre $100 y $500.");
	            }
	        }

	        Console.WriteLine("\nResultados:");
	        Console.WriteLine("Empleados con salario entre $100 y $300: " + empleadosRango1);
	        Console.WriteLine("Empleados con salario mayor a $300: " + empleadosRango2);
	        Console.WriteLine("Gasto total en nómina: $" + nomina);
			
			Console.ReadKey(true);
		}
	}
}