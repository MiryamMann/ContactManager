using CreationalPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static CreationalPatterns.Groups;

namespace CreationalPatterns.FactoryFolder
{
    internal class FactoryPhon:Factory
    {
        public override ContactPerson CreateContactPerson(string _name, string _phoneNumber, Groups _group)
        {
            ContactPerson contact = new PhoneContact(_name, _phoneNumber, _group);
            ColorPrinting.Printer.Print("Created in Phone Factory", contact);

            return contact;
        }
    }
}
