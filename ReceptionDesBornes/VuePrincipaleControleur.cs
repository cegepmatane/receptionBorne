using ReceptionDesBornesModele;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ReceptionDesBornes
{
    public sealed class VuePrincipaleControleur
    {
        private static VuePrincipaleControleur instance = null;
        private MainWindow vuePrincipale;
        private Timer timer;

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


            //construireVueListeBouee();
            timer = new Timer();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 5000; 
            timer.Start();
            BoueeDAO.recevoirLesBouees();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            afficherListeBouee(BoueeDAO.recevoirLesBouees());
        }

        public void setVuePrincipale(MainWindow vuePrincipale)
        {
            this.vuePrincipale = vuePrincipale;
        }

        /*private void construireVueListeBouee()
        {
            //A modif avec les donnée du DAO
            List<Bouee> listeBoueeTest = new List<Bouee>();

            for (int i = 0; i < 15; i++)
            {
                Bouee boueeTest = new Bouee(i, 0 + i, 0 + i);
                //MessageBox.Show(boueeTest.Nom);
                listeBoueeTest.Add(boueeTest);
            }

            afficherListeBouee(listeBoueeTest);
        }*/

        private void afficherListeBouee(List<Bouee> listeBouee)
        {
            vuePrincipale.afficherListeBouee(listeBouee);
        }
    }
}
