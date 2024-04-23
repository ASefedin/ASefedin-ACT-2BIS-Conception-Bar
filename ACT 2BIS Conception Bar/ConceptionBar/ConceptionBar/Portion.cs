using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBar
{
	internal class Portion
	{
        protected Liquide _contenu;

		public Liquide Contenu
		{
			get { return _contenu; }
			set { _contenu = value; }
		}

        protected double _quantiter;

		public double Quantiter
		{
			get { return _quantiter; }
			set { _quantiter = value; }
		}

		public Portion(Liquide contenu, double quantiter)
		{
			_contenu = contenu;
			_quantiter = quantiter;
		}

		
	}
}
