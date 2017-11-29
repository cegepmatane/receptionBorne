using GMap.NET.WindowsPresentation;
using ReceptionDesBornesModele;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        private List<Bouee> listeBouee;

        public MainWindow()
        {
            InitializeComponent();

            VuePrincipaleControleur.getInstance().setVuePrincipale(this);
            VuePrincipaleControleur.getInstance().start();

            //listBoxBouee.MouseDoubleClick += ListBoxBouee_MouseDoubleClick;
            buttonAfficherStatistique.Click += ButtonAfficherStatistique_Click;
        }

        private void ButtonAfficherStatistique_Click(object sender, RoutedEventArgs e)
        {
            actionAfficherVueBoueStatistique(this.listeBouee);
        }

        /*private void ListBoxBouee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("" + ((ItemBouee)listBoxBouee.SelectedItem).Bouee.Id);

            actionAfficherVueBoueDescription(((ItemBouee)listBoxBouee.SelectedItem).Bouee);
        }*/

        public void afficherListeBouee(List<Bouee> listeBouee)
        {
            this.listeBouee = listeBouee;

            //listBoxBouee.Items.Clear();
            foreach (Bouee bouee in listeBouee)
            {
                //listBoxBouee.Items.Add(new ItemBouee() { Nom = "Id: " + bouee.IdBouee + " Latitude: " + bouee.Latitude + " Longitude: " + bouee.Longitude, Bouee = bouee});

                GMapMarker marker = new GMapMarker(new GMap.NET.PointLatLng(bouee.Longitude, bouee.Latitude));
                marker.Shape = new BoueeShape(bouee);

                marker.Shape.MouseUp += Shape_MouseUp;

                mapView.Markers.Add(marker);
            }
        }

        private void Shape_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show(" id = " + ((BoueeShape)sender).Bouee.Id);
            actionAfficherVueBoueDescription(((BoueeShape)sender).Bouee);
        }

        private void actionAfficherVueBoueStatistique(List<Bouee> listeBouee)
        {
            //VueBoueStatistique vueBoueStatistique = new VueBoueStatistique(listeBouee);
            //vueBoueStatistique.Show();
            //System.Diagnostics.Process.Start("java.exe -jar C:\\\\statistiques.jar");
            //Console.Write(System.Windows.Forms.Application.StartupPath);

            System.Diagnostics.Process clientProcess = new Process();
            clientProcess.StartInfo.FileName = "java";
            clientProcess.StartInfo.Arguments = @"-jar statistiques.jar";
            clientProcess.StartInfo.CreateNoWindow = true;
            clientProcess.StartInfo.UseShellExecute = false;
            clientProcess.Start();
        }

        private void actionAfficherVueBoueDescription(Bouee bouee)
        {
            VueBoueDescription vueBoueDescription = new VueBoueDescription(bouee);
            vueBoueDescription.Show();
        }

        private void mapView_Loaded(object sender, RoutedEventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            mapView.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            mapView.Position = new GMap.NET.PointLatLng(48.488232, -68.601312);
            mapView.MinZoom = 7;
            mapView.MaxZoom = 15;
            // whole world zoom
            mapView.Zoom = 8;
            // lets the map use the mousewheel to zoom
            mapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            // lets the user drag the map
            mapView.CanDragMap = false;
            // lets the user drag the map with the left mouse button
            mapView.DragButton = MouseButton.Left;

        }
    }
}
