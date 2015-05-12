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
            return false;
        }

        public static bool DeleteContact(int id)
        {
            //TODO: DELETE contact in the database by ID
            return false;
        }

        public static Contact GetContactById(int id)
        {
            //TODO: SELECT a contact from the database by Id
            return new Contact();
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