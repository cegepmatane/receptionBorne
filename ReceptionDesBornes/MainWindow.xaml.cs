using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReceptionDesBornes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            VuePrincipaleControleur.getInstance().setVuePrincipale(this);
        }

        public void afficherListeBouee(List<Object> listeBouee)
        {
            //Change Object par modele Bouee
            foreach (Object bouee in listeBouee)
            {
                listBoxBouee.Items.Add("bouee.getNom()");
            }
        }
    }
}
