using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace survivorapi2.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Year { get; set; }
        public string Major { get; set; }
        public string Hometown { get; set; }

    }
}