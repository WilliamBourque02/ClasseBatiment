using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseBatiment
{
    class Entrepot : Batiment 
    {
        private string _revetementExterieur;
        private string _quaiDeChargement;

        public Entrepot(string adresse,string revetementExterieur, string quaiDeChargement) : base(adresse)
        {
            _revetementExterieur = revetementExterieur;
            _quaiDeChargement = quaiDeChargement;
        }
        public void SetRevetementExterieur(string revetementExterieur)
        {
            _revetementExterieur = revetementExterieur;
        }
        public void SetQuaiDeChargement(string quaiDeChargement)
        {
            _quaiDeChargement = quaiDeChargement;
        }
        public string GetRevetementExterieur()
        {
            return _revetementExterieur;
        }
        public string GetQuaiDeChargement()
        {
            return _quaiDeChargement;
        }

        public override string ToString()
        {
            return base.ToString() + "\nRevêtement Extérieur : " + GetRevetementExterieur() + "\nQuai de Chargement : " + GetQuaiDeChargement();
        }
    }
}
