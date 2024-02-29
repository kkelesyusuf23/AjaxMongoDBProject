using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AjaxMongoDBProject.DAL.Entities
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public decimal EmployeeSalary { get; set; }
    }
}
