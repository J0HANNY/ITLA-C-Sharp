using System;

namespace Arrays_2
{
	class Program
	{
		public static void Main(string[] args)
		{

	        Console.WriteLine("Ingrese los elementos del primer arreglo separados por espacio:");
	        int[] arreglo1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
	
	        Console.WriteLine("Ingrese los elementos del segundo arreglo separados por espacio:");
	        int[] arreglo2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
	
	        bool sonIguales = arreglo1.Length == arreglo2.Length;
	
	        if (sonIguales)
	        {
	            for (int i = 0; i < arreglo1.Length; i++)
	            {
	                if (arreglo1[i] != arreglo2[i])
	                {
	                    sonIguales = false;
	                    break;
	                }
	            }
	        }
	
	        Console.WriteLine(sonIguales ? "Los arreglos son iguales." : "Los arreglos no son iguales.");
			
			Console.ReadKey(true);
		}
	}
}