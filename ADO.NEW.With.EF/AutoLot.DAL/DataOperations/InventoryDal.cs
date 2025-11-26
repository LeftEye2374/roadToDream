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


        public List<CarViewModel> GetAllInventory()
        {
            OpenConnection();
            List<CarViewModel> inventory = new List<CarViewModel>();
            string sql = @"SELECT i.Id, i.Color, i.PetName, m.Name AS Make FROM INventory i INNER JOIN Makes m on m.Id = i.MakeId";
            using SqlCommand command = new SqlCommand(sql, _sqlConnectoin)
            {
                CommandType = CommandType.Text
            };
            command.CommandType = CommandType.Text;
            SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (dataReader.Read()) 
            {
                inventory.Add(new CarViewModel
                {
                    Id = (int)dataReader["Id"],
                    Color = (string)dataReader["Color"],
                    Make = (string)dataReader["Make"],
                    PetName = (string)dataReader["PetName"]
                });
            }
            dataReader.Close();
            return inventory;
        }
    }
}
