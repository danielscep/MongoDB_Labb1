using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace MongoDB_Labb1;

public class Products
{
    [BsonId]
    public ObjectId _id { get; set; }
    [Required]
    public string name { get; set; }
    [Required]
    public double price { get; set; }


}