using EnglishFlashCardsWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishFlashCardsWeb.Controllers
{
    public class SetsController : Controller
    {
        Context c = new Context();
        
        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            UserManager um = new UserManager();
            int userID = um.getUserID(HttpContext.User.Identity.Name);

            List<CardSet> cardSetList = new List<CardSet>();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * FROM CARDSETS WHERE CARDUSERID="+userID+" ";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        CardSet cs = new CardSet
                        {
                            setID = Convert.ToInt32(rdr["SETID"]),
                            setName = rdr["SETNAME"].ToString(),
                            cardSetUserID = Convert.ToInt32(rdr["CARDUSERID"]),
                            folderID = Convert.ToInt32(rdr["FOLDERID"])

                        };

                        cardSetList.Add(cs);
                    }
                }
            }
           

            if (cardSetList.Count == 0)
                ViewBag.isthereset = 0;
            else
                ViewBag.isthereset = 1;
            return View(cardSetList);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Set(int id)
        {
            UserManager um = new UserManager();
            int userID = um.getUserID(HttpContext.User.Identity.Name);

            List<FlashCard> flashCards = new List<FlashCard>();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * FROM FLASHCARDS WHERE CARDSETID=" + id + " ";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        FlashCard fc = new FlashCard
                        {
                            cardID = Convert.ToInt32(rdr["CARDID"]),
                            word = rdr["WORD"].ToString(),
                            meaning = rdr["MEANING"].ToString(),
                            story = rdr["STORY"].ToString(),
                            cardUserID = Convert.ToInt32(rdr["CARDUSERID"]),
                            CardsetID = Convert.ToInt32(rdr["CARDSETID"])

                        };

                        flashCards.Add(fc);
                    }
                }
            }

            if (flashCards.Count == 0)
                ViewBag.istherecard = 0;
            else
                ViewBag.istherecard = 1;
            CardSetManager csManager = new CardSetManager();
            ViewBag.setID = id;
            ViewBag.setName = csManager.getSet(id).setName;
            dynamic mymodel = new ExpandoObject();
            mymodel.flashCards = flashCards;
            List<Folder> folders = new List<Folder>();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * FROM FOLDERS WHERE USERID="+userID+" ";
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
            mymodel.folders = folders;
            return View(mymodel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Set(int id, string word, string meaning, int card_id, string word_scenario)
        {
            if (card_id == 0) {
                CardSetManager csManager = new CardSetManager();
                UserManager um = new UserManager();
                int userID = um.getUserID(HttpContext.User.Identity.Name);
                int Setid = id;
                FlashCard flashCard = new FlashCard();
                flashCard.word = word;
                flashCard.meaning = meaning;
                flashCard.CardsetID = Setid;
                flashCard.cardUserID = userID;
                flashCard.story = word_scenario;
                FlashCardManager fcManager = new FlashCardManager();
                fcManager.addFlashCard(flashCard);

                List<FlashCard> flashCards = new List<FlashCard>();
                using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
                {
                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * FROM FLASHCARDS WHERE CARDSETID=" + Setid + " ";
                        OracleDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            FlashCard fc = new FlashCard
                            {
                                cardID = Convert.ToInt32(rdr["CARDID"]),
                                word = rdr["WORD"].ToString(),
                                meaning = rdr["MEANING"].ToString(),
                                story = rdr["STORY"].ToString(),
                                cardUserID = Convert.ToInt32(rdr["CARDUSERID"]),
                                CardsetID = Convert.ToInt32(rdr["CARDSETID"])

                            };

                            flashCards.Add(fc);
                        }
                    }
                }

                if (flashCards.Count == 0)
                    ViewBag.istherecard = 0;
                else
                    ViewBag.istherecard = 1;
                

                ViewBag.setID = Setid;
                ViewBag.setName = csManager.getSet(id).setName;
                dynamic mymodel = new ExpandoObject();
                mymodel.flashCards = flashCards;

                List<Folder> folders = new List<Folder>();
                using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
                {
                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * FROM FOLDERS WHERE USERID = " + userID + " ";
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

                mymodel.folders = folders;
                Console.WriteLine("23232323");
                return View(mymodel);

            } else
            {
                UserManager um = new UserManager();
                int userID = um.getUserID(HttpContext.User.Identity.Name);
                int Setid = id;
                CardSetManager csManager = new CardSetManager();
                FlashCard flashCard = new FlashCard();
                flashCard.word = word;
                flashCard.meaning = meaning;
                flashCard.cardID = card_id;
                FlashCardManager fcManager = new FlashCardManager();
                //fcManager.updateFlashCard(flashCard);

                List<FlashCard> flashCards = new List<FlashCard>();
                using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
                {
                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * FROM FLASHCARDS WHERE CARDSETID=" + Setid + " ";
                        OracleDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            FlashCard fc = new FlashCard
                            {
                                cardID = Convert.ToInt32(rdr["CARDID"]),
                                word = rdr["WORD"].ToString(),
                                meaning = rdr["MEANING"].ToString(),
                                story = rdr["STORY"].ToString(),
                                cardUserID = Convert.ToInt32(rdr["CARDUSERID"]),
                                CardsetID = Convert.ToInt32(rdr["CARDSETID"])

                            };

                            flashCards.Add(fc);
                        }
                    }
                }

                if (flashCards.Count == 0)
                    ViewBag.istherecard = 0;
                else
                    ViewBag.istherecard = 1;

                ViewBag.setID = Setid;
                ViewBag.setName = csManager.getSet(id).setName;
                dynamic mymodel = new ExpandoObject();
                mymodel.flashCards = flashCards;

                List<Folder> folderList = new List<Folder>();
                using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
                {
                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * FROM FOLDERS WHERE USERID = " + userID + " ";
                        OracleDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Folder folder = new Folder
                            {
                                folderName = rdr["FOLDERNAME"].ToString(),
                                folderID = Convert.ToInt32(rdr["FOLDERID"]),
                                userID = Convert.ToInt32(rdr["USERID"])
                            };
                            
                            folderList.Add(folder);
                        }
                    }
                }

                mymodel.folders = folderList;
                Console.WriteLine("23232323");
                return View(mymodel);
            }
 
        }



        ///////////////////////////////////////////////////////////////////////////

        [HttpPost]
        [Authorize]
        public IActionResult Index(string set_name)
        {
            UserManager um = new UserManager();
            int userID = um.getUserID(HttpContext.User.Identity.Name);
            CardSet cardSet = new CardSet();
            cardSet.setName = set_name;
            cardSet.cardSetUserID = userID;
            CardSetManager cardSetManager = new CardSetManager();
            cardSetManager.addCart(cardSet);

            List<CardSet> sets = new List<CardSet>();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * FROM CARDSETS WHERE CARDUSERID=" + userID + " ";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        CardSet cs = new CardSet
                        {
                            setID = Convert.ToInt32(rdr["SETID"]),
                            setName = rdr["SETNAME"].ToString(),
                            cardSetUserID = Convert.ToInt32(rdr["CARDUSERID"]),
                            folderID = Convert.ToInt32(rdr["FOLDERID"])

                        };

                        sets.Add(cs);
                    }
                }
            }

          
            if (sets.Count == 0)
                ViewBag.isthereset = 0;
            else
                ViewBag.isthereset = 1;
            return View(sets);
        }


        [Authorize]
        public IActionResult studyMode(int id)
        {
            List<FlashCard> x = new List<FlashCard>();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * FROM FLASHCARDS WHERE CARDSETID=" + id + " ";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        FlashCard fc = new FlashCard
                        {
                            cardID = Convert.ToInt32(rdr["CARDID"]),
                            word = rdr["WORD"].ToString(),
                            meaning = rdr["MEANING"].ToString(),
                            story = rdr["STORY"].ToString(),
                            cardUserID = Convert.ToInt32(rdr["CARDUSERID"]),
                            CardsetID = Convert.ToInt32(rdr["CARDSETID"])

                        };

                        x.Add(fc);
                    }
                }
            }

            ViewBag.setID = id;
            return View(x);

        }

       

        [Authorize]
        public IActionResult setnameupdate(string set_name, int set_id)
        {
            CardSetManager csManager = new CardSetManager();
            CardSet cs = new CardSet();
            cs.setID = set_id;
            cs.setName = set_name;
            csManager.setnameupdate(cs);
            return RedirectToAction("set", "sets", new { id = cs.setID });
        }

        [Authorize]
        public IActionResult setdelete(int id)
        {
            try
            {
                string cmdText = "DELETE from CARDSETS WHERE SETID  = " + id + " ";
                using (OracleConnection conn = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
                using (OracleCommand cmd = new OracleCommand(cmdText, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }

            try
            {
                string cmdText = "DELETE from FLASHCARDS WHERE CARDSETID  = " + id + " ";
                using (OracleConnection conn = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
                using (OracleCommand cmd = new OracleCommand(cmdText, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }



            return RedirectToAction("","sets");
        }

        public IActionResult setAddFolder(int set_id, int folder_id) {
            Console.WriteLine("FOLDERID : " + folder_id);
            CardSetManager cardSetManager = new CardSetManager();
            cardSetManager.addSet(set_id, folder_id);
            return RedirectToAction("set", "sets", new { id = set_id});
        }

        public IActionResult removeFromFolder(int set_id, int folder_id)
        {
            CardSetManager cardSetManager = new CardSetManager();
            cardSetManager.removeFromFolder(set_id);
            return RedirectToAction("folder", "folders", new { id = folder_id });
        }

    }
}
