using System;
using AspNetCore.Identity.MongoDbCore.Infrastructure;
using AspNetCore.Identity.MongoDbCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AH.Api.Models {
    public class AgileHouseUser : MongoIdentityUser<Guid> {

        public AgileHouseUser () : base () {

        }

        [BsonElement ("TwitchStreamId")]
        public string TwitchStreamId { get; set; }

        [BsonElement ("FirstName")]
        public string FirstName { get; set; }

        [BsonElement ("LastName")]
        public string LastName { get; set; }

        [BsonElement ("Username")]
        public string Username { get; set; }

        [BsonElement ("Password")]
        public string Password { get; set; }

        [BsonElement ("Token")]
        public string Token { get; set; }

        [BsonElement ("Pieces")]
        public string[] Pieces { get; set; }

    }
}