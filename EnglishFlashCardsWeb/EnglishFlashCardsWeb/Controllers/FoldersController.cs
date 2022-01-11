using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnglishFlashCardsWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Oracle.ManagedDataAccess.Client;

namespace EnglishFlashCardsWeb.Controllers
{
    public class FoldersController : Controller
    {
        Context c = new Context();

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            UserManager um = new UserManager();
            int userID = um.getUserID(HttpContext.User.Identity.Name);

            List<Folder> folders = new List<Folder>();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * FROM FOLDERS WHERE USERID = "+userID+" ";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Folder folder = new Folder
                        {
                            folderName = rdr["FOLDERNAME"].ToString(),
                            folderID = Convert.ToInt32(rdr["FOLDERID"]),
                            userID = Convert.ToInt32(rdr["USERID"])

                    };

                        folders.Add(folder);
                    }
                }
            }



         
            if(folders.Count == 0)
            {
                ViewBag.istherefolder = 0;
            }else
            {
                ViewBag.istherefolder = 1;
            }
            return View(folders);
        }

        [HttpPost]
        [Authorize]
        public IActionResult add(string folder_name)
        {
            UserManager um = new UserManager();
            int userID = um.getUserID(HttpContext.User.Identity.Name);
            Folder folder = new Folder();
            folder.folderName = folder_name;
            folder.userID = userID;
            FolderManager folderManager = new FolderManager(folder);
            folderManager.add();
            return RedirectToAction("", "folders");
        }

        [Authorize]
        public IActionResult delete(int id)
        {
            FolderManager folderManager = new FolderManager();
            folderManager.delete(id);
            return RedirectToAction("", "folders");
        }



        [Authorize]
        public IActionResult folder(int id)
        {

            List<CardSet> cardSetList = new List<CardSet>();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * FROM CARDSETS WHERE FOLDERID="+id+" ";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        CardSet cardset = new CardSet
                        {
                            setID = Convert.ToInt32(rdr["SETID"]),
                            setName = rdr["SETNAME"].ToString(),
                            cardSetUserID = Convert.ToInt32(rdr["CARDUSERID"]),
                            folderID = Convert.ToInt32(rdr["FOLDERID"])
                        };

                        cardSetList.Add(cardset);
                    }
                }
            }

            var cardSets = cardSetList;
            if (cardSets.Count == 0)
            {
                ViewBag.isthereset = 0;
            }
            else
            {
                ViewBag.isthereset = 1;
            }

            try
            {
                
                using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
                {
                    var folder = new Folder();
                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * FROM FOLDERS WHERE FOLDERID=" + id + " ";
                        OracleDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {


                            folder.folderName = rdr["FOLDERNAME"].ToString();
                            folder.folderID = Convert.ToInt32(rdr["FOLDERID"]);
                            folder.userID = Convert.ToInt32(rdr["USERID"]);

                            Console.WriteLine("dadada");

                        }
                    }
                    
                    ViewBag.folderID = folder.folderID; 
                    ViewBag.folderName = folder.folderName;
                }
   
                

            }
            catch
            {
                
                return RedirectToAction("Index", "folders");
                
            }
            return View(cardSets);
        }

        [Authorize]
        public IActionResult folderNameUpdate(int folder_id, string folder_name)
        {
            FolderManager folderManager = new FolderManager();
            folderManager.update(folder_id, folder_name);
            return RedirectToAction("folder","folders", new { id = folder_id } );
        }

    }
}
