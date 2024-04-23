using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBar
{
    internal class Cocktail
    {
        protected string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        protected Recette _recette;

        public Recette Recette
        {
            get { return _recette; }
            set { _recette = value; }
        }

        
        
        public Cocktail(string nom, Recette recette)
        {
            _nom = nom;
            _recette = recette;
        }

        public string DonnerLeCocktail()
        {
            string chaine = "";
            for (int i = 0; i < _recette.Ingredient.Length; i++)
            {
                chaine += "\n"+ "voici votre cocktail "+ _recette.Ingredient[i].Contenu.Nom + "\n";
            }
            string info = " Voici votre cocktail " + chaine;
            return info;
        }
    }
}
