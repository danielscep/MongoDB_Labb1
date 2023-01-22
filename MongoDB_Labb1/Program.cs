using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoDB store = new MongoDB();

            //var product1 = new BsonDocument { { "name", "Product 1" }, { "price", 10.99 } };
            //store.products.InsertOne(product1);

            //var user = new users { name = "daniel", email = "daniel.scep@gmail.com", password = "qwerty"};
            //store.users.InsertOne(user);

            var allProducts = store.products.Find(_ => true).ToList();
            foreach (var product in allProducts)
            {
                Console.WriteLine(product.name);
                Console.WriteLine(product.price);

            }


        }
    }
}