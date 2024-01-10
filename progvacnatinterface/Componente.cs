using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progvacnatinterface
{
	public interface Componente
	{
		 string Descrizione();
     void Aggiunta(Componente componente);
	   void Rimuovi(int i);
		 Componente GetChild(int i);
     double CalcolaCosto();

	}
}
