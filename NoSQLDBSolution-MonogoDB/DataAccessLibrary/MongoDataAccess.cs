using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class MongoDataAccess
    {
        /*
         * Dont Forget !!
        NOTE: A DATABASE IS A COLLECTION OF TABLES FOR NOSQL OR SQL 
        IN MONGODB COLLECTION = TABLE = COLLECTION
         */
        public IMongoDatabase db;
        public MongoDataAccess(string dbName, string connectionString)
        {
            var client = new MongoClient(connectionString); // Connection to cluster 
            db = client.GetDatabase(dbName); // Connection to db 
        }

        public void InsertRecord<T>(string table, T record)
        {
            // A Databas is a collection of tables 
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordById<T> (string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            return collection.Find(filter).First();
        }

        // Upsert means if it already exist itll create it if it doesnt exist it will create it 
        public void UpsertRecord<T>(string table, Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);
            
            //var result = collection.ReplaceOne(
            //    new BsonDocument("_id", id),
            //    record,
            //    new UpdateOptions { IsUpsert = true });

            var result = collection.ReplaceOne(
             new BsonDocument("_id", id),
             record,
            new ReplaceOptions { IsUpsert = true });
        }

        public void DeleteRecord<T> (string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}
