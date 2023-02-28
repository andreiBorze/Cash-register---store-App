using Cash_register___store_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_register___store_App
{
    class PlataCash : IPlataCash
    {  
        public bool DeschideSeif()
        {
            Console.WriteLine("Seiful se deschide.....");
            Console.WriteLine("Seif deschis!");

            return true;
        }

        public bool InchideSeif()
        {
            Console.WriteLine("Seiful se inchide.....");
            Console.WriteLine("Seif Inchis!");

            return true;
        }

        public bool IntroducereSumaInSeif(decimal sumaPlatita)
        {
            Console.WriteLine("Se introduce suma in seif.....");
            Console.WriteLine("Suma introdusa!");

            return true;
        }
    }
}
