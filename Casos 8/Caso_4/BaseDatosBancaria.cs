// Fig. 8.18: BaseDatosBancaria.cs
using System.Collections.Generic;

public class BaseDatosBancaria
{
    private Dictionary<int, Cuenta> cuentas; 

    public BaseDatosBancaria()
    {
        cuentas = new Dictionary<int, Cuenta>
        {
            { 12345, new Cuenta(12345, 54321, 1000.0, 1200.0) },
            { 98765, new Cuenta(98765, 56789, 200.0, 200.0) }
        };
    }

    public bool AutenticarUsuario(int numeroCuenta, int pin)
    {
        return cuentas.ContainsKey(numeroCuenta) && cuentas[numeroCuenta].ValidarPIN(pin);
    }
}
