using System;
using System.Data.Common;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using DataProviderFactory;
using System.Data.OleDb;
using System.Data.Odbc;

Console.WriteLine("Fun with Data Provider Factories\n");
var (provider, connectionString) = GetProviderFromConfiguration();
DbProviderFactory factory = GetDbProviderFactory(provider);

using (DbConnection connection = factory.CreateConnection())
{
    if (connection == null)
    {
        Console.WriteLine($"Unable to create the connection object");
        return;
    }
    Console.WriteLine($"Your connection object is a: {connection.GetType().Name}");
    connection.ConnectionString = connectionString;
    connection.Open();
    DbCommand command = factory.CreateCommand();
    if(command == null)
    {
        Console.WriteLine($"Unable to create the command object");
        return;
    }
    Console.WriteLine($"Your command object is a: {command.GetType().Name}");
    command.Connection = connection;
    command.CommandText = "SELECT i.Id, m.Name FROM Inventory i INNER JOIN Makes m on m.Id = i.MakeId";
    using (DbDataReader reader = command.ExecuteReader())
    {
        Console.WriteLine($"Your darareader object is a: {reader.GetType().Name}");
        Console.WriteLine("\n Current Inventory");
        while (reader.Read())
        {
            Console.WriteLine($"-> Car: #{reader["Id"]} is a {reader["Name"]}");
        }
    }
    Console.ReadLine();
}

static DbProviderFactory GetDbProviderFactory(DataProviderEnum provider) => provider switch
{
    DataProviderEnum.SqlServer => SqlClientFactory.Instance,
    DataProviderEnum.OleDb => OleDbFactory.Instance,
    DataProviderEnum.Odbc => OdbcFactory.Instance
};

static (DataProviderEnum Provider, string ConnectionString) GetProviderFromConfiguration()
{
    IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true)
        .Build();

    var providerName = config["ProviderName"];
    Console.WriteLine($"ProviderName from config: '{providerName}'"); // Отладка

    if (string.IsNullOrWhiteSpace(providerName))
    {
        throw new Exception("ProviderName is missing in configuration");
    }

    if (Enum.TryParse<DataProviderEnum>(providerName, out DataProviderEnum provider))
    {
        var connectionString = config[$"{providerName}:ConnectionString"];
        Console.WriteLine($"Connection string: '{connectionString}'"); // Отладка

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new Exception($"Connection string is missing for provider: {providerName}");
        }

        return (provider, connectionString);
    }
    ;

    throw new Exception($"Invalid data provider value supplied: '{providerName}'. Valid values: {string.Join(", ", Enum.GetNames(typeof(DataProviderEnum)))}");
}
