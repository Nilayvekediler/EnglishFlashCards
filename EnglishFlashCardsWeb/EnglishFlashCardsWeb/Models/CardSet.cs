using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishFlashCardsWeb.Models
{

    public class CardSet
    {
        CardSetManager csManager = new CardSetManager();

        [Key] public int setID { get; set; }
        public string setName { get; set; }

        public int cardSetUserID { get; set; }
        public int folderID { get; set; }

        public int wordCount()
        {
            return csManager.wordCount(this.setID);
        }


    }
}
