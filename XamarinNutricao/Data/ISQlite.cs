using System;
using SQLite;

namespace XamarinNutricao
{
	public interface ISQlite
	{
		SQLiteConnection GetConnection();
	}
}
