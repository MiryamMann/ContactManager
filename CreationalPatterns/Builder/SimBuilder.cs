using CreationalPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    internal class SimBuilder:IContactBuilder
    {
        SIMContact simContact;

        public void AddBirthday(string birthday)
        {
            simContact.AddBirthday(birthday);
            Console.WriteLine("added birthday in sim builder");
        }

        public void AddColor(string color)
        {
            simContact.AddColor(color);
            Console.WriteLine("added color in sim builder");
        }

        public void AddEmail(string email)
        {
            simContact.AddEmail(email);
            Console.WriteLine("added email in sim builder");
        }

        public void AddRington(string rington)
        {
            simContact.AddRington(rington);
            Console.WriteLine("added ringtone in sim builder");
        }
        public void Reset(string name, string phoneNumber, Groups contactType)
        {
            simContact = new SIMContact(name,phoneNumber,contactType);
        }

        public ContactPerson Save()
        {
            ColorPrinting.Printer.Print("created by sim builder", simContact);
            return simContact;
        }
    }
}
