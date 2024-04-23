using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBar
{
    internal class Shaker
    {
        protected Recette _recetteCocktail;

		public Recette RecetteCocktail
		{
			get { return _recetteCocktail; }
			set { _recetteCocktail = value; }
		}

		public Shaker(Recette recetteCocktail)
		{
			_recetteCocktail = recetteCocktail;
		}

		public string Melanger()
		{
            string chaine = "";
            for (int i = 0; i < _recetteCocktail.Ingredient.Length; i++)
            {
                chaine += "\n" + _recetteCocktail.Ingredient[i].Contenu.Nom + " quantiter de " + _recetteCocktail.Ingredient[i].Quantiter + "\n";
            }
            string info = " melange de "+ chaine;
			return info;
		}

        public string AjouterQuantiter(Portion portion)
        {
            string info = "voici vos quantiter";
            return info;
        }

    }
}
