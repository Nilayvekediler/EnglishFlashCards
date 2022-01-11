using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishFlashCardsWeb.Models
{
    public class CardSetManager
    {
        Context c = new Context();
        CardSet cardSet = null;

        public CardSetManager()
        {

        }

        public CardSetManager(CardSet cardSet)
        {
            this.cardSet = cardSet;
        }

        public void addCart(CardSet cardSet)
        {
            try
            {
                using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "Insert into CARDSETS(SETNAME,CARDUSERID,FOLDERID)" +
                            "Values" +
                            "(:1,:2,:3)";


                        cmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, cardSet.setName, ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("2", OracleDbType.Int32, cardSet.cardSetUserID, ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("3", OracleDbType.Int32, cardSet.folderID, ParameterDirection.Input));
                        cmd.ExecuteNonQuery();

                    }
                }
                
            }
            catch
            {
                throw;
            }
        }

        public CardSet getSet(int id) {
            CardSet cardSet = new CardSet();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * from CARDSETS where SETID=" + id + "";
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
                        cardSet = cs;
                    }
                }
            }
            return cardSet;
        }

        public void setnameupdate(CardSet cardSet)
        {
            try
            {
                string cmdText = "Update CARDSETS Set SETNAME='" + cardSet.setName + "' where SETID=" + cardSet.setID + "";
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
        }

        public void addSet(int set_id, int folder_id)
        {
            Console.WriteLine(set_id + " -- " + folder_id);
            try
            {
                string cmdText = "Update CARDSETS Set FOLDERID='" + folder_id + "' where SETID=" + set_id + "";
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
        }

        public void removeFromFolder(int set_id)
        {
            Console.WriteLine(set_id);
            try
            {
                string cmdText = "Update CARDSETS Set FOLDERID=0 where SETID=" + set_id + "";
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

        }

        public int wordCount(int set_id)
        {
            Console.WriteLine(set_id);
            List<CardSet> cardSetList = new List<CardSet>();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * FROM FLASHCARDS WHERE CARDSETID=" + set_id + " ";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        CardSet cardSet = new CardSet();


                        cardSetList.Add(cardSet);
                    }
                }
            }
            return cardSetList.Count();
        }


    }
}
