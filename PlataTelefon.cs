using Cash_register___store_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_register___store_App
{
    class PlataTelefon : PlataPOS,IContactLess
    {

        public bool Apropiere()
        {
            Console.WriteLine("Apropiere.....");
            Console.WriteLine("Telefonul este apropiat!");

            return true;
        }

        public bool Efectueaza(decimal Suma)
        {
            Console.WriteLine("Plata a inceput.....");
            Console.WriteLine($"Plata efectuata! Suma Platita: {Suma}");

            return true;
        }
    }
}
