using System;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using DataProviderFactory;

Console.WriteLine("Fun With Data Provider Factories");
var (provider, connectionString) = GetProviderFromConfiguration();
DbProviderFactory factory = GetDbProviderFactory(provider);
using (DbConnection connection = factory.CreateConnection())
{


    if(connection == null)
    {
        Console.WriteLine($"Unable to create connectino object");
        return;
    }
    Console.WriteLine($"Your connection object is a: {connection.GetType().Name}");
    connection.ConnectionString = connectionString;
    connection.Open();
    DbCommand command = factory.CreateCommand();
    if(command == null )
    {
        Console.WriteLine("Unable to create command object");
        return;
    }
    Console.WriteLine($"Your command object is a: {command.GetType().Name}");
    command.Connection = connection;
    command.CommandText = "Select i.Id, m.Name From Inventory i inner join Makes m on  m.Id= i.MakeId";
    using (DbDataReader dataReader = command.ExecuteReader())
    {
        Console.WriteLine($"Your data reader object is a: {dataReader.GetType().Name}");
        Console.WriteLine("******************Current Inventory******************");
        while (dataReader.Read())
        {
            Console.WriteLine($"--> Car #{dataReader["Id"]} is a {dataReader["Name"]}.");
        }
    }
}
Console.ReadLine();

static DbProviderFactory GetDbProviderFactory(DataProviderEnum provider) => provider switch
{
    DataProviderEnum.SqlServer => SqlClientFactory.Instance,
    DataProviderEnum.Odbc => OdbcFactory.Instance,
    DataProviderEnum.OleDb => OleDbFactory.Instance,
    _ => null
};

static (DataProviderEnum Provider, string ConnectionString)
    GetProviderFromConfiguration()
{
    IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true)
        .Build();
    var providerName = config["ProviderName"];
    if(Enum.TryParse<DataProviderEnum> (providerName, out DataProviderEnum provider))
    {
        return (provider, config[$"{providerName}:ConnectionString"]);
    };
    throw new Exception("Invalid data provider value supplied");
}