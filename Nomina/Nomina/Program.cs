using System;
using System.Collections.Generic;

// Clase abstracta base
public abstract class Empleado
{
    public string PrimerNombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string NumeroSeguroSocial { get; set; }

    public Empleado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial)
    {
        PrimerNombre = primerNombre;
        ApellidoPaterno = apellidoPaterno;
        NumeroSeguroSocial = numeroSeguroSocial;
    }

    // Método abstracto que calculará los ingresos del empleado
    public abstract decimal Ingresos();

    // Método ToString común a todas las subclases
    public override string ToString()
    {
		return PrimerNombre + " " + ApellidoPaterno + "\nNúmero de seguro social: " + NumeroSeguroSocial;    
    }
}

// Clase EmpleadoAsalariado
public class EmpleadoAsalariado : Empleado
{
    public decimal SalarioSemanal { get; set; }

    public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salarioSemanal)
        : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
    {
        SalarioSemanal = salarioSemanal;
    }

    public override decimal Ingresos()
    {
        return SalarioSemanal;
    }

    public override string ToString()
    {
		return "Empleado asalariado: " + base.ToString() + "\nSalario semanal: " + SalarioSemanal.ToString("C");
    }
}

// Clase EmpleadoPorHoras
public class EmpleadoPorHoras : Empleado
{
    public decimal SueldoPorHora { get; set; }
    public decimal HorasTrabajadas { get; set; }

    public EmpleadoPorHoras(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal sueldoPorHora, decimal horasTrabajadas)
        : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
    {
        SueldoPorHora = sueldoPorHora;
        HorasTrabajadas = horasTrabajadas;
    }

    public override decimal Ingresos()
    {
        if (HorasTrabajadas <= 40)
        {
            return SueldoPorHora * HorasTrabajadas;
        }
        else
        {
            return (40 * SueldoPorHora) + ((HorasTrabajadas - 40) * SueldoPorHora * 1.5M);
        }
    }

    public override string ToString()
    {
		return "Empleado por horas: " + base.ToString() + 
       "\nSueldo por hora: " + SueldoPorHora.ToString("C") + 
       "\nHoras trabajadas: " + HorasTrabajadas;
    }
}

// Clase EmpleadoPorComision
public class EmpleadoPorComision : Empleado
{
    public decimal VentasBrutas { get; set; }
    public decimal TarifaComision { get; set; }

    public EmpleadoPorComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision)
        : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
    {
        VentasBrutas = ventasBrutas;
        TarifaComision = tarifaComision;
    }

    public override decimal Ingresos()
    {
        return VentasBrutas * TarifaComision;
    }

    public override string ToString()
    {
		return "Empleado por comisión: " + base.ToString() + 
       "\nVentas brutas: " + VentasBrutas.ToString("C") + 
       "\nTarifa de comisión: " + TarifaComision.ToString("P");
    }
}

// Clase EmpleadoBaseMasComision
public class EmpleadoBaseMasComision : EmpleadoPorComision
{
    public decimal SalarioBase { get; set; }

    public EmpleadoBaseMasComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision, decimal salarioBase)
        : base(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision)
    {
        SalarioBase = salarioBase;
    }

    public override decimal Ingresos()
    {
        return SalarioBase + base.Ingresos();
    }

    public override string ToString()
    {
		return "Empleado por comisión con salario base: " + base.ToString() + 
       "\nSalario base: " + SalarioBase.ToString("C");
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        // Crear una lista de empleados
        List<Empleado> empleados = new List<Empleado>
        {
            new EmpleadoAsalariado("Juan", "Pérez", "123-45-6789", 800.00M),
            new EmpleadoPorHoras("Ana", "Gómez", "987-65-4321", 16.75M, 50),
            new EmpleadoPorComision("Luis", "Martínez", "111-22-3333", 10000.00M, 0.06M),
            new EmpleadoBaseMasComision("Sara", "López", "222-33-4444", 5000.00M, 0.04M, 300.00M)
        };

        // Procesar empleados polimórficamente
        foreach (Empleado empleado in empleados)
        {
            Console.WriteLine(empleado);
Console.WriteLine("Ingresos: $" + empleado.Ingresos().ToString("0.00") + "\n");
        }
        
        Console.ReadKey(true);
    }
}
