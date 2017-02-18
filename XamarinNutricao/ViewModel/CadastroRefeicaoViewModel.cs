using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinNutricao
{
	public class CadastroRefeicaoViewModel : INotifyPropertyChanged
	{
		private string descricao;
		private double calorias;
		public string Descricao
		{
			get
			{
				return descricao;
			}
			set
			{
				if (value != descricao)
				{
					descricao = value;
					OnPropertyChanged("Descricao");
				}
			}
		}

		public double Calorias {
			get
			{
				return calorias;
			}
			set
			{if (value != calorias)
				{
					calorias = value;
					OnPropertyChanged("Calorias");
				}
			}
		}
		public event PropertyChangedEventHandler PropertyChanged;
		public ICommand SalvaRefeicao { get; protected set; }
		//private RefeicaoDAO dao;
		private ContentPage page;
		private void OnPropertyChanged(string nome)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(nome));
		}
		public CadastroRefeicaoViewModel(RefeicaoDAO dao, ContentPage page)
		{
			//this.dao = dao;
			this.page = page;
			SalvaRefeicao = new Command(() =>
			{
				Refeicao refeicao = new Refeicao(descricao, calorias);
				dao.Salvar(refeicao);
				string refi = "A refeicao " + descricao + " de " + calorias + " calorias foi salva";
				this.page.DisplayAlert("Salvar Refeicao", refi, "Ok");
				
			});
		}
	

	}
}
