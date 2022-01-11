using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishFlashCardsWeb.Models
{
    
   public class FlashCard
    {

        [Key] public int cardID { get; set; }
        public String word { get; set; }
        public String meaning { get; set; }
        public String wordType { get; set; }
        public String story { get; set; }
        public int cardUserID { get; set; }
        public int CardsetID { get; set; }




    }
}
