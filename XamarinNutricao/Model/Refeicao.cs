using System;
using SQLite;

namespace XamarinNutricao
{
	public class Refeicao
	{
		[PrimaryKey,AutoIncrement]
		public int Id { get; set; }
		public string Descricao { get; set; }
		public double Calorias { get; set; }
		public Refeicao()
		{

		}
		public Refeicao(String refe, double valor)
		{
			
				this.Descricao = refe;
				this.Calorias = valor;
			
			
		}
	}
}
