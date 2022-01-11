using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishFlashCardsWeb.Models
{
    public class SetFolderMatchManager
    {
        SetFolderMatch setFolderMatch;
        Context c = new Context();

        public SetFolderMatchManager(SetFolderMatch setFolderMatch)
        {
            this.setFolderMatch = setFolderMatch;
        }

        public void add()
        {
            c.SetFolderMatches.Add(this.setFolderMatch);
            c.SaveChanges();
        }

        public void delete()
        {
            var match = c.SetFolderMatches.Single(b => b.setID == this.setFolderMatch.setID && b.folderID == this.setFolderMatch.folderID);
            c.SetFolderMatches.Remove(match);
            c.SaveChanges();
        }

    }
}
