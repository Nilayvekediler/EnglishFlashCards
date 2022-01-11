using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishFlashCardsWeb.Models
{
    public class Folder
    {
        FolderManager fManager = new FolderManager();

        [Key] public int folderID { get; set; }
        public int userID { get; set; }
        public String folderName { get; set; }

        public int setCount()
        {
            return fManager.setCount(this.folderID);
        }

    }
}
