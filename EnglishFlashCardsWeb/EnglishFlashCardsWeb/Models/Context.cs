using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishFlashCardsWeb.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EnglishFlashCards-2;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<CardSet> CardSets { get; set; }
        public DbSet<FlashCard> FlashCards { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SetFolderMatch> SetFolderMatches { get; set; }
    }
}
