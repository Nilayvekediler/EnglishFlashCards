using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishFlashCardsWeb.Models
{
    public class FolderManager
    {
        Context c = new Context();
        Folder folder = null;

        public FolderManager()
        {

        }

        public FolderManager(Folder folder)
        {
            this.folder = folder;
        }

        public List<Folder> listFolder()
        {
            List<Folder> folderList = new List<Folder>();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * FROM FOLDERS";
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
            return folderList;
        }

        public void add()
        {
            try
            {
                using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "Insert into FOLDERS(USERID,FOLDERNAME)" +
                            "Values" +
                            "(:1,:2)";

                        cmd.Parameters.Add(new OracleParameter("1", OracleDbType.Int32, folder.userID, ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, folder.folderName, ParameterDirection.Input));
                        cmd.ExecuteNonQuery();

                    }
                }
                
            }
            catch
            {
                throw;
            }
        }

        public void delete(int id)
        {
            try
            {
                string cmdText = "DELETE from FOLDERS WHERE FOLDERID  = "+id+" ";
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

            /*
            try
            {
                string cmdText = "Update CARDSETS Set FOLDERID=0 where FOLDERID=" + id + "";
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
            */





        }











        public void update(int folder_id, string folder_name)
        {

            try
            {
                string cmdText = "Update FOLDERS Set FOLDERNAME='" + folder_name + "' where FOLDERID=" + folder_id + "";
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

        public int setCount(int folder_id)
        {
            List<CardSet> cardSetList = new List<CardSet>();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * FROM CARDSETS WHERE FOLDERID="+folder_id+" ";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        CardSet cardSet = new CardSet();


                        cardSetList.Add(cardSet);
                    }
                }
            }
           return cardSetList.Count;
        }



    }
}
