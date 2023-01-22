using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace MongoDB_Labb1;

public class users
{
    [BsonId]
    public ObjectId _id { get; set; }
    [Required]
    public string name { get; set; }
    [Required, EmailAddress]
    public string email { get; set; }
    [Required]
    public string password { get; set; }
    public List<Products> shoppingCart { get; set; }
}