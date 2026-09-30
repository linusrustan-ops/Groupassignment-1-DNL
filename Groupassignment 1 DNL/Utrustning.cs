using System;
using System.Collections.Generic;
using System.Text;

namespace Groupassignment_1_DNL
{
    public class Utrustning
    {
        bool Arutlanad { get; set; }
        int Id { get; set; }

        string Enhetsnamn { get; set; }





        public Utrustning(int ID, string enhet)
        {

            enhet = Enhetsnamn;
            ID = Id;
            Arutlanad = false;

        }

        public bool LanaUt()
        {
            if (Arutlanad == false)
            {
                Arutlanad = true;
                return Arutlanad;
            }
            else
            {
                Console.WriteLine("Den här går tyvärr inte att låna ut i nuläget");
                return true;
            }

        }


        public bool LamnaTillbaks()
        {
            if (Arutlanad == true)
            {
                Arutlanad = false;
                return Arutlanad;
            }
            else
            {
                Console.WriteLine("Den här varan är inte ens utlånad!");
                return false;



            }
        }
    }
}



