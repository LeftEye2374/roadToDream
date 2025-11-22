using System;
using System.Collections.Generic;
using System.Data;
using AutoLot.Dal.Models;
using Microsoft.Data.SqlClient;

namespace AutoLot.Dal.DataOperations
{
    public class InventoryDal
    {
        private SqlConnection _sqlConnection = null;

        private readonly string _connectionString;

        public InventoryDal() : this( @"Data Source=.,5433;User Id=sa;Password=P@ssw0rd;Initial Catalog=AutoLot")
        {
        }

        public InventoryDal(string connectionString) => _connectionString = connectionString;


        private void OpenConnection()
        {
            _sqlConnection = new SqlConnection
            {
                ConnectionString = _connectionString
            };
            _sqlConnection.Open();
        }

        private void CloseConnection()
        {
            if( _sqlConnection?.State != ConnectionState.Closed )
            {
                _sqlConnection?.Close();
            }
        }
    }
}
