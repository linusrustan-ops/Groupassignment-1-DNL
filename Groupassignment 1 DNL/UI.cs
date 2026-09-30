using System;
using System.Collections.Generic;
using System.Text;

namespace Groupassignment_1_DNL
{
    public class UI
    {
        public string void Visameny()
        {
            Console.WriteLine("""
                
                [1] Visa utrustning som finns tillgängliga.
                [2] Sök på utrustning
                [3] Låna ut utrustning
                [4] Lämna tillbaka utrustning
                [5] Avsluta
                

                Val: 
                
                """);
        }
        public int void Menyval()
        {
            while (true)
            {
                int meny;
                int.TryParse(Console.ReadLine(), out meny);
                switch (meny)
                {
                    case 1:
                        foreach (Utrustning utrustning in hämtadutrustning)
                        {
                            Console.WriteLine($"{utrustning.Id}, {utrustning.Namn}, {(utrustning.Arutlanad ? "utlånad" : "Tillgänglig")}");
                        }
                        continue; // tillbaka till huvudmenyn. 
                    case 2:
                        Bok?.HittaUtrustning();
                        
                        else
                        {
                            Console.WriteLine("Finns ej eller felaktig input");
                        }
                        continue;

                    case 3:
                        foreach (Utrustning utrustning in hämtadUtrustning)
                        {
                            Console.WriteLine($"{utrustning.Id}, {utrustning.Namn}, {(utrustning.Arutlanad ? "utlånad" : "Tillgänglig")}");
                        }
                        Console.WriteLine("vilken utrustningen vill du låna? utrustn");
                        string användarsvar = Console.ReadLine().ToLower().Trim();
                        if (användarsvar == "ja")
                        {
                            hittadutrustning.Lånaut();
                            continue; //  tillbaka till menyn igen
                        }
                        else
                        {
                            continue;
                        }
                    case 4:
                        foreach (Utrustning utrustning in hämtadUtrustning)
                        utrustning.LamnaTillbaka();
                        break;

                    case -1:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("retard alert, testa igen");
                        continue;

                }
            }

            
                
        }

    }
}
