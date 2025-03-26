using CreationalPatterns.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreationalPatterns.Groups;

namespace CreationalPatterns
{
    internal class PhoneContact: ContactPerson, IProtoType
    {
        public PhoneContact(string name, string phoneNumber, Groups group) : base(name, phoneNumber, group)
        {
        }
        public PhoneContact(PhoneContact phoneContact) : base(phoneContact)
        {
        }
        public IProtoType Clone()
        {
            Console.WriteLine("clonning phone Contact");
            return new PhoneContact(this);
        }
    }
}
