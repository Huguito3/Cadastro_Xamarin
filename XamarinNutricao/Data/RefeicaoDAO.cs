using System;
using System.Collections.ObjectModel;
using SQLite;

namespace XamarinNutricao
{
	public class RefeicaoDAO
	{
		private SQLiteConnection connexao;
		private ObservableCollection<Refeicao> lista;
		public ObservableCollection<Refeicao> Lista { 
			get {
				if ( lista == null ) {
					lista = GetAll();
				}
				return lista;
			
			} 
			private set {
				lista = value;
			}
		}
		public RefeicaoDAO(SQLiteConnection con)
		{
			connexao = con;
			connexao.CreateTable<Refeicao>();
		}

		public void Salvar(Refeicao refei)
		{
			connexao.Insert(refei);
			lista.Add(refei);
		}
		public void Remove(Refeicao refeicao)
		{
			connexao.Delete<Refeicao>(refeicao.Id);
			lista.Remove(refeicao);

		}
		private ObservableCollection<Refeicao> GetAll()
		{
			return new ObservableCollection<Refeicao>(connexao.Table<Refeicao>());


		}


	}
}
