using System;
using System.Collections.Generic;
using System.Data;
using AutoLot.Dal.Models;
using Microsoft.Data.SqlClient;

namespace AutoLot.Dal.DataOperations
{
    public class InventoryDal : IDisposable
    {
        bool _disposed = false;

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

        protected virtual void Dispose( bool disposing )
        {
            if (_disposed)
            {
                return;
            }
            if( disposing )
            {
                _sqlConnection.Dispose();
            }
            _disposed = true;
        } 

        public void Dispose()
        {
            Dispose( true );
            GC.SuppressFinalize(this);
        }

        public List<CarViewModel> GetAllInventory()
        {
            List<CarViewModel> inventory = new List<CarViewModel>();

            string sql = @"SELECT i.Id, i.Color, i.PetName, m.Name as Make FROM Inventory i INNER JOIN Makes m on m.Id";
            using SqlCommand command = new SqlCommand()
            {
                CommandType = CommandType.Text
            };
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read() )
            {
                inventory.Add(new CarViewModel
                {
                    Id = (int)reader["Id"], 
                    PetName = (string)reader["PetName"],
                    Color = (string)reader["Color"],
                    Make = (string)reader["Make"]
                });
            }
            reader.Close();
            return inventory;
        }

        public CarViewModel GetCar(int Id)
        {
            OpenConnection();
            CarViewModel car = null;

            string sql = $@"SELECT i.Id, i.Color, i.PetName, m.Name as Make FROM Inventory i INNER JOIN Makes m on m.Id = i.MakeId WHERE i.Id = {Id}";
            using SqlCommand command = new SqlCommand(sql, _sqlConnection)
            {
                CommandType = CommandType.Text
            };
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while(reader.Read())
            {
                car = new CarViewModel 
                {
                    Id = (int)reader["Id"],
                    Color = (string)reader["Color"],
                    PetName = (string)reader["PetName"],
                    Make = (string)reader["Make"]
                };
            }
            reader.Close();
            return car;
        }

        public void InserAuto(Car car)
        {
            OpenConnection();
            string sql = $@"INSERT INTO Inventory(MakeId, Color, PetName) VALUES ('{car.MakeId}', '{car.Color}', '{car.PetName}')";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public void DeleteCar(int Id)
        {
            OpenConnection();
            string sql = $@"DELETE FROM Inventory WHERE Id = '{Id}'";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                catch( SqlException ex)
                {
                    Exception error = new Exception("Error! This car is on order!", ex);
                    throw error;
                }
            }
            CloseConnection();
        }

        public void UpdatePetName(int Id, string PetName)
        {
            OpenConnection();
            string sql = $"UPDATE Inventory SET PetName = '{PetName}' WHERE Id = '{Id}' ";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }
    }
}
