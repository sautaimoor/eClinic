using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eClinic.ViewModels
{
    public class ContactList
    {
        Clinic_DBEntities DB = new Clinic_DBEntities();

        public IEnumerable<Contact> GetContact()
        {
            IEnumerable<Contact> listContact = (from objContact in DB.Contacts
                                                select new Contact()
                                                {
                                                    Id = objContact.Id,
                                                    Name= objContact.Name
                                                }).ToList();
            return listContact;
        }
    }
}