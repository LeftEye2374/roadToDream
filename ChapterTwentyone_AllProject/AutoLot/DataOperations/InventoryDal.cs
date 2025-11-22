using System;
using System.Collections.Generic;
using System.Data;
using AutoLot.Dal.Models;
using Microsoft.Data.SqlClient;

namespace AutoLot.Dal.DataOperations
{
    public class InventoryDal
    {
        private readonly string _connectionString;

        public InventoryDal() : this( @"Data Source=.,5433;User Id=sa;Password=P@ssw0rd;Initial Catalog=AutoLot")
        {
        }

        public InventoryDal(string connectionString) => _connectionString = connectionString; 
    }
}
