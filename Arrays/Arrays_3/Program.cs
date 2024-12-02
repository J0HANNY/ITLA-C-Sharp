using System;

namespace Arrays_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
	        Console.WriteLine("Ingrese los números separados por espacio:");
	        int[] numeros = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
	
	        int menor = numeros[0];
	        for (int i = 1; i < numeros.Length; i++)
	        {
	            if (numeros[i] < menor)
	            {
	                menor = numeros[i];
	            }
	        }
	
	        bool tieneRepetidos = false;
	        for (int i = 0; i < numeros.Length; i++)
	        {
	            for (int j = i + 1; j < numeros.Length; j++)
	            {
	                if (numeros[i] == numeros[j])
	                {
	                    tieneRepetidos = true;
	                    break;
	                }
	            }
	            if (tieneRepetidos)
	            {
	                break;
	            }
	        }
	
	        Console.WriteLine("El menor valor es: " + menor);
	        Console.WriteLine(tieneRepetidos ? "Hay al menos un número repetido." : "No hay números repetidos.");
	
				
			Console.ReadKey(true);
		}
	}
}