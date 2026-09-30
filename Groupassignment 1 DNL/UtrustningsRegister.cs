using System;
using System.Collections.Generic;
using System.Text;

namespace Groupassignment_1_DNL
{
    public class UtrustningsRegister
    {
        private List<Utrustning> Register{ get; set; } = [];

        public List<Utrustning> HamtaAlla()
        {
            return new List<Utrustning>(Register);
        }

        public void LaggaTill()
        {
            Register.Add();

        }

        public Utrustning? HamtaMedID()
        {
            while (true)
            {
                Console.Write("Skriv in ett ID: ");
                string sökid = Console.ReadLine();
                int.TryParse(sökid, out int id);
                foreach (var item in Register)
                {
                    if (item.Id == id)
                    {
                        Console.WriteLine(item.Enhetsnamn);
                        return item;
                    }
                }
                return null;

            }

        }
    }
}
