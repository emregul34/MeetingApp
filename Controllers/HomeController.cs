using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller 
    {
        //localhost
        //localhost/home
        //localhost/home/index
        //public string Index()
        //{
        //    return "Anasayfa";
        //}

        public IActionResult Index() //viewi dondurecek olan veri tipi iactionresulttur. view dondureceksek bu yazilir
        {
            int saat = DateTime.Now.Hour; //şuanki saat bilgisini saat değişkeninin içine saklıyoruz

            //ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "İyi Geceler"; 
            //saat 12den büyükse iyi günler değilse iyi geceler yazdır diyip viewbag sayesinde bunu home altındaki index sayfasından çağırıyoruz
            //KISACASI SAYFAYA DİNAMİK BİR KISIM EKLERKEN CONTROLLER KISMIINA GELİP BİR VİEWBAG EKLİYORUZ.
            //VİEWBAGİN ALTERNATİFİ OLARAK VİEWDATA DA KULLANILABİLİR


            ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "İyi Geceler";
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, Maslak Kültür Merkezi",
                Date = new DateTime(2026, 05, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };

            return View(meetingInfo); 
        }

       

    }
}
