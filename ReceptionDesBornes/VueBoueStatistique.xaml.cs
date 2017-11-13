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
using System.Windows.Shapes;



namespace ReceptionDesBornes
{
    /// <summary>
    /// Logique d'interaction pour VueBoueStatistique.xaml
    /// </summary>
    public partial class VueBoueStatistique : Window
    {
        private List<Bouee> listeBouee;

        public VueBoueStatistique(List<Bouee> listeBouee)
        {
            InitializeComponent();

            this.listeBouee = listeBouee;
        }


    }
}
