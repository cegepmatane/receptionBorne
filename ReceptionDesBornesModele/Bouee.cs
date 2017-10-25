using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptionDesBornesModele
{
    public class Bouee
    {
        private int id;
        private float longitude;
        private float latitude;
        private float temperatureEau;
        private float temperatureAir;
        private float salinite;
        private float vitesseVent;
        private float dimension;
        private float pressionAtmospherique;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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
            this.Id = id;
            this.Longitude = longitude;
            this.Latitude = latitude;
        }

        /*public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public float getLongitude()
        {
            return this.longitude;
        }

        public void setLongitude(float longitude)
        {
            this.longitude = longitude;
        }

        public float getLatitude()
        {
            return this.latitude;
        }

        public void setLatitude(float latitude)
        {
            this.latitude = latitude;
        }

        public float getTemperatureEau()
        {
            return this.temperatureEau;
        }

        public void setTemperatureEau(float temperatureEau)
        {
            this.temperatureEau = temperatureEau;
        }

        public float getTemperatureAir()
        {
            return this.temperatureAir;
        }

        public void setTemperatureAir(float temperatureAir)
        {
            this.temperatureAir = temperatureAir;
        }

        public float getSalinite()
        {
            return this.salinite;
        }

        public void setSalinite(float salinite)
        {
            this.salinite = salinite;
        }

        public float getVitesseVent()
        {
            return this.vitesseVent;
        }

        public void setVitesseVent(float vitesseVent)
        {
            this.vitesseVent = vitesseVent;
        }

        public float getDimension()
        {
            return this.dimension;
        }

        public void setDimension(float dimension)
        {
            this.dimension = dimension;
        }

        public float getPressionAtmospherique()
        {
            return this.pressionAtmospherique;
        }

        public void setPressionAtmospherique(float pressionAtmospherique)
        {
            this.pressionAtmospherique = pressionAtmospherique;
        }*/


    }
}
