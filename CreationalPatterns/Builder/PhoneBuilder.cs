using CreationalPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    internal class PhoneBuilder:IContactBuilder
    {
        PhoneContact phoneContact;

        public void AddBirthday(string birthday)
        {
            phoneContact.AddBirthday(birthday);
            Console.WriteLine("added birthday in phone builder");
        }

        public void AddColor(string color)
        {
            phoneContact.AddColor(color);
            Console.WriteLine("added color in phone builder");
        }

        public void AddEmail(string email)
        {
            phoneContact.AddEmail(email);
            Console.WriteLine("added email in phone builder");
        }

        public void AddRington(string rington)
        {
            phoneContact.AddRington(rington);
            Console.WriteLine("added ringtone in phone builder");
        }

        public void Reset(string name, string phoneNumber, Groups contactType)
        {
            phoneContact = new PhoneContact(name, phoneNumber, contactType);
        }

        public ContactPerson Save()
        {
            ColorPrinting.Printer.Print("created by phone builder", phoneContact);
            return phoneContact;
        }
    }
}
