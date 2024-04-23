using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBar
{
    internal class Bouteille
    {
        protected string _contenance;

		public string Contenance
		{
			get { return _contenance; }
			set { _contenance = value; }
		}

        protected Liquide _contenu;

		public Liquide Contenu
        {
			get { return _contenu; }
			set { _contenu = value; }
		}

		public Bouteille(string contenance, Liquide contenu)
		{
			_contenance = contenance;
			_contenu = contenu;
		}

		public string Remplir()
		{
            string info = "";
            return info;
        }
	}
}
