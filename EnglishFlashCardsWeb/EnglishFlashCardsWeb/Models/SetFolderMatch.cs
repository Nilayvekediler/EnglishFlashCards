using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishFlashCardsWeb.Models
{
    public class SetFolderMatch
    {
        [Key] public int id { get; set; }
        public int setID { get; set; }
        public int folderID { get; set; }

        public SetFolderMatch(int setID, int folderID)
        {
            this.setID = setID;
            this.folderID = folderID;
        }

    }
}
