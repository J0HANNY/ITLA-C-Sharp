/*
 * Creado por SharpDevelop.
 * Usuario: Johanny
 * Fecha: 1/12/2024
 * Hora: 19:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Caso_3
{
	class Program
	{
	    static void Main()
	    {
	        int[,] calificaciones = 
	        {
	            { 85, 90, 78 },
	            { 92, 88, 95 },
	            { 76, 84, 80 }
	        };
	
	        for (int i = 0; i < calificaciones.GetLength(0); i++)
	        {
	            int suma = 0;
	            Console.Write("Estudiante " + (i + 1) + ": ");
	            for (int j = 0; j < calificaciones.GetLength(1); j++)
	            {
	                Console.Write(calificaciones[i, j]);
					Console.Write(" ");
	                suma += calificaciones[i, j];
	            }
	            double promedio = (double)suma / calificaciones.GetLength(1);
	            Console.WriteLine("Promedio: " + promedio);
	            
	            Console.ReadKey(true);
	        }
		}
	}
}