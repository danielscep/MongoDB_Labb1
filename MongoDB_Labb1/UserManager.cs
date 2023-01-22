using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Labb1;

public static class UserManager
{
    public static BsonObjectId CurrenUserID { get; private set; }

    public static bool SignIn(IMongoCollection<Users> database ,string email, string password)
    {
        var results = database.Find(x => x.email == email.ToLower() && x.password == password).ToList();
        if (results.Count() == 0)
            return false;

        CurrenUserID = results[0]._id;
        Console.WriteLine(results[0].name);

        return true;
    }
}