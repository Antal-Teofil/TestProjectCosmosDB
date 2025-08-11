using System.ComponentModel;
using Microsoft.Azure.Cosmos;
using Container = Microsoft.Azure.Cosmos.Container;

namespace TestConnectionCosmos;
class Program
{
    //Basic Connection
    //Solution++
    //Solution #1
    //Solu #3
    static async Task Main()
    {
        string endpointUri = "https://localhost:8081/";
        string primaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        CosmosClient client = new CosmosClient(endpointUri, primaryKey);

        Database db = await client.CreateDatabaseIfNotExistsAsync("TestDB");
        Container container = await db.CreateContainerIfNotExistsAsync("TestContainer", "/id");

        Console.WriteLine("Connected to Cosmos DB Emulator.");
    }
}
