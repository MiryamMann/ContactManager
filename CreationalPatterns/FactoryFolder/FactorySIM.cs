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
    internal class FactorySIM : Factory
    {
        public override ContactPerson CreateContactPerson(string _name, string _phoneNumber, Groups _group)
        {
            PhoneContact simContact = new PhoneContact(_name, _phoneNumber, _group);
            ColorPrinting.Printer.Print("Created by SIM factory", simContact);
            return simContact;
        }
    }
}
