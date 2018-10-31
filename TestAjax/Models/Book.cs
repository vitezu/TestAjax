using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web;

namespace TestAjax.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }

   
}