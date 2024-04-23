using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBar
{
	internal class Barman
	{
        protected string _prenom;

		public string Prenom
		{
			get { return _prenom; }
			set { _prenom = value; }
		}

		public Barman(string prenom)
		{
			_prenom = prenom;
		}

		public string commander()
		{
			string info = "Bonjour, je m'appelle " + _prenom + " le barman, dites moi ce que vous desirer.";
			return info;
		}

		public string Fabriquer()
		{
			string info = "";
			return info;
		}

		public string Servir()
		{
			string info = " voici votre ";
			return info;
		}
	}
}
