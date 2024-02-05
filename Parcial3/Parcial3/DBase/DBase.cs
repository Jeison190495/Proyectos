using System.Threading.Tasks;
using Parcial3.Model;
using Parcial3.Views;
using Parcial3.DBase;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using SQLite;

namespace Parcial3.DBase
{
    public class DBase
    {
        public SqliteAsyncConnection Connection {  get; set; }
        public DBase(string path) 
        {
            Connection = new SqliteAsyncConnection(path);
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
