using System;

namespace Arrays_1
{
	class Program
	{
		public static void Main(string[] args)
		{

	        int[] arreglo = new int[20];
	
	        for (int i = 0; i < arreglo.Length; i++)
	        {
	            arreglo[i] = i * 5;
	        }
	
	        Console.WriteLine("Elementos del arreglo:");
	        foreach (int elemento in arreglo)
	        {
	            Console.WriteLine(elemento);
	        }
			
			Console.ReadKey(true);
		}
	}
}