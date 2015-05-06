using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.WebPages.Html;
using System.ComponentModel.DataAnnotations.Schema;


namespace IBFree.Models
{
    public class BadFood
    {
        [Key]    
        public int Id { get; set; }
     
        [DisplayName("Food Name")]
        public string Name { get; set; }

        public bool Fructan { get; set; }

        public bool Sorbitol { get; set; }
        public bool Mannitol { get; set; }
        public bool Fructose { get; set; }
        public bool GOS { get; set; }
        public bool Lactose { get; set; }
       public bool FoodChallenge { get; set; }

        public String Image { get; set; }

        



    }
}