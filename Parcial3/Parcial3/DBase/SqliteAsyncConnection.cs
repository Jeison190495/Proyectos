using Parcial3.Model;
using System;
using System.Threading.Tasks;

namespace Parcial3.DBase
{
    public class SqliteAsyncConnection
    {
        private string path;

        public SqliteAsyncConnection(string path)
        {
            this.path = path;
        }

        internal object CreateTableAsync<T>()
        {
            throw new NotImplementedException();
        }

        internal Task<int> InsertAsync(ComentariosX item)
        {
            throw new NotImplementedException();
        }
    }
}