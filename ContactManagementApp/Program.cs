using ContactManagementApp.Data;
using ContactManagementApp.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contact c = new Contact();
            c.ContactId = 12;
            c.Name = "saket";
            c.Mobile = "764545647547";
            c.Address = "jsaishdsygdsbdsaygda";
            c.Email = "wsaket29@gmail.com";
            ContactsFileRepository cfr = new ContactsFileRepository();
            //cfr.Save(c);
            Contact c1 = new Contact();
            c1.ContactId = 15;
            c1.Name = "sushant";
            c1.Mobile = "764545647547";
            c1.Address = "jsaishdsygdsbdsaygda";
            c1.Email = "wsususus29@gmail.com";
            //cfr.Save(c1);
            cfr.Delete(12);
        }
    }
}
