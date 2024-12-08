using System;
using System.Collections.Generic;

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

    public abstract decimal Ingresos();

    public override string ToString()
    {
        return PrimerNombre + " " + ApellidoPaterno + "\nNúmero de seguro social: " + NumeroSeguroSocial;
    }
}

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
		return "Empleado asalariado: " + base.ToString() + "\nSalario semanal: $" + SalarioSemanal.ToString("0.00");
    }
}

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
		return "Empleado por horas: " + base.ToString() + "\nSueldo por hora: $" + SueldoPorHora.ToString("0.00") + "\nHoras trabajadas: " + HorasTrabajadas;
    }
}

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
		return "Empleado por comisión: " + base.ToString() + "\nVentas brutas: $" + VentasBrutas.ToString("0.00") + "\nTarifa de comisión: " + TarifaComision.ToString("P");
    }
}

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
		sreturn "Empleado por comisión con salario base: " + base.ToString() + "\nSalario base: $" + SalarioBase.ToString("0.00");
    }
}

class Program
{
    static void Main()
    {
        List<Empleado> empleados = new List<Empleado>();

        Console.WriteLine("Ingrese los datos de los empleados:");

        for (int i = 0; i < 4; i++)
        {
        	Console.WriteLine("\nEmpleado #" + (i + 1) + ":");

            Console.Write("Tipo de empleado (1. asalariado, 2. por horas, 3. por comision, 4. base + comision): ");
            string tipoEmpleado = Console.ReadLine().ToLower();

            Console.Write("Primer nombre: ");
            string primerNombre = Console.ReadLine();

            Console.Write("Apellido paterno: ");
            string apellidoPaterno = Console.ReadLine();

            Console.Write("Número de seguro social: ");
            string numeroSeguroSocial = Console.ReadLine();

            if (tipoEmpleado == "1")
            {
                Console.Write("Salario semanal: ");
                decimal salarioSemanal = Convert.ToDecimal(Console.ReadLine());
                empleados.Add(new EmpleadoAsalariado(primerNombre, apellidoPaterno, numeroSeguroSocial, salarioSemanal));
            }
            else if (tipoEmpleado == "2")
            {
                Console.Write("Sueldo por hora: ");
                decimal sueldoPorHora = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Horas trabajadas: ");
                decimal horasTrabajadas = Convert.ToDecimal(Console.ReadLine());

                empleados.Add(new EmpleadoPorHoras(primerNombre, apellidoPaterno, numeroSeguroSocial, sueldoPorHora, horasTrabajadas));
            }
            else if (tipoEmpleado == "3")
            {
                Console.Write("Ventas brutas: ");
                decimal ventasBrutas = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Tarifa de comisión: ");
                decimal tarifaComision = Convert.ToDecimal(Console.ReadLine());

                empleados.Add(new EmpleadoPorComision(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision));
            }
            else if (tipoEmpleado == "4")
            {
                Console.Write("Ventas brutas: ");
                decimal ventasBrutas = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Tarifa de comisión: ");
                decimal tarifaComision = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Salario base: ");
                decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

                empleados.Add(new EmpleadoBaseMasComision(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision, salarioBase));
            }
            else
            {
                Console.WriteLine("Tipo de empleado no válido.");
            }
        }

        foreach (Empleado empleado in empleados)
        {
            Console.WriteLine(empleado);
			Console.WriteLine("Ingresos: $" + empleado.Ingresos().ToString("0.00") + "\n");
        }
        
        Console.ReadKey(true);
    }
}
