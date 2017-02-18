using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XamarinNutricao
{
	public partial class ListarRefeicoes : ContentPage
	{
		public ObservableCollection<Refeicao> Refeicoes { get; set; }
		private RefeicaoDAO dao;
			
		public ListarRefeicoes(RefeicaoDAO dao)
		{
			
			BindingContext=this;
			this.dao = dao;
			Refeicoes = dao.Lista;
			InitializeComponent();
			
		}
		public async void AcaoItem(Object obj, ItemTappedEventArgs e)
		{
			Refeicao refeicao = e.Item as Refeicao;
			var resposta = await DisplayAlert("Remover Item", "Voce deseja remover a refeicao " + refeicao.Descricao, "Sim", "Nao");
			if (resposta)
			{
				dao.Remove(refeicao);
				await DisplayAlert("Refeicao removida", "", "OK");
			}

		}
	}
}
