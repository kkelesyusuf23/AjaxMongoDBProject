﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AjaxMongoDBProject.DAL.Entities
{
	public class Product
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProducStock { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal ProducPrice { get; set; }
        public string CategoryID { get; set; }
    }
}
