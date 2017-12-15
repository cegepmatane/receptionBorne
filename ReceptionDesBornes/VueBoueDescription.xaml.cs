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
using System.Threading;
using System.Resources;
using System.Globalization;
using System.Reflection;

namespace ReceptionDesBornes
{
    public partial class VueBoueDescription : Window
    {
        private Bouee bouee;
        public VueBoueDescription(Bouee bouee, CultureInfo cu)
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentUICulture = cu;

            ResourceManager rm = new ResourceManager("ReceptionDesBornes.Resources.String", Assembly.GetExecutingAssembly());

            String idBoue = rm.GetString("labelIdBoue");
            String longitudeBoue = rm.GetString("labelLongitudeBoue");
            String latitudeBoue = rm.GetString("labelLatitudeBoue");
            String temperatureEauBoue = rm.GetString("labelTemperatureEauBoue");
            String temperatureAirBoue = rm.GetString("labelTemperatureAirBoue");
            String saliniteBoue = rm.GetString("labelSaliniteBoue");
            String vitesseVentBoue = rm.GetString("labelVitesseVentBoue");
            String dimensionBoue = rm.GetString("labelDimensionBoue");
            String pressionAtmospheriqueBoue = rm.GetString("labelPressionAtmospheriqueBoue");


            this.bouee = bouee;

            labelIdBoue.Content = idBoue + " : " + bouee.IdBouee;
            labelLongitudeBoue.Content = longitudeBoue + " : " + bouee.Longitude;
            labelLatitudeBoue.Content = latitudeBoue + " : " + bouee.Latitude;
            labelTemperatureEauBoue.Content = temperatureEauBoue + " : " + bouee.TemperatureEau;
            labelTemperatureAirBoue.Content = temperatureAirBoue + " : " + bouee.TemperatureAir;
            labelSaliniteBoue.Content = saliniteBoue + " : " + bouee.Salinite;
            labelVitesseVentBoue.Content = vitesseVentBoue + " : " + (bouee.VitesseVent).ToString("N4");
            labelDimensionBoue.Content = dimensionBoue + " : " + bouee.Dimension;
            labelPressionAtmospheriqueBoue.Content = pressionAtmospheriqueBoue + " : " + (bouee.PressionAtmospherique).ToString("N4");
        }
    }
}
