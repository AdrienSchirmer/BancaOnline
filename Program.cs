namespace Schirmer_Adrien_Banca_online;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var banquer = new Banquer();
        Console.WriteLine("1: Afegir client | 2: Modificar salari d'un client | 3: Veure llista de clients");
        Console.Write("Tria una opció: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine($"Has entrat l'opció {choice}");
                break;
            case 2:
                Console.WriteLine($"Has entrat l'opció {choice}");
                banquer.SeleccionarClient();
                break;
            case 3:
                Console.WriteLine($"Has entrat l'opció {choice}");
                banquer.VeureClients();
                break;
        }
    }
}