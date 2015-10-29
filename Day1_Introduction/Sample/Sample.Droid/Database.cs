using System;
using System.IO;
using Sample.Core;
using SQLite;

namespace Sample
{
	public class Database
	{
		public Database ()
		{
		}

		public SQLiteConnection GetConnection()
		{
			var docsPath = System.Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);

			return new SQLiteConnection(Path.Combine(docsPath,"sample.db"));
		}

		public void Save()
		{
			Valuation v = new Valuation ()
			{ 
				Id = 1,
				 Price = 100,
				StockId = 2,
				Time = DateTime.Now
			};

			using (var connection = GetConnection ()) {
				connection.CreateTable<Valuation> (CreateFlags.None);

				connection.Insert (v);
				var obj = connection.Get<Valuation> (data => data.StockId = 2);

			}
		}
	}
}

