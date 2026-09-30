using System;
using System.Collections.Generic;
using System.Text;

namespace Groupassignment_1_DNL
{
    public class Utrustning
    {
      public bool Arutlanad { get; set; }
      public int Id { get; set; }

      public string Enhetsnamn { get; set; }





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



