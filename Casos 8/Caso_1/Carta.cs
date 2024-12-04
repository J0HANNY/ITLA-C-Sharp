// Fig. 8.9: Carta.cs
public class Carta
{
    private string cara; 
    private string palo; 

    public Carta(string caraCarta, string paloCarta)
    {
        cara = caraCarta; 
        palo = paloCarta; 
    }

    public override string ToString()
    {
        return cara + " de " + palo;
    }
}
