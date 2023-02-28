using System;
using System.Collections.Generic;
using Cash_register___store_App.Interfaces;
using System.Text;

namespace Cash_register___store_App
{
    public class PlataPOS
    {
        public void Plateste(IContactFull card, decimal suma)
        {
            card.IntroduCardul();
            card.Efectueaza(suma);
            card.ExtrageCard();
        }

        public void Plateste(IContactLess contactless, decimal suma)
        {
            contactless.Apropiere();
            contactless.Efectueaza(suma);
        }
    }
}
