using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionCommercial
{
    class Program
    {
        static void Main(string[] args)
        {
            Categorie cat1 = new Categorie("C012", "Négociateur");
            Categorie cat2 = new Categorie("C013", "Redistributeur");

            Service s1 = new Service("National");
            Service s2 = new Service("International");

            Commercial com1 = new Commercial("Qodad", "Adame", 1997, cat1, s2);
            Commercial com2 = new Commercial("Qodad", "Mohamed", 1969, cat2, s2);
            Commercial com3 = new Commercial("Zahir", "Ilyes", 1984, cat1, s2);

            Commercial com4 = new Commercial("El", "Jahid", 1982, cat1, s1);
            Commercial com5 = new Commercial("Costo", "John", 1962, cat2, s1);
            Commercial com6 = new Commercial("Dumur", "Ferkan", 1978, cat1, s1);



            s1.afficheCom();
            s2.afficheCom();

            com1.Compare(com2);
            com1.Compare(com3);

            s1.plusAge();
            s2.plusAge();

        }

    }

}