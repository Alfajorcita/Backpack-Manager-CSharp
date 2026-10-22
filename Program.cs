using System;

namespace RyggsäckenÖvning
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            bool minBool = true;
            string ryggsäcken = "";
            
            
            Console.ForegroundColor = ConsoleColor.Yellow;
          
            Console.WriteLine("\nVälkommen till Ryggsäcksprogrammet!");    
            Console.ResetColor();
            
           
            while (minBool)
            {
               
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nVälj ett alternativ från menyn:\n");
                Console.ResetColor();
                Console.WriteLine("\t[1] Lägg till föremål");
                Console.WriteLine("\t[2] Skriv ut innehållet");
                Console.WriteLine("\t[3] Rensa innehållet");
                Console.WriteLine("\t[4] Avsluta programmet");

                //Vad som användaren skriver är som standar en text som måste konverteras till ett tal.
                Int32.TryParse(Console.ReadLine(),out int alternativ);
              
                switch (alternativ)
                    {
                        case 1:
                        Console.WriteLine("Vilket objekt vill du lägga till?: ");
                            string föremål = Console.ReadLine();
                        
                            ryggsäcken = ryggsäcken + föremål + " ";
                          
                            Console.Clear();
                            break;

                        case 2:
                            
                            Console.WriteLine("I ryggsäcken finns: ");
                            Console.ForegroundColor = ConsoleColor.Yellow;    
                            Console.WriteLine(ryggsäcken);

                           
                            if (ryggsäcken == "")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("ingenting");
                            }
                            Console.ResetColor(); 
                            break;

                        case 3:
                            
                            ryggsäcken = "";
                            Console.Clear();
                            break;

                        case 4:
                          
                            minBool = false;
                            Console.Clear();
                            break;

                        default:
                         
                            Console.WriteLine("Du måste välja mellan 1-4");
                            break;
                } 
            }
        }
    }
}
       

