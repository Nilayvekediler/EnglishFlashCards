using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using EnglishFlashCardsWeb.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Oracle.ManagedDataAccess.Client;

namespace EnglishFlashCardsWeb.Models
{
    public class UserManager
    {


        User user;
        Context cnt = new Context();

        public UserManager()
        {

        }

        public UserManager(User user)
        {
            this.user = user;
        }

        public int addUser()
        {
            if ( (user.userName == null) || (user.Password == null) || (user.email == null) )
            {
                return 0;
            }
            else
            {
                try
                {
                    using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
                    {
                        using (OracleCommand cmd = new OracleCommand())
                        {
                            con.Open();
                            cmd.Connection = con;
                            cmd.CommandText = "Insert into USERS(USERNAME,EMAIL,PASSWORD)" +
                                "Values" +
                                "(:1,:2,:3)";
                            
                           
                            cmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, user.userName, ParameterDirection.Input));
                            cmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, user.email, ParameterDirection.Input));
                            cmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, user.Password, ParameterDirection.Input));
                            cmd.ExecuteNonQuery();

                        }
                    }
                    return 1;
                }
                catch
                {
                    throw;
                }
                
            }
        }

        public bool userLogin(User user_form)
        {

            User user = new User();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * from USERS where USERNAME='" + user_form.userName + "' AND PASSWORD = '"+ user_form.Password +"' ";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        User usr = new User
                        {
                            userID = Convert.ToInt32(rdr["USERID"]),

                        };
                        user = usr;
                    }
                }
            }
            if (user.userID != 0)
            {
                return true;
            }
            return false;
        }

        public int getUserID(string username)
        {
            User user = new User();
            using (OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=123;"))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * from USERS where USERNAME='" + username + "' ";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        User usr = new User
                        {
                            userID = Convert.ToInt32(rdr["USERID"]),

                        };
                        user = usr;
                    }
                }
            }
            return user.userID;
        }




    }
}
