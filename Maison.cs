using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseBatiment
{
    class Maison : Batiment
    {
        private int _nbChambres;


        public Maison(string adresse, int nbChambres) : base(adresse)
        {
            _nbChambres = nbChambres;
        }
        public void SetNbChambres(int nbChambres)
        {
            _nbChambres = nbChambres;
        }
        public int GetNbChambres()
        {
            return _nbChambres;
        }
        public override string ToString()
        {
            return base.ToString() + "\nNombres de chambres : " + _nbChambres;
        }
    }
}
