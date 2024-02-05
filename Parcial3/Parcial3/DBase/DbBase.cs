using Parcial3.Model;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parcial3.DBase
{
	public class DbBase
	{
		public SQLiteAsyncConnection Connection { get; set; }
		public DbBase(string path)
		{
			Connection = new SQLiteAsyncConnection(path);
			Connection.CreateTableAsync<ComentariosX>().Wait();

		}
		public async Task<int> InsertItemAsync(ComentariosX item)
		{
			return await Connection.InsertAsync(item);
		}
		public async Task<List<ComentariosX>> GetItemsAsync()
		{
			return await Connection.Table<ComentariosX>().ToListAsync();
		}
	}
}
