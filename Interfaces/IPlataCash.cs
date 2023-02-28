using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_register___store_App.Interfaces
{
    interface IPlataCash
    {
        public bool DeschideSeif();
        public bool IntroducereSumaInSeif( decimal sumaPlatita);
        public bool InchideSeif();


    }
}
