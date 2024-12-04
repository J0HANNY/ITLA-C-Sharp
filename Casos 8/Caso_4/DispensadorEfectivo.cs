// Fig. 8.17: DispensadorEfectivo.cs
public class DispensadorEfectivo
{
    private const int EFECTIVO_INICIAL = 500; 
    private int efectivoDisponible;

    public DispensadorEfectivo()
    {
        efectivoDisponible = EFECTIVO_INICIAL;
    }

    public void EntregarEfectivo(int monto)
    {
        if (efectivoDisponible >= monto)
        {
            efectivoDisponible -= monto;
        }
        
    }

    public bool HaySuficienteEfectivo(int monto)
    {
        return efectivoDisponible >= monto;
    }
}
