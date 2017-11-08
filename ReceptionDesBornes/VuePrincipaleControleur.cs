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
        private float positionLongitude;
        private float positionLatitude;

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
            //#### ativer le serveur web pour le DAO

            construireVueListeBouee();
            //construireVueListeBoueeAvecDAO();
        }

        private void construireVueListeBoueeAvecDAO()
        {
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

        private void construireVueListeBouee()
        {
            //A modif avec les donnée du DAO
            List<Bouee> listeBoueeTest = new List<Bouee>();

            for (int i = 0; i < 15; i++)
            {
                positionLongitude = 48.488232f + (0.1f * i);
                positionLatitude = -68.601312f + (0.1f * i);

                //MessageBox.Show("Longitude = " + positionLongitude + ", Latitude = " + positionLatitude + " ,i = " + (0.001f * i));

                Bouee boueeTest = new Bouee(i, positionLongitude, positionLatitude);
                //MessageBox.Show(boueeTest.Nom);
                listeBoueeTest.Add(boueeTest);
            }

            afficherListeBouee(listeBoueeTest);
        }

        private void afficherListeBouee(List<Bouee> listeBouee)
        {
            vuePrincipale.afficherListeBouee(listeBouee);
        }
    }
}
