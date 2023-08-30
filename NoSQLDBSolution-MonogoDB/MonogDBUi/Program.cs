using Microsoft.Extensions.Configuration;

namespace MongoDBUI;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static void InitializeConfiguration(string connectionStringName)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
        var config  = builder.Build();
        config.GetConnectionString(connectionStringName);
    }
}