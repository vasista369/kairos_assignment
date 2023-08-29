using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ItemsApi.Models;

public class Items
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string name { get; set; } = null!;

    public string company { get; set; } = null!;
}