using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryRosa;
using System.Globalization;

namespace GettingRealRosa
{
    class Menu
    {
        ProductReposetory GarnListe;
        public void MainMenu()
        {
            if (GarnListe == null)
            {
                GarnListe = new ProductReposetory();
            }
            DataSetHandler h = new DataSetHandler();
            h.SaveToXmlFile(GarnListe.ProductList);
            Console.WriteLine("Menu");
            Console.WriteLine("O: Opret vare");
            Console.WriteLine("R: Rediger vare");
            Console.WriteLine("S: Slet vare");
            Console.WriteLine("L: Se Liste af vare");
            Console.WriteLine("E: Luk programmet");
            switch (Console.ReadLine().ToUpper())
            {
                case "O":
                    CreateProduct();
                    break;
                case "U":
                    UpdateProduct();
                    break;
                case "S":
                    DeleteProduct();
                    break;
                case "L":
                    ShowList();
                    break;
                case "E":
                    Exit();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Muligheden findes ikke");
                    Console.WriteLine("Tryk for at gå vidre");
                    Console.ReadLine();
                    break;
            }
            MainMenu();
        }

        public void CreateProduct()
        {
            Console.Clear();

            Garn OpretGarn = new Garn();
            Console.WriteLine("Opret vare");
            Console.WriteLine("Indtast typen på varen");
            OpretGarn.Type = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Opret vare");
            Console.WriteLine("Indtast navnet på varen");
            OpretGarn.Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Opret vare");
            Console.WriteLine("Indtast farven på varen");
            OpretGarn.Color = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Opret vare");
            Console.WriteLine("Indtast prisen på varen");
            Console.WriteLine("(KOMMA TAL, HUSK AT BRUGE . OG IKKE ,)");
            OpretGarn.Price = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Opret vare");
            Console.WriteLine("Indtast mængden af varen (Tal)");
            OpretGarn.Amount = Int32.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Opret vare");
            Console.WriteLine("Du har indtastet");
            Console.WriteLine("Type: " + OpretGarn.Type + " | Navn: " + OpretGarn.Name + " | Farve: " + OpretGarn.Color + " | Mængde: " + OpretGarn.Amount + " | Pris: " + OpretGarn.Price);
            GarnListe.AddProduct(OpretGarn);
            Console.WriteLine("Vil du oprette flere varer? Y/N");
            Console.ReadKey();

            bool e = true;
            while (e == true)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "Y":
                        e = false;
                        Console.Clear();
                        CreateProduct();
                        break;
                    case "N":
                        e = false;
                        Console.Clear();
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("ikke gyldigt indput");
                        break;

                }
            }
            
