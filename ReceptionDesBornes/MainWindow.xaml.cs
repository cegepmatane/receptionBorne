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
            MessageBox.Show(listBoxBouee.SelectedItem.ToString());
        }

        public void afficherListeBouee(List<Bouee> listeBouee)
        {
            foreach (Bouee bouee in listeBouee)
            {
                //listBoxBouee.Items.Add(bouee.Id);
                listBoxBouee.Items.Add(new Fra);
            }
        }

        private void actionAfficherVueBoueDescription(object sender, RoutedEventArgs e)
        {
            //VueBoueDescription vueBoueDescription = new VueBoueDescription();
            //vueBoueDescription.Show();
        }
    }
}
