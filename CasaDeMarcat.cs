using Cash_register___store_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_register___store_App
{
    public class CasaDeMarcat
    {
        private PlataCash plataCash;
        private PlataPOS plataPos;
        private Bon bon;

        public CasaDeMarcat()
        {
            plataCash = new PlataCash();
            plataPos = new PlataPOS();
            bon = new Bon();
        }

        public void PlatesteCash(decimal suma)
        {
            plataCash.DeschideSeif();
            plataCash.IntroducereSumaInSeif(suma);
            plataCash.InchideSeif();

            bon.getDescriere(suma, "plata cash");
            
        }

        public void PlatesteCardLess(decimal suma, IContactLess card)
        {
            plataPos.Plateste(card, suma);
            bon.getDescriere(suma, "plata cash");
        }

        public void PlatesteCardFull(decimal suma, IContactFull card)
        {
            plataPos.Plateste(card, suma);
            bon.getDescriere(suma, "plata full");
        }

        public void PlatesteTelefon(decimal suma, IContactLess card)
        {
            plataPos.Plateste(card, suma);
            bon.getDescriere(suma, "plata cu telefonul");
        }
    }


}
