using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBar
{
    internal class Liquide
    {
        protected string _nom;

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

        protected string _type;

		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}

		public Liquide(string nom, string type)
		{
			_nom = nom;
			_type = type;
		}

	}
}
