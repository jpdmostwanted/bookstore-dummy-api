using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DummyAPI.Models
{
    public class Book
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string description{ get; set; }
        public string genre { get; set; }
        public string created_date { get; set; }
    }
}