using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptionDesBornesModele
{
    public class Bouee
    {
        private int idBouee;
        private float longitude;
        private float latitude;
        private float temperatureEau;
        private float temperatureAir;
        private float salinite;
        private float vitesseVent;
        private float dimension;
        private float pressionAtmospherique;

        public int IdBouee
        {
            get
            {
                return idBouee;
            }

            set
            {
                idBouee = value;
            }
        }

        public float Longitude
        {
            get
            {
                return longitude;
            }

            set
            {
                longitude = value;
            }
        }

        public float Latitude
        {
            get
            {
                return latitude;
            }

            set
            {
                latitude = value;
            }
        }

        public float TemperatureEau
        {
            get
            {
                return temperatureEau;
            }

            set
            {
                temperatureEau = value;
            }
        }

        public float TemperatureAir
        {
            get
            {
                return temperatureAir;
            }

            set
            {
                temperatureAir = value;
            }
        }

        public float Salinite
        {
            get
            {
                return salinite;
            }

            set
            {
                salinite = value;
            }
        }

        public float VitesseVent
        {
            get
            {
                return vitesseVent;
            }

            set
            {
                vitesseVent = value;
            }
        }

        public float Dimension
        {
            get
            {
                return dimension;
            }

            set
            {
                dimension = value;
            }
        }

        public float PressionAtmospherique
        {
            get
            {
                return pressionAtmospherique;
            }

            set
            {
                pressionAtmospherique = value;
            }
        }

        public Bouee(){}

        public Bouee(int id, float longitude, float latitude)
        {
            this.IdBouee = id;
            this.Longitude = longitude;
            this.Latitude = latitude;
        }

    }
}
