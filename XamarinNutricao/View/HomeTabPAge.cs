using System;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;


namespace XamarinNutricao
{
	public class HomeTabPAge : TabbedPage
	{
		public HomeTabPAge()
		{
			//ObservableCollection <Refeicao> refeicoes = new ObservableCollection<Refeicao>();
			SQLiteConnection con = DependencyService.Get<ISQlite>().GetConnection();
			RefeicaoDAO dao = new RefeicaoDAO(con);

			this.Children.Add(new CadastroRefeicao(dao));
			this.Children.Add(new ListarRefeicoes(dao));

		}
	}
}