            Console.Clear();
        }

        public void ShowList()
        {
            Console.Clear();
            if (GarnListe.ProductList.Count != 0)
            {
                Console.WriteLine("Her er din vare liste");
                foreach (Garn garn in GarnListe.ProductList)
                {
                    Console.WriteLine("Navn: " + garn.Name + " | Type: " + garn.Type + " | Farve: " + garn.Color + " | Pris: " + garn.Price + " | Mængde: " + garn.Amount);
                }
            }
            else
            {
                Console.WriteLine("Der er ikke oprettet nogen vare.");
            }

            Console.WriteLine("Tryk for at gå vidre");
            Console.ReadLine();
        }

        private void DeleteProduct()
        {
            int i = 1;
            string e = "";
            Console.Clear();
            
            if (GarnListe.ProductList.Count != 0)
            {
                Console.WriteLine("Her er din vare liste");
                foreach (Garn garn in GarnListe.ProductList)
                {
                    Console.WriteLine(i + ": Type: " + garn.Type + " | Navn: " + garn.Name + " | Farve: " + garn.Color + " | Mængde: " + garn.Amount + " | Pris: " + garn.Price);
                    i++;
                }
                Console.WriteLine();
                Console.WriteLine("Indtast nummer på vare du gerne vil slette");
                Console.WriteLine("eller indtast T for 'tilbage' og kom tilbage til hovede menuen.");
                switch (e = Console.ReadLine().ToUpper())
                {
                    case "T":
                        Console.Clear();
                        MainMenu();
                        break;
                    default:
                        int t;
                        bool isAInt = int.TryParse(e, out t);
                        if (isAInt == true)
                        {
                            if (GarnListe.ProductList.Count() >= t && t > 0)
                            {
                                t -= 1;
                                List<object> garn = GarnListe.ProductList[t].GetProductInfo();
                                Console.WriteLine("Vil du slette Type:" + garn[0] + " Navn:" + garn[1] + " Farve:" + garn[2] + " Mængde:" + garn[3] + " Pris:" + garn[4]);
                                Console.WriteLine("Tryk J for Ja ellers tryk på en anden knap for at gå tilbage.");
                                if (Console.ReadLine().ToUpper() == "J")
                                {
                                    GarnListe.DeleteProduct(t);
                                    Console.WriteLine("varen er blev slettet");
                                }
                                else
                                {
                                    Console.WriteLine("varen er blev ikke slettet");
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ugyldigt indput.");
                                Console.WriteLine("tryk på en knap for at prøve igen.");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ugyldigt indput.");
                            Console.WriteLine("tryk på en knap for at prøve igen.");
                        }
                        Console.ReadKey();
                        break;
                }
                DeleteProduct();

            }
            else
            {
                Console.WriteLine("Der er ikke oprettet noget garn.");
                Console.WriteLine("tryk på en knap for at gå til hovede menuen igen");
                Console.ReadKey();
                Console.Clear();
            }
            
            
        }

        private void UpdateProduct()
        {
            int i = 1;
            string e = "";
            Console.Clear();

            if (GarnListe.ProductList.Count != 0)
            {
                Console.WriteLine("Her er din vare liste");
                foreach (Garn garn in GarnListe.ProductList)
                {
                    Console.WriteLine(i + ": Navn: " + garn.Name + " | Type: " + garn.Type + " | Farve: " + garn.Color + " | Pris: " + garn.Price + " | Mængde: " + garn.Amount);
                    i++;
                }
                Console.WriteLine();
                Console.WriteLine("Indtast nummer på vare du gerne vil Redigere");
                Console.WriteLine("eller indtast T for 'tilbage' og kom tilbage til hovede menuen.");
                switch (e = Console.ReadLine().ToUpper())
                {
                    case "T":
                        Console.Clear();
                        MainMenu();
                        break;
                    default:
                        int t;
                        bool isAInt = int.TryParse(e, out t);
                        if (isAInt == true)
                        {
                            if (GarnListe.ProductList.Count() >= t && t > 0)
                            {
                                t -= 1;
                                List<object> garn = GarnListe.ProductList[t].GetProductInfo();
                                Console.WriteLine("hvis du ikke vil redigere den propoty tryk enter \n");
                                Console.Write("Type:" + garn[0] + ". Angiv nyt type: ");
                                string Name = Console.ReadLine();
                                if (Name == "") Name = "" + garn[1];
                                Console.Write("Navn:" + garn[1] + ". Angiv ny navn: ");
                                string type = Console.ReadLine();
                                if (type == "") type = "" + garn[0];
                                Console.Write("Farve:" + garn[2] + ". Angiv ny farve: ");
                                string Color = Console.ReadLine();
                                if (Color == "") Color = "" + garn[2];
                                Console.Write("Mængde:" + garn[3] + ". Angiv nyt Antal: ");
                                string antal = Console.ReadLine();
                                int NyAntal;
                                if (antal == "")
                                {
                                    antal = "" + garn[3];
                                    NyAntal = int.Parse(antal);
                                }
                                else
                                {
                                    NyAntal = int.Parse(antal);
                                }
                                Console.Write("Pris:" + garn[4] + ". Angiv ny pris(husk . ikke ,): ");
                                string pris = Console.ReadLine();
                                double NyPris;
                                if (pris == "")
                                {
                                    pris = "" + garn[4];
                                    NyPris = double.Parse(pris);
                                }
                                else
                                {
                                    NyPris = double.Parse(pris);
                                }
                                GarnListe.ProductList[t].UpdateProduct(type,Name,Color,NyAntal,NyPris);
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ugyldigt indput.");
                                Console.WriteLine("tryk på en knap for at prøve igen.");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ugyldigt indput.");
                            Console.WriteLine("tryk på en knap for at prøve igen.");
                        }
                        Console.ReadKey();
                        break;
                }
                UpdateProduct();

            }
            else
            {
                Console.WriteLine("Der er ikke oprettet nogen vare.");
                Console.WriteLine("tryk på en knap for at gå til hovede menuen igen");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
        public void Exit()
        {
            Console.WriteLine("Vil du Afslutte programmet?");
            Console.Write("J:Ja / N:Nej   :");
            switch (Console.ReadLine().ToUpper())
            {
                case "J":
                    Environment.Exit(1);
                    break;
                case "N":
                    break;
                default:
                    Console.WriteLine("Ugyldigt Input prøv igen");
                    Exit();
                    break;
            }
        }
    }
}
