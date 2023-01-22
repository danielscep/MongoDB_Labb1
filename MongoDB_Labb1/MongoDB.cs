using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Labb1;

public class MongoDB
{
    public IMongoCollection<Products> products;
    public IMongoCollection<Users> users;
    public MongoDB()
    {
        var settings = MongoClientSettings.FromConnectionString("mongodb+srv://daniel:ROQ3BTuRILZnVf2o@cluster0.tqq9gkn.mongodb.net/?retryWrites=true&w=majority");
        settings.ServerApi = new ServerApi(ServerApiVersion.V1);
        var client = new MongoClient(settings);

        var database = client.GetDatabase("store");

        products = database.GetCollection<Products>("products");
        users = database.GetCollection<Users>("users");
    }
}