using Microsoft.AspNetCore.Mvc;
using Sprint13_Views.Models;

namespace Sprint13_Views.Controllers
{
    public class TasksController : Controller
    {
		public IActionResult Greetings()
		{
			ViewBag.Value = "C# Marathon!";
			ViewBag.Greeting = "Welcome to our project!";
			return View();
		}

		public IActionResult SuperMarkets()
		{
			return View();
		}

		public IActionResult ProductInfo()
        {
			return View();
        }

		public IActionResult ShoppingList()
		{
			List<Product> products = new List<Product>()
			{
				new Product { Name = "Milk", Quantity=2 },
				new Product { Name = "Bread", Quantity=2 },
				new Product { Name = "Cake", Quantity=1 },
				new Product { Name = "Ice Cream", Quantity=5 },
				new Product { Name = "Cola", Quantity=10 }
			};

			Dictionary<string, int> productsDictionary;
			ViewBag.productsDictionary = products.ToDictionary(p => p.Name, p => p.Quantity);
			return View();
		}
        public IActionResult ShoppingCart()
        {
            ViewBag.superMarkets = new List<SuperMarkets>()
			{
				new SuperMarkets{ Name = "WellMart"},
                new SuperMarkets{ Name = "Silpo"},
                new SuperMarkets{ Name = "ATB"},
                new SuperMarkets{ Name = "Furshet"},
                new SuperMarkets{ Name = "Metro"}
            };

			List<Product> products = new List<Product>()
			{
				new Product { Name = "Bread", Price=10 },
                new Product { Name = "Milk", Price=11 },
                new Product { Name = "Cheese", Price=140 },
                new Product { Name = "Sausage", Price=110 },
                new Product { Name = "Potato", Price=7 },
                new Product { Name = "Banana", Price=23 },
                new Product { Name = "Tomato", Price=25 },
                new Product { Name = "Candy", Price=75 }
            };

            Dictionary<string, int> productsDictionary;
            ViewBag.products = products.ToDictionary(p => p.Name, p => p.Price);
            return View();
        }
    }
}
