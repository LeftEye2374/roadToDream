using System;
using Microsoft.Data.SqlClient;

Console.WriteLine("Fun With Data Readers");
using (SqlConnection connection = new SqlConnection())
{
    connection.ConnectionString = @"Data Source=.,5433;User Id=sa;Password=P@ssw0rd;Initial Catalog=AutoLot";
    connection.Open();
    string sql = @"SELECT i.id, m.Name as Make, i.Color, i.PetName FROM Inventory i INNER JOIN Makes m on m.Id = i.MakeId";
    SqlCommand myCommand = new SqlCommand(sql, connection);

    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
    {
        while (myDataReader.Read())
        {
            Console.WriteLine($"-> Make: {myDataReader["Make"]}, PetName:{myDataReader["PetName"]}, Color: {myDataReader["Color"]}");
        }
    }
}
Console.ReadLine();


