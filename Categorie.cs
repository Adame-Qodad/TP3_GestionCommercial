using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionCommercial
{
    internal class Categorie
    {
        private string codeCategorie;
        private string libCategorie;

        public string CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
        public string LibCategorie { get => libCategorie; set => libCategorie = value; }

        public Categorie(string code, string lib) 
        { 
            this.CodeCategorie = code;
            this.LibCategorie = lib;
        }

        public override string ToString()
        {
            return "Son code est " + this.CodeCategorie + " et son libellé est " + this.LibCategorie + ".\n";
        }



    }
}
