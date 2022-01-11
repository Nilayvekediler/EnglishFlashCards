using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishFlashCardsWeb.Models
{
    public class User
    {
        [Key] public int userID { get; set; }
        public String userName { get; set; }
        public String email { get; set; }
        public String Password { get; set; }
    }
}
