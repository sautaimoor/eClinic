using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eClinic.ViewModels
{
    public class NewPatientVisit
    {
        public IEnumerable<Contact> Contacts { get; set; }
        public Visit Visit { get; set; }
    }
}