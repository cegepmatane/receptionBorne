using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptionDesBornes
{
    public sealed class VuePrincipaleControleur
    {
        private static VuePrincipaleControleur instance = null;
        private MainWindow vuePrincipale;

        public static VuePrincipaleControleur getInstance()
        {
            if (instance == null) instance = new VuePrincipaleControleur();
            return instance;
        }

        private VuePrincipaleControleur()
        {


            //construireVueListeBouee();
        }

        public void setVuePrincipale(MainWindow vuePrincipale)
        {
            this.vuePrincipale = vuePrincipale;
        }

        private void construireVueListeBouee(List<Object> listeBouee)
        {
            //Change Object par modele Bouee
            vuePrincipale.afficherListeBouee(listeBouee);
        }
    }
}
