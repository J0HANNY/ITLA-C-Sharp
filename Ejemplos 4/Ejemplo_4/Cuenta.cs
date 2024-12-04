// Fig. 4.15: Cuenta.cs
using System;

public class Cuenta
{
    private decimal saldo;

    public Cuenta(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Acredita(decimal monto)
    {
        Saldo = Saldo + monto; 
        
        Console.ReadKey(true);
    } 

    public decimal Saldo
    {
        get
        {
            return saldo;
        }
        set
        {
            if (value >= 0)
                saldo = value;
        } 
    }
    
} 
