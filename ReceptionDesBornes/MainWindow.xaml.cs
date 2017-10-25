using ReceptionDesBornesModele;

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
            VuePrincipaleControleur.getInstance().start();

            listBoxBouee.MouseDoubleClick += ListBoxBouee_MouseDoubleClick;
        }

        private void ListBoxBouee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("" + ((ItemBouee)listBoxBouee.SelectedItem).Bouee.Id);

            actionAfficherVueBoueDescription(((ItemBouee)listBoxBouee.SelectedItem).Bouee);
        }

        public void afficherListeBouee(List<Bouee> listeBouee)
        {
            foreach (Bouee bouee in listeBouee)
            {
                listBoxBouee.Items.Add(new ItemBouee() { Nom = "" + bouee.Id, Bouee = bouee});
            }
        }

        private void actionAfficherVueBoueDescription(Bouee bouee)
        {
            VueBoueDescription vueBoueDescription = new VueBoueDescription(bouee);
            vueBoueDescription.Show();
        }
    }
}
