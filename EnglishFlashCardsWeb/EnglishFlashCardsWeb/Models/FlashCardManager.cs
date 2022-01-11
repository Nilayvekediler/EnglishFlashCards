using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishFlashCardsWeb.Models
{
    public class FlashCardManager
    {
        Context c = new Context();
        FlashCard flashCard = null;
        private readonly string _connectionString;

        public FlashCardManager()
        {

        }

        public FlashCardManager(FlashCard flashCard, IConfiguration _configuratio)
        {
            this.flashCard = flashCard;
            _connectionString = _configuratio.GetConnectionString("OracleDBConnection");
        }

        public void addFlashCard(FlashCard flashCard)
        {

            try
            {
                using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "Insert into FLASHCARDS(WORD, MEANING, WORDTYPE, STORY, CARDUSERID, CARDSETID)" +
                            "Values" +
                            "(:1,:2,:3,:4,:5,:6)";
                       
                        cmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, flashCard.word, ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, flashCard.meaning, ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, flashCard.wordType, ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("4", OracleDbType.Varchar2, flashCard.story, ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("5", OracleDbType.Int32, flashCard.cardUserID, ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("6", OracleDbType.Int32, flashCard.CardsetID, ParameterDirection.Input));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }

        }

        public void updateFlashCard(FlashCard flashCard)
        {
            try
            {
                string cmdText = "Update FLASHCARDS Set WORD='" + flashCard.word + "', MEANING='" + flashCard.meaning + "', STORY='" + flashCard.story + "' where CARDID=" + flashCard.cardID + "";
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

        public void deleteFlashCard(FlashCard flashCard)
        {
            try
            {
                string cmdText = "DELETE from FLASHCARDS WHERE CARDID  = " + flashCard.cardID + " ";
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

        public FlashCard GetFlashCard(int id)
        {
            FlashCard flashCard = new FlashCard();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * from FLASHCARDS where CARDID=" + id + "";
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
                        flashCard = fc;
                    }
                }
            }
            return flashCard;
        }

    }
}
