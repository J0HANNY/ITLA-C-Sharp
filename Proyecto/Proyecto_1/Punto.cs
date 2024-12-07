using System;

class Punto
{
    private double x;
    private double y;

    public void CargarValores(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public string ObtenerCuadrante()
    {
        if (x > 0 && y > 0)
        {
            return "Primer cuadrante";
        }
        else if (x < 0 && y > 0)
        {
            return "Segundo cuadrante";
        }
        else if (x < 0 && y < 0)
        {
            return "Tercer cuadrante";
        }
        else if (x > 0 && y < 0)
        {
            return "Cuarto cuadrante";
        }
        else if (x == 0 && y == 0)
        {
            return "El punto está en el origen";
        }
        else if (x == 0)
        {
            return "El punto está sobre el eje Y";
        }
        else // y == 0
        {
            return "El punto está sobre el eje X";
        }
    }

    public void ImprimirCuadrante()
    {
        Console.WriteLine(ObtenerCuadrante());
    }

    static void Main(string[] args)
    {
        Punto punto = new Punto();

        Console.WriteLine("Ingrese el valor de x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de y:");
        double y = double.Parse(Console.ReadLine());

        punto.CargarValores(x, y);
        punto.ImprimirCuadrante();
        
        Console.ReadKey(true);
    }
}
