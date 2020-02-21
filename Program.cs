using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
	class Program
	{
		static void Main(string[] args)
		{
			/*List<int> nekaLista = new List<int>();
			nekaLista.Add(5);
			nekaLista.Add(8);
			nekaLista.Add(10);

			for (int indeks = 0; indeks < nekaLista.Count; indeks++)
			{
				nekaLista[indeks]++;
				Console.WriteLine(nekaLista[indeks]);
			}*/

			//Console.WriteLine("----------------");

			List<Nesto> lista = new List<Nesto>();

			Nesto n = new Nesto(7);
			lista.Add(n);
			
			lista.Add(new Nesto(5)); //isto kao dva reda gore



			foreach (Nesto bla in lista)
			{
				bla.x++;
			}

			lista.RemoveAt(1); //ukloni sa indeksa 1
			if (lista.Remove(n))   //kroz listu, od poceta, trazi prvi objekat
			{                     //da je jedank parametru i brise ga ako ga nadje
				Console.WriteLine("Uspesno uklonjen");    
			}
			lista.Clear();
			Console.ReadKey();
		}
	}

	class Nesto
	{
		public int x;

		public Nesto(int br)
		{
			x = br;
		}
	}
}
