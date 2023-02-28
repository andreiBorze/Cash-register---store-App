using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_register___store_App.Interfaces
{
    interface IBon
    {
        public decimal getSumaPlatita(decimal SumaDePlata, string MetodaDePlata);

        public string getMetodaPlata(string MetodaDePlata);

        public string getDescriere(decimal SumaDePlata, string MetodaDePlata);

    }
}
