using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class SportShoe
    {
        public int id;
        public string company;
        public string brand;
        public int size;
        public int price;

        public SportShoe(int id, string company, string brand, int size, int price)
        {
            this.id = id;
            this.company = company;
            this.brand = brand;
            this.size = size;
            this.price = price;
        }
    }
}