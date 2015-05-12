using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqlClient_Contacts.Models
{
    public class Contact
    {
        //TODO: Fill in the contact class
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }

        public Contact() { }
        public Contact(int contactID, string name, string email, string title)
        {
            this.ContactID = contactID;
            this.Name = name;
            this.Email = email;
            this.Title = title;
        }
    }
}