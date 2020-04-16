using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;

namespace AzureDB
{
    class Program
    {       

        private static readonly string endPointUri = "https://ckgussin.documents.azure.com:443/";

        private static readonly string PrimaryKey = "9tPlkGpHZBGXov6kIEJRaFdZTaN0uIKqhKINIsICv7pNUr2CGY6UrXoJPu8Oj7QzaCEyJximAanmQdio5tnGkg==";

        private CosmosClient cosmosClient;

        private Database database;

        private Container container;

        private string databaseName = "flashCardsDB";
        private string containerId = "Items";

        public static async Task Main(string[] args)
        {
            var p = new Program();
            await p.Start();

        
        }
        

        public async Task Start()
        {
            this.cosmosClient = new CosmosClient(endPointUri, PrimaryKey, new CosmosClientOptions()
            {
                ApplicationName = "Subjects of FlashCards"

            });

            //Creates a new database within Azure server
            this.database = await this.cosmosClient.CreateDatabaseIfNotExistsAsync(databaseName);
            Console.WriteLine("Created the database: {0}\n", this.database.Id);

            //Creates Container
            this.container = await this.database.CreateContainerIfNotExistsAsync(containerId, "/Topics", 400);

            //Adds records (Need to link this to creating the flashcard in the app)
           
        }

    }
}
