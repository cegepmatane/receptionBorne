﻿using ReceptionDesBornesModele;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        }

        public void start()
        {
            List<Bouee> listeBoueeTest = new List<Bouee>();

            for (int i = 0; i < 15; i++)
            {
                Bouee boueeTest = new Bouee("Bouée no" + i);
                //MessageBox.Show(boueeTest.Nom);
                listeBoueeTest.Add(boueeTest);
            }

            construireVueListeBouee(listeBoueeTest);
        }

        public void setVuePrincipale(MainWindow vuePrincipale)
        {
            this.vuePrincipale = vuePrincipale;
        }

        private void construireVueListeBouee(List<Bouee> listeBouee)
        {
            vuePrincipale.afficherListeBouee(listeBouee);
        }
    }
}
