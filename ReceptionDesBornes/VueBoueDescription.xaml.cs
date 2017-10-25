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

using ReceptionDesBornesModele;

namespace ReceptionDesBornes
{
    /// <summary>
    /// Logique d'interaction pour VueBoueDescription.xaml
    /// </summary>
    public partial class VueBoueDescription : Window
    {
        private Bouee bouee;
        public VueBoueDescription(Bouee bouee)
        {
            InitializeComponent();

            this.bouee = bouee;

            labelIdBoue.Content = "" + bouee.Id;
        }


    }
}
