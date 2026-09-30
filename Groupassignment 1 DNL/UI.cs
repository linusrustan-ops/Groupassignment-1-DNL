using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace Groupassignment_1_DNL
{
    public class UI
    {
        private UtrustningsRegister register;
        List<Utrustning> hämtadregister;
        public UI(UtrustningsRegister register)
        {
            this.register = register;
        }

        public void Visameny()
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
        public void Menyval()
        {
            while (true)
            {
                register.HamtaAlla();
                int meny;
                int.TryParse(Console.ReadLine(), out meny);
                switch (meny)
                {
                    case 1:

                        foreach (Utrustning utrustning in hämtadregister)
                        {
                            Console.WriteLine($"{utrustning.Id}, {utrustning.Enhetsnamn}, {(utrustning.Arutlanad ? "utlånad" : "Tillgänglig")}");
                        }
                        continue; // tillbaka till huvudmenyn. 

                    case 2:

                        Utrustning? hittadUtrustning = register.HamtaMedID();
                        if (!int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.WriteLine("Felaktig input.");
                            continue;
                        }
                        if (hittadUtrustning != null)
                        {
                            Console.WriteLine(
                                $"{hittadUtrustning.Id}, " +
                                $"{hittadUtrustning.Enhetsnamn}, " +
                                $"{(hittadUtrustning.Arutlanad ? "Utlånad" : "Tillgänglig")}"
                            );
                        }
                        else
                        {
                            Console.WriteLine("Utrustningen finns inte.");
                        }
                        continue;

                    case 3:

                        foreach (Utrustning utrustning in hämtadregister)
                        {
                            Console.WriteLine($"{utrustning.Id}, {utrustning.Enhetsnamn}, {(utrustning.Arutlanad ? "utlånad" : "Tillgänglig")}");
                        
                            Console.WriteLine("vilken utrustningen vill du låna? utrustn");
                            string användarsvar = Console.ReadLine().ToLower().Trim();
                            if (användarsvar == "ja")
                            {
                                utrustning.LanaUt();
                                continue; //  tillbaka till menyn igen
                            }
                            else
                            {
                                continue;
                            }
                        }
                        continue;
                    case 4:
                        foreach (Utrustning utrustning in hämtadregister)
                        {
                            utrustning.LamnaTillbaks();
                            break;
                        }
                        continue;

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
