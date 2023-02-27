using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Data;

class Program
{
    static string getConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsetting.json", true, true).Build();
        var strConnection = config["ConnectionString:MyStoreDB"];
        return strConnection;
    }

    static void ViewProducts()
    {
        DbProviderFactory factory = SqlClientFactory.Instance;
        using DbConnection
    }
}