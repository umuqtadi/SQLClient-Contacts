using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SqlClient_Contacts.Models;

namespace SqlClient_Contacts.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            //show all the contacts
            return View(ContactDataAccess.GetAllContacts());
        }

        [HttpGet]
        public ActionResult Create()
        {
            //return a blank create form
            return View(new Contact());
        }

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            //add the new contact to the database
            if (ContactDataAccess.InsertContact(contact.Name, contact.Email, contact.Title))
            {
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Error = "Failed to create new contact.  Set a breakpoint and figure out why!";
                return View(contact);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            //get the contact from the database and pass it to the view to populate the form.
            Contact contact = ContactDataAccess.GetContactById(id);
            return View(contact);
        }

        [HttpPost]
        public ActionResult Edit(int id, Contact contact)
        {
            //update the contacti in the database
            if (ContactDataAccess.UpdateContact(id, contact.Name, contact.Email, contact.Title))
            {
                return RedirectToAction("List");
            }
            else
            {
                //failed
                ViewBag.Error = "Failed to update contact.  Set a breakpoint and figure out why!";
                return View(contact);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            //delete thecontact from the database.
            if (ContactDataAccess.DeleteContact(id))
            {
                return RedirectToAction("List"); //go back to the list
            }
            else
            {
                //failed
                ViewBag.Error = "Failed to delete contact.  Set a breakpoint and figure out why!";
                return RedirectToAction("List");
            }
        }

    }
}