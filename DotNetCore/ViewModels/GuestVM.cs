using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gshahine.DotNetCore.ViewModels
{
  public class GuestVM
  {
    [BsonId]
    public ObjectId Id { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nickname { get; set; }
    public string Phonenumber { get; set; }
    public int Guests { get; set; }
    public int Priority { get; set; }
    public string Relationship { get; set; }
    public string GuestOf { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    [BsonExtraElements]
    public BsonDocument Metadata { get; set; }
  }
}
