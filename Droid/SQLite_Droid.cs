using System;
using SQLite;
using System.IO;
using Xamarin.Forms;
using XamarinNutricao.Droid;

[assembly: Dependency(typeof(SQLite_Droid))]
namespace XamarinNutricao.Droid
{
	public class SQLite_Droid:ISQlite
	{
		public SQLite_Droid()
		{
			
		}

		public SQLiteConnection GetConnection()
		{
			var filename = "Refeicoes.db3";
			var path = Path.Combine(System.Environment.
			  GetFolderPath(System.Environment.
			  SpecialFolder.Personal), filename);
			return new SQLiteConnection(path);
		}
	}
}

