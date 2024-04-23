using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBar
{
    internal class Recette
    {
		protected List<Portion> _ingredient;

		public List<Portion> Ingredient
		{
			get { return _ingredient; }
			set { _ingredient = value; }
		}

        public Recette(List<Portion> ingredient)
        {
            _ingredient = ingredient;
        }

        public string AfficheRecetteDispo()
        {
            string chaine = "";
            for (int i = 0; i < _ingredient.Count; i++)
            {
                chaine += "\n" + _ingredient[i].Quantiter + " quantiter de " + _ingredient[i].Contenu.Nom + " de type " + _ingredient[i].Contenu.Type +"\n";
            }
            string info = "voici les recettes disponibles actuellement : " + chaine;
            return info;
        }
    }
}
