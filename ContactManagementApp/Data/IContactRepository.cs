using ContactManagementApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementApp.Data
{
    public interface IContactRepository
    {
        void Save(Contact contact);
        List<Contact> GetContacts();
        Contact GetContactById(int id); 
        Contact GetContactByLocation(string location);
        void Delete(int id);
        void Edit(int id, Contact modifiedcontact);
    }
}
