namespace Schirmer_Adrien_Banca_online;
public class Banquer
{
    private string nomclient;
    
    private List<Client> clients = new List<Client>
    {
        new Client("Pere", 2000),
        new Client("Pepa", 20000)
    };

    public void CrearClient()
    {
        Console.Write("Introdueix el nom del nou client: ");
        var nomclient = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Salari (0,2,10..: ");
        int salari = Convert.ToInt32(Console.ReadLine());
        clients.Add(new Client(nomclient, salari));
    }

    public void VeureClients()
    {
        foreach (var client in clients)
        {
            Console.WriteLine(client.Nom);
        }
    }
    public string SeleccionarClient()
    {
        var i = 0;
        Console.Write("Nom del client: ");
        string nom = Console.ReadLine();
        foreach (var client in clients)
        {
            if (client.Nom == nom)
            {
                Console.WriteLine($"Usuari seleccionat: {client.Nom} | Saldo: {client.Saldo}");
                nomclient = nom;
                i--;
            }
            else
            {
                i++;
            }
            
            if (i == clients.Count)
            {
                nom = "false";
                Console.WriteLine(i);
                Console.WriteLine("false");
            }
        }
        return nom;
    }

    public void AfegirDiners()
    {
        Console.Write("Introdueix la quantitat de diners que vols afegir: ");
        Console.WriteLine(nomclient);
        int quantitat = int.Parse(Console.ReadLine());
        foreach (var client in clients)
        {
            if (client.Nom == nomclient)
            {
                client.Saldo += quantitat;
                Console.WriteLine($"Saldo agregat, saldo actual: {client.Saldo}");
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
            if (client.Nom == nomclient)
            {
                if (quantitat+comissio > client.Saldo)
                {
                    Console.WriteLine("No hi han suficients diners al banc!");
                }
                else
                {
                    client.Saldo -= comissio+quantitat;
                    Console.WriteLine($"Saldo restat, saldo actual: {client.Saldo}");
                }
            }
        }
    }
}