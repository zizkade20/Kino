using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WpfApp3
{
    internal class Database
    {
        private SQLiteAsyncConnection conn;
        public Database(string path)
        {
            conn = new SQLiteAsyncConnection(FileHelper.GetPath(path));
            conn.CreateIndexAsync<Avenger>().Wait();
        }
        public Task<int> SaveItemAsync(Avenger item)
        {
            return conn.InsertAsync(item);
        }
    }
}
