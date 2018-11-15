using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        static private List<Cheese> Cheeses = new List<Cheese>();

        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;

            return View();

        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            //add the new cheese to my existing cheeses
            bool contains = Cheeses.Any(item => item.Name == name);
            if (!contains)
            {
                Cheese cheese = new Cheese(name, description);
                Cheeses.Add(cheese);
            }
            //else
            //{
            //Console.WriteLine("This Cheeses is already in the list");
            //}

            return Redirect("/Cheese");
        }
        public IActionResult Delete()
        {

            ViewBag.cheeses = Cheeses;

            return View();
        }
        [HttpPost]
        [Route("/Cheese/Delete")]
        public IActionResult DeleteCheese(string[] cheese)
        {
            //delete cheeses from dictionary

            string[] deleteChoices = Request.Form["cheese"];

            foreach (string choice in deleteChoices)
            {
                Cheeses.RemoveAll(item => item.Name == choice);
            }

            return Redirect("/Cheese");
        }
    }
}