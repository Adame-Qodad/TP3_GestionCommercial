using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionCommercial
{
    internal class Service
    {
        private Commercial[] tabC;
        private int effectif;
        private string nomS;

        public int Effectif { get => effectif; set => effectif = value; }
        public string NomS { get => nomS; set => nomS = value; }
        internal Commercial[] TabC { get => tabC; set => tabC = value; }

        public Service(string nomS)
        {
            this.TabC = new Commercial[10];
            this.Effectif = 0;
            this.NomS = nomS;

        }
        public void ajouterCom(Commercial c)
        {
            this.TabC[this.Effectif] = c;
            this.Effectif ++;
        }

        public override string ToString()
        {
            return "Il fait parti du service " + this.NomS + ".\n\n";
        }

        public void afficheCom()
        {
            Console.WriteLine("Liste pour le service " + this.NomS +" :\n");
            foreach (Commercial c in TabC)
            {
                if (c != null)
                {
                    Console.WriteLine(c);
                }

            }
        }

        public void plusAge()
        {
            Commercial plusAge = this.TabC[0];

            foreach (Commercial em in this.TabC)
            {
                if (em != null && em.AnneeNaissance < plusAge.AnneeNaissance)
                {
                    plusAge = em;
                }
            }
            Console.WriteLine("Le commercial le plus âgé est le commercial :\n" + plusAge);

        }

        
    }
}
