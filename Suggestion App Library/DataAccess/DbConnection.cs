using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Suggestion_App_Library.DataAccess
{
    public class DbConnection
    {
        private readonly IConfiguration config;
        private readonly IMongoDatabase db;
        private string connectionId = "MongoDB";
        public string DbName { get; private set; }
        public string CategoryCollectionName { get; private set; } = "categories";
        public string StatusCollectionName { get; private set; } = "statuses";
        public string UserCollectionName { get; private set; } = "users";
        public string SuggestionCollectionName { get; private set; } = "suggestions";

        public MongoClient Client { get; private set; }
        public IMongoCollection<CategoryModel> CategoryCollection { get; private set; }
        public IMongoCollection<StatusModel> StatusCollection { get; private set; }
        public IMongoCollection<UserModel> UserCollection { get; private set; }
        public IMongoCollection<SuggestionModel> SuggestionCollection { get; private set; }

        public DbConnection(IConfiguration config)
        {
            this.config = config;
            Client = new MongoClient(config.GetConnectionString(connectionId));
            DbName = this.config["DatabaseName"];
            db = Client.GetDatabase(DbName);

            CategoryCollection = db.GetCollection<CategoryModel>(CategoryCollectionName);
            StatusCollection = db.GetCollection<StatusModel>(StatusCollectionName);
            UserCollection = db.GetCollection<UserModel>(UserCollectionName);
            SuggestionCollection = db.GetCollection<SuggestionModel>(SuggestionCollectionName);
        }
    }
}
