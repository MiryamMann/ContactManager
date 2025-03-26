using CreationalPatterns.FactoryFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CreationalPatterns
{
    internal class ContactList
    {
        public List<ContactPerson> contactList { get; set; } = new List<ContactPerson>();
        public void AddContactPerson(ContactPerson person)
        {
            contactList.Add(person);
        }
        public void AddContactPerson(string _name, string _phoneNumber, Groups _group, Factory factory) {

            contactList.Add(factory.CreateContactPerson(_name, _phoneNumber, _group));
           
        }
        public void RemoveContactPerson(ContactPerson person) { }
        public ContactPerson findContacPersonByName(string Name) {
            ContactPerson c= contactList.Find(x => x.Name == Name);
            return c;
        }
        public ContactPerson findContacPersonByNumber(string Number)
        {
            ContactPerson c = contactList.Find(x => x.PhoneNumber == Number);
            return c;
        }
    }
}
