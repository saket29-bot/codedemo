using ContactManagementApp.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactManagementApp.Data
{
    public class ContactsFileRepository : IContactRepository
    {
        private readonly string file = "C:\\Users\\ADMIN\\Documents\\Contact.txt";
        public void Delete(int id)
        {
            StreamReader sr = new StreamReader(file);
            StreamWriter sw = new StreamWriter("C:\\Users\\ADMIN\\Documents\\TempContact.txt",true);
            try
            {
                while(!sr.EndOfStream)
                {
                    string sr1=sr.ReadLine();
                    string[] s=sr1.Split(',');
                    if (int.Parse(s[0])!=id)
                    {
                        sw.WriteLine(sr1); 
                    }
                }
                sw.Close();
                sr.Close();
                File.Copy("C:\\Users\\ADMIN\\Documents\\TempContact.txt", file, true);
            }
            finally { sw.Close(); sr.Close(); }
        }

        public void Edit(int id, Contact modifiedcontact)
        {
            throw new NotImplementedException();
        }

        public Contact GetContactById(int id)
        {
            StreamReader reader = new StreamReader(file);
            Contact c = new Contact();
            try
            {
                while (!reader.EndOfStream)
                {
                    string[] s = reader.ReadLine().Split(',');
                    if (id == int.Parse(s[0]))
                    {
                        c.ContactId = int.Parse(s[0]);
                        c.Name = s[1];
                        c.Mobile = s[2];
                        c.Email = s[3];
                        c.Address = s[4];
                    }
                }
            }
            finally { reader.Close(); }
            return c;
        }

        public Contact GetContactByLocation(string location)
        {
            StreamReader reader = new StreamReader(file);
            Contact c=new Contact();
            try
            {
                while(!reader.EndOfStream)
                {
                    string[] s = reader.ReadLine().Split(',');
                    if (location.CompareTo(s[4]) == 0)
                    {
                        c.ContactId = int.Parse(s[0]);
                        c.Name = s[1];
                        c.Mobile = s[2];
                        c.Email = s[3];
                        c.Address=s[4]; 
                    }
                }
            }
            finally { reader.Close(); }
            return c;
        }

        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();   
            StreamReader sr = new StreamReader(file);
            try
            {
                while(!sr.EndOfStream)
                {
                    string line=sr.ReadLine();
                    Contact c = new Contact();
                    string[] data=line.Split(',');
                    c.ContactId=int.Parse(data[0]);
                    c.Name=data[1];
                    c.Mobile = data[2];
                    c.Email = data[3];
                    c.Address=data[4];
                    contacts.Add(c);
                }
            }
            finally { sr.Close(); }
            return contacts;
        }

        public void Save(Contact contact)
        {
            string contsctCSV = $"{contact.ContactId},{contact.Name},{contact.Mobile},{contact.Email},{contact.Address}";
            StreamWriter sw = new StreamWriter(file, true);
            try
            {
                sw.WriteLine(contsctCSV);
            }
            finally { sw.Close(); }
        }
    }
}
