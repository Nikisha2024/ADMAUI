using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletManager.Database
{
    public class Appdbcontext
    {
        public SQLiteAsyncConnection _dbconnection;
        public readonly static string nameSpace = "WalletManager.Database.";
        public const string DatabaseFileName = "WalletManager.Database.db3";
        public static string databasePath => Path.Combine(FileSystem.AppDataDirectory, DatabaseFileName);
        public const SQLite.SQLiteOpenFlags FLags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public Appdbcontext()
        {
            if (_dbconnection == null)
            {
                _dbconnection = new SQLiteAsyncConnection(databasePath, FLags);
                _dbconnection.CreateTableAsync<Debit>();
                _dbconnection.CreateTableAsync<Credit>();
                _dbconnection.CreateTableAsync<Currency>();
                _dbconnection.CreateTableAsync<Tag>();
                _dbconnection.CreateTableAsync<Transaction>();
                _dbconnection.CreateTableAsync<User>();
                _dbconnection.CreateTableAsync<UserFile>();
                _dbconnection.CreateTableAsync<Debit>();
           
            
            }

        }
        public async Task<int> CreateAsync<TEntity>(TEntity entity) where TEntity : class
        {
            return await _dbconnection.InsertAsync(entity);
        }

        public async Task<int> UpdatesAsync<TEntity>(TEntity entity) where TEntity : class
        {
            return await _dbconnection.UpdateAsync(entity);
        }

        public async Task<int> DeletesAsync<TEntity>(TEntity entity) where TEntity : class
        {
            return await _dbconnection.DeleteAsync(entity);
        }

        public async Task<int> AddorUpdateAsync<TEntity>(TEntity entity) where TEntity : class
        {
            return await _dbconnection.InsertOrReplaceAsync(entity);
        }
        public List<T> GetTableRows<T>(string tableName) where T : class
        {
            object[] onj = new object[] { };
            TableMapping map = new TableMapping(Type.GetType(nameSpace + tableName));
            string query = "SELECT * FROM [" + tableName + "]";
            return _dbconnection.QueryAsync(map, query, onj).Result.Cast<T>().ToList();
        }

        public object GetTableRow(string tableName, string column, string value)
        {
            object[] onj = new object[] { };
            TableMapping map = new TableMapping(Type.GetType(nameSpace + tableName));
            string query = $"SELECT * FROM [{tableName}] WHERE {column} = '{value}'";
            return _dbconnection.QueryAsync(map, query, onj).Result.FirstOrDefault();
        }

    }
}
