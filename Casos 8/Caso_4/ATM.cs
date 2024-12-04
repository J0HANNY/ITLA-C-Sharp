// Fig. 8.14: ATM.cs
using System;

public class ATM
{
    private bool usuarioAutenticado; 
    private int numeroCuentaActual; 
    private Pantalla pantalla;
    private Teclado teclado; 
    private DispensadorEfectivo dispensador; 
    private BaseDatosBancaria baseDatos; 

    public ATM()
    {
        usuarioAutenticado = false; 
        numeroCuentaActual = 0; 
        pantalla = new Pantalla(); 
        teclado = new Teclado(); 
        dispensador = new DispensadorEfectivo(); 
        baseDatos = new BaseDatosBancaria(); 
    }

    // Inicia el ATM
    public void Ejecutar()
    {
        while (true)
        {
            while (!usuarioAutenticado)
            {
                pantalla.MostrarMensaje("Bienvenido al ATM.");
                AutenticarUsuario();
            }

        }
    }

    private void AutenticarUsuario()
    {
        pantalla.MostrarMensaje("\nPor favor ingrese su número de cuenta: ");
        int numeroCuenta = teclado.ObtenerEntrada();
        pantalla.MostrarMensaje("\nIngrese su PIN: ");
        int pin = teclado.ObtenerEntrada();

        usuarioAutenticado = baseDatos.AutenticarUsuario(numeroCuenta, pin);

        if (usuarioAutenticado)
        {
            numeroCuentaActual = numeroCuenta;
        }
        else
        {
            pantalla.MostrarMensaje("Número de cuenta o PIN incorrectos. Inténtelo de nuevo.\n");
        }
    }
}
