using ShoesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesShop.Controllers.API
{
    public class SportShoeController : Controller
    {
        SportShoe[] arrayOfShoes = new SportShoe[]{
        new SportShoe(0,"nike","air",37,350),
        new SportShoe(1,"balnciaga","nfdk",41,450),
        new SportShoe(2,"jorden","rghy56",36,400),
        new SportShoe(3,"kljhj","fhtf3",42,250)

        };
        public ActionResult Showbrand()
        {
           
                ViewBag.firstBrand = arrayOfShoes[0].brand;
                return View();
        }

       
        public ActionResult ShowShoe(int id)
        {
            foreach (SportShoe item in arrayOfShoes)
            {
                if (id == item.id)
                {
                    ViewBag.shoe = item;
                }
            }
            return View(ViewBag.shoe);
        }

       
        public ActionResult ShowAllShoes()
        {

            return View(arrayOfShoes);
        }

     
    }
}
