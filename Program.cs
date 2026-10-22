using System;

namespace RyggsäckenÖvning
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //visar meny
            //spara strängvärde
            //skriva ut strängvärde
            //rensa innehållet
            bool minBool = true;
            string ryggsäcken = "";
            
            //formel för att ändra färgen på titeln
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Visar texten
            Console.WriteLine("\nVälkommen till Ryggsäcksprogrammet!");
            //Formel för att återgå till standardfärgen
            Console.ResetColor();
            
            //loop
            while (minBool)
            {
                //Visa menyn
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nVälj ett alternativ från menyn:\n");
                Console.ResetColor();
                Console.WriteLine("\t[1] Lägg till föremål");
                Console.WriteLine("\t[2] Skriv ut innehållet");
                Console.WriteLine("\t[3] Rensa innehållet");
                Console.WriteLine("\t[4] Avsluta programmet");

                //Vad som användaren skriver är som standar en text som måste konverteras till ett tal.
                Int32.TryParse(Console.ReadLine(),out int alternativ);
                //int alternativ = Convert.ToInt16(Console.ReadLine());
                switch (alternativ)
                    {
                        case 1:
                            Console.WriteLine("Vilket objekt vill du lägga till?: ");
                            //Jag skapar en variabel för att spara det användaren skriver
                            string föremål = Console.ReadLine();
                        
                            //Variabeln som jag deklarerade på rad 14 i koden får ett värde
                            //värdet är innehållet + vad användaren adderar.
                            ryggsäcken = ryggsäcken + föremål + " ";
                            //rensa skärmen för enklare läsning
                            Console.Clear();
                            break;

                        case 2:
                            //skriv ut text + den sparade strängvariabeln med annan färg
                            Console.WriteLine("I ryggsäcken finns: ");
                            Console.ForegroundColor = ConsoleColor.Yellow;    
                            Console.WriteLine(ryggsäcken);

                            //om variabeln är tom, skriv ut "ingenting"
                            if (ryggsäcken == "")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("ingenting");
                            }
                            Console.ResetColor(); 
                            break;

                        case 3:
                            //Rensa innehåll 
                            ryggsäcken = "";
                            Console.Clear();
                            break;

                        case 4:
                            //stoppa loopen
                            minBool = false;
                            Console.Clear();
                            break;

                        default:
                            //I fall användaren skriver ett annat nummer.
                            Console.WriteLine("Du måste välja mellan 1-4");
                            break;
                } 
            }
        }
    }
}
       

