using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rpn.Repository.Api;
using Dapper;
using System.Data.SQLite;

namespace Rpn.Repository.Service
{
    public class DapperContext : IDapperContext
    {
        private readonly string _providerNama;
        private readonly string _connString;
        private IDbConnection _db;

        public DapperContext()
        {
            var dbNama = System.IO.Directory.GetCurrentDirectory() + @"\\Rpn.db";
            _providerNama = "System.Data.SQLite";
            _connString = "Data Source=" + dbNama;
        }

        public IDbConnection GetOpenConn(string providerNama, string connString)
        {
            DbConnection conn = null;

            try
            {
                DbProviderFactory provider = DbProviderFactories.GetFactory(providerNama);
                conn = provider.CreateConnection();
                conn.ConnectionString = connString;
                conn.Open();
            }
            catch
            {

            }
            return conn;
        }

        public IDbConnection db
        {
            get { return _db ?? (_db = GetOpenConn(_providerNama, _connString)); }
        }


        public int GetLastId()
        {
            int lastId = 0;
            try
            {
                var sql = @"SELECT last_insert_rowid()";
                lastId = db.Query<int>(sql).Single();
            }
            catch
            {
            }
            return lastId;
        }

        public void Dispose()
        {
            if (_db != null)
            {
                try
                {
                    if (_db.State == ConnectionState.Closed)
                    {
                        _db.Close();
                    }
                }
                finally
                {
                    _db.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }

    }
}
