using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace SqlClient_Contacts.Models
{
    public class ContactDataAccess
    {
        public static bool InsertContact(string name, string email, string title)
        {
            //TODO: INSERT contact in the database
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                con.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Contacts (Name, Email, Title) Values (@name, @email, @title)", con);
                    command.Parameters.Add(new SqlParameter("name", name));
                    command.Parameters.Add(new SqlParameter("email", email));
                    command.Parameters.Add(new SqlParameter("title", title));

                    command.ExecuteNonQuery();
                    return true;
                }
                catch
                {

                    return false;
                }
            }
        }

        public static bool DeleteContact(int id)
        {
            //TODO: DELETE contact in the database by ID
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                con.Open();
                try
                {
                    SqlCommand command = new SqlCommand("DELETE FROM Contacts (ContactID) Values (@contactID)", con);
                    command.Parameters.Add(new SqlParameter("contactID", id));
                 
                    command.ExecuteNonQuery();
                    return true;
                }
                catch
                {

                    return false;
                }
            }
        }

        public static Contact GetContactById(int id)
        {
            //TODO: SELECT a contact from the database by Id
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                con.Open();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT @contactID FROM Contacts", con);
                    command.Parameters.Add(new SqlParameter("contactID", id));

                    command.ExecuteNonQuery();
                    return new Contact();
                }
                catch
                {

                    return new Contact();
                }
            }
        }

        public static List<Contact> GetAllContacts() 
        {
            //TODO: SELECT all contacts from the database
            return new List<Contact>();
        }

        public static bool UpdateContact(int id, string name, string email, string title)
        {
            //TODO: UPDATE contact in the database by Id
            return false;
        }

    }
}