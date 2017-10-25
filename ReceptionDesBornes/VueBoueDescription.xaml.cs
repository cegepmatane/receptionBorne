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
    public partial class VueBoueDescription : Window
    {
        private Bouee bouee;
        public VueBoueDescription(Bouee bouee)
        {
            InitializeComponent();

            this.bouee = bouee;

            labelIdBoue.Content = "ID : " + bouee.Id;
            labelLongitudeBoue.Content = "Longitude : " + bouee.Longitude;
            labelLatitudeBoue.Content = "Latitude : " + bouee.Latitude;
            labelTemperatureEauBoue.Content = "Temperature eau : " + bouee.TemperatureEau;
            labelTemperatureAirBoue.Content = "Temperature air : " + bouee.TemperatureAir;
            labelSaliniteBoue.Content = "Salinite : " + bouee.Salinite;
            labelVitesseVentBoue.Content = "Vitesse vent : " + (bouee.VitesseVent).ToString("N4");
            labelDimensionBoue.Content = "Dimension : " + bouee.Dimension;
            labelPressionAtmospheriqueBoue.Content = "Pression atmospherique : " + (bouee.PressionAtmospherique).ToString("N4");
        }
    }
}
