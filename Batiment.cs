using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseBatiment
{
    class Batiment
    {
        private string _adresse;
        public Batiment(string adresse)
        {
            _adresse = adresse;  
        }

        public void SetAdresse(string adresse)
        {
            _adresse = adresse;
        }

        public string GetAdresse()
        {
            return _adresse;
        }
        public override string ToString()
        {
            string txt = "";
            txt += "L'adresse du batiment : " + _adresse;
            return txt;
        }
    }
}
