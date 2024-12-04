using System.IO.Pipes;

namespace Schirmer_Adrien_Banca_online;
public class Banquer
{
    List<Client> clients = new List<Client>()
    {
        new Client("Pere", 2000),
        new Client("Pepa", 20000)
    };

    public void VeureClients()
    {
        foreach (var client in clients)
        {
            Console.WriteLine(client.Nom);
        }
    }
    public string SeleccionarClient()
    {
        Console.Write("Nom del client: ");
        string nom = Console.ReadLine();
        foreach (var client in clients)
        {
            if (client.Nom == nom)
            {
                Console.WriteLine($"Usuari seleccionat: {client.Nom} | Saldo: {client.Saldo}");
                Console.WriteLine("1: Afegir Saldo | 2: Restar Saldo | 3: Sortir");
                    
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AfegirDiners();
                        break;
                    case 2:
                        TreureDiners();
                        break;
                    case 3:
                        break;
                }
            }
        }

        return nom;
    }

    public void AfegirDiners()
    {
        Console.Write("Introdueix la quantitat de diners que vols afegir: ");
        int quantitat = int.Parse(Console.ReadLine());
        foreach (var client in clients)
        {
            if (client.Nom == SeleccionarClient())
            {
                client.Saldo += quantitat;
            }
        }
    }

    public void TreureDiners()
    {
        Console.Write("Introdueix la quantitat de diners que vols treure: ");
        int quantitat = int.Parse(Console.ReadLine());
        int comissio = quantitat / 100;
        foreach (var client in clients)
        {
            if (client.Nom == SeleccionarClient())
            {
                if (quantitat+comissio > client.Saldo)
                {
                    Console.WriteLine("No hi han suficients diners al banc!");
                }
                else
                {
                    client.Saldo -= comissio+quantitat;
                }
            }
        }
    }
}