namespace Schirmer_Adrien_Banca_online;

public class Client
{
    public string Nom { get; }
    public int Saldo { get; set; }

    public Client(string nom, int saldo)
    {
        Nom = nom;
        Saldo = saldo;
    }
}