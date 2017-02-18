using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using XamarinNutricao.iOS;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace XamarinNutricao.iOS
{
	public class SQLite_IOS:ISQlite
	{
		public SQLite_IOS()
		{
		}
		public SQLiteConnection GetConnection()
		{
			var filename = "Refeicoes.db3";
			var Documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var libraryFolder= Path.Combine(Documents, "..", "Library");
			var path = Path.Combine(libraryFolder, filename);
			return new SQLiteConnection(path);

		}
	}
}
