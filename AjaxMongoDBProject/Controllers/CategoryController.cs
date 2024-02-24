using AjaxMongoDBProject.DAL.Entities;
using AjaxMongoDBProject.DAL.Settings;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace AjaxMongoDBProject.Controllers
{
	public class CategoryController : Controller
	{
		private readonly IMongoCollection<Category> _categoryCollection;
        public CategoryController(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
        }
        public IActionResult Index()
		{
			return View();
		}
	}
}
