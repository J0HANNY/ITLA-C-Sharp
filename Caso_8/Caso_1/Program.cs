/*
 * Creado por SharpDevelop.
 * Usuario: Johanny
 * Fecha: 1/12/2024
 * Hora: 19:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Caso_1
{
	class Program
	{
		public static void Main(string[] args)
		{

	        string[] palos = { "Corazones", "Diamantes", "Tréboles", "Picas" };
	        string[] valores = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
	        string[] baraja = new string[52];
	
	        int index = 0;
	        foreach (var palo in palos)
	        {
	            foreach (var valor in valores)
	            {
	                baraja[index++] = valor +" de "+ palo;
	            }
	        }
	
	        // Barajar
	        Random aleatorio = new Random();
	        for (int i = 0; i < baraja.Length; i++)
	        {
	            int j = aleatorio.Next(baraja.Length);
	            string temp = baraja[i];
	            baraja[i] = baraja[j];
	            baraja[j] = temp;
	        }
	
	        // Repartir
	        Console.WriteLine("Cartas barajadas:");
	        foreach (var carta in baraja)
	        {
	            Console.WriteLine(carta);
	        }
	        
	        Console.ReadKey(true);

		}
	}
}