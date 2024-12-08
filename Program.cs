namespace Schirmer_Adrien_Banca_online;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var banquer = new Banquer();
        bool running = true;
        while (running)
        {
            Console.WriteLine("1: Afegir client | 2: Modificar salari d'un client | 3: Veure llista de clients | 4: Sortir");
            Console.Write("Tria una opció: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Has entrat l'opció {choice}");
                    banquer.CrearClient();
                    break;
                case 2:
                    Console.WriteLine($"Has entrat l'opció {choice}");
                    string nomclient = banquer.SeleccionarClient();
                    if (nomclient != "false")
                    {
                        bool modificarusuari = true;
                        while (modificarusuari)
                        {
                            Console.WriteLine("1: Afegir Saldo | 2: Restar Saldo | 3: Sortir");
                    
                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    banquer.AfegirDiners();
                                    break;
                                case 2:
                                    banquer.TreureDiners();
                                    break;
                                case 3:
                                    modificarusuari = false;
                                    break;
                            }   
                        }
                    }
                    else if (nomclient == "false")
                    {
                        Console.WriteLine("No s'ha trobat el client!");
                    }
                    break;
                case 3:
                    Console.WriteLine($"Has entrat l'opció {choice}");
                    banquer.VeureClients();
                    break;
                case 4:
                    running = false;
                    break;
            }
        }
    }
}