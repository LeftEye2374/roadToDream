using System;
using System.Collections.Generic;
using System.Data;
using AutoLot.Dal.Models;
using Microsoft.Data.SqlClient;

namespace AutoLot.Dal.DataOperations
{
    public class InventoryDal : IDisposable
    {
        private SqlConnection _sqlConnectoin = null;
        bool _disposed = false;

        private readonly string _connectionString;

        public InventoryDal() : this(@"Data Source=.,5433; User Id=sa; Password=P@ssw0rd;Initial Catolog=AutoLot")
        {
        }
        public InventoryDal(string connectionString) => _connectionString= connectionString;

        private void OpenConnection()
        {
            _sqlConnectoin = new SqlConnection()
            {
                ConnectionString = _connectionString
            };
            _sqlConnectoin.Open();
        } 

        private void CloseConnection()
        {
            if (_sqlConnectoin?.State != ConnectionState.Open)
            {
                _sqlConnectoin?.Close();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if(disposing)
            {
                _sqlConnectoin.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
