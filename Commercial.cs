using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionCommercial
{
    internal class Commercial
    {
        private string nom;
        private string prenom;
        private int anneeNaissance;
        private Categorie cat;
        private Service service;
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        internal Categorie Cat { get => cat; set => cat = value; }
        internal Service Service { get => service; set => service = value; }

        public Commercial(string nom, string prenom, int anneeNaissance, Categorie cat, Service service)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.AnneeNaissance = anneeNaissance;
            this.Cat = cat;
            this.Service = service;
            this.Service.ajouterCom(this);
        }

        public int CalculAge()
        {
           int diff = DateTime.Now.Year - this.AnneeNaissance;
            return diff;
        }

        public override string ToString()
        {
            return "nom : " + this.Nom + "\nprenom : " + this.Prenom + "\nAnnée de Naissance : " + this.AnneeNaissance + "\nCe commercial a " + CalculAge() + " ans.\n" + this.Cat + this.Service;
        }

        public void Compare(Commercial c)
        {
            if (this.Nom == c.Nom) 
            {
                Console.WriteLine("Les commerciaux "+ this.Prenom + " et " + c.Prenom + " ont le même nom de famille.\n");
            }

            else
            {
                Console.WriteLine("Les commerciaux "+ this.Prenom + " et " + c.Prenom + " n'ont pas le même nom de famille.\n\n");
            }
        }

    }
}
