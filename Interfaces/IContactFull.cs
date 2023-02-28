using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_register___store_App.Interfaces
{
    public interface IContactFull: IEfectueazaPlata
    {
        public bool ExtrageCard();
        public bool IntroduCardul();
    }
}
