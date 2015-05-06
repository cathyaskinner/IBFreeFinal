using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IBFree.Models
{
 public enum Symptom
    {
        Bloating, Distention, Constipation, Diarrhoea, Flatulance, Other
    }
    public enum Severity
    {
        Mild, Moderate, Severe
    }
    public enum Irritants 
    {
        Fructan, Sorbitol, Mannitol, Fructose, GOS, Lactose
    }


    public class BigViewModel
    {
        [Key]
        public int ImputId { get; set; }
        public String FoodName { get; set; }
  
        public String Iritance { get; set; }
       
        public Symptom Symptoms { get; set; }
        public Severity Severity { get; set; }
    }
}