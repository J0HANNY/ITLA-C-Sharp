using System;

class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Paginas { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Páginas: " + Paginas);
    }

    public bool EsLargo()
    {
        return Paginas > 500;
    }

    static void Main(string[] args)
    {
        Libro libro = new Libro();

        Console.WriteLine("Ingrese el título del libro:");
        libro.Titulo = Console.ReadLine();

        Console.WriteLine("Ingrese el autor del libro:");
        libro.Autor = Console.ReadLine();

        Console.WriteLine("Ingrese la cantidad de páginas del libro:");
        libro.Paginas = int.Parse(Console.ReadLine());

        libro.MostrarInformacion();

        if (libro.EsLargo())
        {
            Console.WriteLine("El libro es largo.");
        }
        else
        {
            Console.WriteLine("El libro no es largo.");
        }
        
        Console.ReadKey(true);
        
    }
}
