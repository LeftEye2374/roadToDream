using System;
using Microsoft.Data.SqlClient;

Console.WriteLine("Fun with readres\n");
using( SqlConnection connection = new SqlConnection())
{
    connection.ConnectionString = @"Data Source=.,5433; User Id=sa;Password=P@ssw0rd;Initial Catalog=AutoLot";
    connection.Open();
    string sql = "SELECT i.Id, m.Name AS Make, i.Color, i.Petname FROM Inventory i INNER JOIN Makes m on m.Id = i.MakeId";
    SqlCommand myCommand = new SqlCommand(sql, connection);

    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
    {
        while (myDataReader.Read())
        {
            Console.WriteLine($"-> Make: {myDataReader["Make"]}, Petname: {myDataReader["PetName"]}, Color: {myDataReader["Color"]}");
        }
    }
}
Console.ReadLine();