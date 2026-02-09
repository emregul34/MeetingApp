using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        // /meeting
        // /meeting oldugunu asagidaki return "meeting/index yazisindan degil, controllerin adi MeetingControllerdan anliyor"
        //public string Index()
        //{
        //    return "meeting/index";
        //}


        [HttpGet]//BUNU YAZMASAK DA BİŞEY DEĞİŞMEZ ÇÜNKÜ  ZATEN DEFAULT OLARAK GET DÖNDÜRÜR
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost] //bu kısma applydeki formu post ediyoruz. yani oraya girilen bilgileri tutan bir sayfa. parametreyi name'e göre yazıyoruz 
        public IActionResult Apply(UserInfo model)
        {
            //Console.WriteLine(Name);
            //Console.WriteLine(Phone); //girilen bilgileri konsola yazdırır.

            if (ModelState.IsValid)
            {
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
                return View("Thanks", model);
            }
            else 
            {
                return View(model);
            }
            


        }



        [HttpGet]
        public IActionResult List()
        {
            return View(Repository.Users);
        }
        

        //meeting/details/1,2...
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

    }
}
