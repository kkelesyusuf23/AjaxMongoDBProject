using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AjaxMongoDBProject.DAL.Entities
{
	public class Category
	{
        [BsonId] // ıd olduğunu belirtiyor
        [BsonRepresentation(BsonType.ObjectId)] // türünü belirtiyor
        public string CategoryID { get; set; } 
        public string CategoryName { get; set; }
    }
}
