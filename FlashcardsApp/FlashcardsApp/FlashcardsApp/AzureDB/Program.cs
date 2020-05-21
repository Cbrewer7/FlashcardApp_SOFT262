using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using FlashcardsApp.MVVM;
using FlashcardsApp.Classes;
using Newtonsoft.Json;
using FlashcardsApp.Models;

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
        private static readonly string CollectionName = "student";


        public static async Task Main(string[] args)
        {
            var p = new Program();
            await p.Start();
            

            
        }
        

         async Task Start()
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
            Console.WriteLine("Created Container: {0}\n", this.container.Id);
            //Adds records (Need to link this to creating the flashcard in the app)


            await AddNewCardRecord(new CardInfo("Title", "What are the three main sciences taught in GCSE","12"));
           
        }
     

        async Task AddNewCardRecord(CardInfo c)
        {

            

            try
            {
                ItemResponse<CardInfo> cardInfos = await this.container.ReadItemAsync<CardInfo>(c.Id, new PartitionKey(c.Title));  
                Console.WriteLine("Item in database with id: {0) already exists\n", cardInfos.Resource.Id);
            }

            catch(CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                ItemResponse<CardInfo> cardInfo = await this.container.CreateItemAsync<CardInfo>(c, new PartitionKey(c.Title));

                Console.WriteLine("Created item in database with id: {0}.\n", cardInfo.Resource.Id, cardInfo.RequestCharge);


            }

        }

    }
}
