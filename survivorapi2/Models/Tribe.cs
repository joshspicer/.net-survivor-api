using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace survivorapi2.Models
{
    public class Tribe
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Color { get; set; }


        // Members of the tribe
        public Player[] players { get; set; }

    }
}