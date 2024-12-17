﻿namespace admındeneme
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("phone_number")]
        public string PhoneNumber { get; set; }

        [BsonElement("isAdmin")]
        public bool IsAdmin { get; set; } = false;

        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        [BsonElement("email_verified")]
        public bool EmailVerified { get; set; } = false;

        // MongoDB'nin otomatik eklediği versiyon kontrol alanı
        [BsonElement("__v")]
        public int Version { get; set; }
    }

}