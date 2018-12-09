using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataAccess.DbContexts
{
    public class MongoContext
    {
        public IMongoDatabase Database;

        public MongoContext()
        {
            var mongoConStr = ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString;
            var dbName = MongoUrl.Create(mongoConStr).DatabaseName;
            var client = new MongoClient(ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString);
            Database = client.GetDatabase(dbName);
        }

        public IMongoCollection<BsonDocument> MfraModelCollection()
        {
            return Database.GetCollection<BsonDocument>(ConfigurationManager.ConnectionStrings["MfraModelCollection"].ConnectionString);
        }

        
        public IMongoCollection<BsonDocument> MfraOrgCollection()
        {
            return Database.GetCollection<BsonDocument>(ConfigurationManager.ConnectionStrings["MfraOrgCollection"].ConnectionString);
        }
        
    }
}
