using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReceptionDesBornesModele;

namespace ReceptionDesBornes
{
    class ItemBouee
    {
        public Bouee bouee { get; set; }

        public ItemBouee(Bouee bouee)
        {
            this.bouee = bouee;
        }
    }
}
