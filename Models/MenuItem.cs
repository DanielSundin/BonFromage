using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BonFromage.Models
{
    public class MenuItem
    {
        public int ID { get; set; }
        [Display(Name = "Rätt")]
        public string Name { get; set; }
        [Display(Name = "Beskrivning")]
        public string Description { get; set; }
        [Display(Name = "Pris")]
         [DataType(DataType.Currency)]
         public int Price { get; set; }
    }
}