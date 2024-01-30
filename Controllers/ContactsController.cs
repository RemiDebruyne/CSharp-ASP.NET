using ExerciceContact.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExerciceContact.Controllers
{
    public class ContactsController : Controller
    {

        public IActionResult Index()
        {
            List<Contact> contacts = new List<Contact>()
            {
                new Contact(1, "jean", "bon","05 02 03 04 05"),
                new Contact(2, "Manu", "max","07 49 35 84 62"),
                new Contact(3, "Guigui", "Saur","07 12 54 30 83"),
                new Contact(4, "Remi", "Deb","04 86 54 32 48"),
            };

            //ViewData["contacts"] = contacts;

            //ViewBag.Contacts = contacts;

            return View(contacts);
        }

        public IActionResult Details(int id)
        {
            List<Contact> contacts = new List<Contact>()
            {
                new Contact(1, "jean", "bon","05 02 03 04 05"),
                new Contact(2, "Manu", "max","07 49 35 84 62"),
                new Contact(3, "Guigui", "Saur","07 12 54 30 83"),
                new Contact(4, "Remi", "Deb","04 86 54 32 48"),
            };

            Contact contactFind = contacts.FirstOrDefault(c => c.Id == id);

            return View(contactFind);

        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
