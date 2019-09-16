using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class salleCinema
    {
        private int nombrePlaces;
        private string filmJoue;
        private double prixFilmNormal;
        private int nombrePlacesVenduesNormal;
        private int nombrePlacesVenduesReduit;
        private int idSalle;

        public salleCinema(string titreFilm, int placesDispo,  double prixUnitaire, int id)
        {
            this.filmJoue = titreFilm;
            this.nombrePlaces = placesDispo;
            this.prixFilmNormal = prixUnitaire;
            this.idSalle = id;
            nombrePlacesVenduesNormal = 0;
            nombrePlacesVenduesReduit = 0;
        }

        public int nbPlacesDisponibles()
        {
            int dispo = 0;
            dispo = this.nombrePlaces - this.nombrePlacesVenduesNormal - nombrePlacesVenduesReduit;
            return dispo;
        }

        public void vendrePlaces(int nbre, bool tarifReduit)
        {
            if(this.nbPlacesDisponibles() - nbre > 0)
            {
                if (tarifReduit)
                {
                    nombrePlacesVenduesReduit += nbre;
                }
                else
                {
                    nombrePlacesVenduesNormal += nbre;
                }
            }
        }

        public void remiseAZero()
        {
            if(this.nbPlacesDisponibles() == 0)
            {
                nombrePlaces = 0;
                nombrePlacesVenduesNormal = 0;
                nombrePlacesVenduesReduit = 0;
            }
        }
        public double chiffreAffaires()
        {
            return (this.nombrePlacesVenduesNormal * prixFilmNormal + (this.nombrePlacesVenduesReduit * (this.prixFilmNormal * 0.60) ) );

        }

        public double tauxRemplissage()
        {
            int nombrePlacesVenduesTotales = nombrePlacesVenduesNormal + nombrePlacesVenduesReduit;
            double leTR;
            leTR = nombrePlacesVenduesTotales * nombrePlaces / 100;
            return leTR;
        }

        public String toString()
        {
            return "Le film de votre séance est :" + this.filmJoue + ", il y a :" + this.nombrePlaces +  "places, le prix d'une place est : " + this.prixFilmNormal + "euros, il y a au total " + this.nombrePlacesVenduesNormal + "places vendues au tarif normal et " + this.nombrePlacesVenduesReduit + " au tarif réduit";
        }
    }
}
