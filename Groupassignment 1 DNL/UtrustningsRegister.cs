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


            }

        }
    }
}
