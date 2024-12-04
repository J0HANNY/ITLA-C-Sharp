// Fig. 8.19: Cuenta.cs
public class Cuenta
{
    private int numeroCuenta;
    private int pin;
    private double saldoDisponible;
    private double saldoTotal;

    public Cuenta(int cuenta, int pin, double saldoDisponible, double saldoTotal)
    {
        numeroCuenta = cuenta;
        this.pin = pin;
        this.saldoDisponible = saldoDisponible;
        this.saldoTotal = saldoTotal;
    }

    public bool ValidarPIN(int pinUsuario)
    {
        return pin == pinUsuario;
    }
}

