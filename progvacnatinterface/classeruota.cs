using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progvacnatinterface
{
	public class classeruota :Componente
	{
		private classecerchione cerchione;
		private classegomma gomma;
		public classeruota(classecerchione cerchione, classegomma gomma)
		{
			Cerchione = cerchione;
			Gomma = gomma;
		}
		public classecerchione Cerchione
		{
			get { return cerchione; }
			set { cerchione = value; }
		}
		public classegomma Gomma
		{
			get { return gomma; }
			set { gomma = value; }
		}

		public double CalcolaCosto()
		{
			return cerchione.CalcolaCosto() + gomma.CalcolaCosto();
		}
		public string Descrizione()
		{
			return $"Ruota {cerchione.Descrizione()}, {gomma.Descrizione()}";
		}
		public Componente GetChild(int i)
		{
			throw new NotImplementedException();
		}
		public void Aggiunta(Componente componente)
		{
			throw new NotImplementedException();
		}
		public void Rimuovi(int i)
		{
			throw new NotImplementedException();
		}

	}
}
