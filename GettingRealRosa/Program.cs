using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryRosa;
using System.Globalization;

namespace GettingRealRosa
{
    class Program
    {
        List<Garn> GarnListe;
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }
        public void Run()
        {
            if (GarnListe == null)
            {
                GarnListe = new List<Garn>();
            }
            Console.WriteLine("Menu");
            Console.WriteLine("O: Opret garn ");
            Console.WriteLine("L: Se Liste");
            Console.WriteLine("E: Luk programmet");
            switch (Console.ReadLine().ToUpper())
            {
                case "O":
                    Console.Clear();

                    Garn OpretGarn = new Garn();
                    Console.WriteLine("Opret Garn");
                    Console.WriteLine("Indtast navnet på garnet");
                    OpretGarn.Name = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Opret Garn");
                    Console.WriteLine("Indtast typen på garnet");
                    OpretGarn.Type = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Opret Garn");
                    Console.WriteLine("Indtast farven på garnet");
                    OpretGarn.Color = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Opret Garn");
                    Console.WriteLine("Indtast prisen på garnet (komma tal, husk og bruge . til ved øre)");
                    OpretGarn.Price = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                    Console.Clear();

                    Console.WriteLine("Opret Garn");
                    Console.WriteLine("Indtast mængden af garnet (Tal)");
                    OpretGarn.Amount = Int32.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Opret Garn");
                    Console.WriteLine("Du har indtastet");
                    Console.WriteLine("Navn: " + OpretGarn.Name + " | Type: " + OpretGarn.Type + " | Farve: " + OpretGarn.Color + " | Pris: " + OpretGarn.Price + " | Mængde: " + OpretGarn.Amount);
                    Console.WriteLine("Tryk for at gå vidre");
                    Console.ReadKey();
                    
                    GarnListe.Add(OpretGarn);
                    Console.Clear();
                    break;
                case "L":
                    Console.Clear();
                    Console.WriteLine("Garn liste");
                    if (GarnListe != null)
                    {
                        foreach (Garn garn in GarnListe)
                        {
                            Console.WriteLine("Navn: " + garn.Name + " | Type: " + garn.Type + " | Farve: " + garn.Color + " | Pris: " + garn.Price + " | Mængde: " + garn.Amount);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Der er ikke oprettet noget garn.");
                    }
                    
                    Console.WriteLine("Tryk for at gå vidre");
                    Console.ReadLine();
                    break;
                case "E":
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Muligheden findes ikke");
                    Console.WriteLine("Tryk for at gå vidre");
                    Console.ReadLine();
                    break;
            }
            Run();
        }
    }
}
