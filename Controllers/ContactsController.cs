using Microsoft.AspNetCore.Mvc;

namespace ExerciceContact.Controllers
{
    public class ContactsController : Controller
    {

        public IActionResult Index()
        {
            List<string> contacts = new List<string>()
            {
                "Manu",
                "Jean",
                "Meluche",
            };

            ViewData["contacts"] = contacts;

            return View();
        }

        public IActionResult Details(int id)
        {

            return View();

        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
