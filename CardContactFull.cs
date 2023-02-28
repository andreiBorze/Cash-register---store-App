using Cash_register___store_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_register___store_App
{
    public class CardContactFull: PlataCard, IContactFull
    {

        public bool Efectueaza(decimal Suma)
        {
            Console.WriteLine("Plata a inceput.....");
            Console.WriteLine($"Plata efectuata! Suma Platita: {Suma}");

            return true;
        }

        public bool ExtrageCard()
        {
            Console.WriteLine("Cardul este retras.....");

            return true;
        }

        public bool IntroduCardul()
        {
            Console.WriteLine("Cardul este introdus.....");

            return true;
        }
    }
}
