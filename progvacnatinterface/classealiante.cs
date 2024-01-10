using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progvacnatinterface
{
	public class classealiante : Componente
	{
		List<Componente> componenti = new List<Componente>();
		public List<Componente> Componenti
		{
			get { return componenti; }
			set { componenti = value; }
		}
		public classealiante(List<Componente> componenti)
		{
			Componenti = componenti;
		}
		public classealiante(classeala _ala, classefusoliera _fus, classecoda _coda, classeruota _ruota)
		{
			Componenti.Add(_ala);
			Componenti.Add(_fus);
			Componenti.Add(_coda);
			Componenti.Add(_ruota);
		}
		public  void Aggiunta(Componente componente)
		{
			Componenti.Add(componente);
		}
		public  void Rimuovi(int i)
		{
			if (i >= 0 && i < Componenti.Count)
			{
				Componenti.RemoveAt(i);
			}

		}
		public Componente GetChild(int i)
		{
			if (i < Componenti.Count)
			{
				return Componenti[i];
			}
			else
			{
				return null;
			}
		}
		public double CalcolaCosto()
		{
			double totale = 0;

			foreach (Componente componente in Componenti)
			{
				totale += componente.CalcolaCosto();
			}
			return totale;
		}
		public  string ToString()
		{
			string stringa = "";
			foreach (Componente componente in Componenti)
			{
				stringa += componente.ToString() + "\n";
			}
			return $"Aliante - {stringa}";
		}
		public  string Descrizione()
		{
			string stringa = "";
			foreach (Componente componente in Componenti)
			{
				stringa += componente.Descrizione() + "\n";
			}
			return $"Aliante - {stringa}";
		}
	}
}
