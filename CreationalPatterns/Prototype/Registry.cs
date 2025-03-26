using CreationalPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Prototype
{
    internal class Registry
    {
        Dictionary<Groups, IProtoType> Types = new Dictionary<Groups, IProtoType>();
        public Registry()
        {
            PhoneContact Phone = new PhoneContact(string.Empty, string.Empty, Groups.Family);
            Phone.AddColor("Red");
            Phone.AddRington("Destiny");
            Phone.AddEmail(string.Empty);
            Phone.AddBirthday(string.Empty);
            Types.Add(Groups.Family, Phone);
            PhoneContact Phone2 = new PhoneContact(string.Empty, string.Empty, Groups.Work);
            Phone2.AddColor("Blue");
            Phone2.AddRington("Brookiii");
            Phone2.AddEmail(string.Empty);
            Types.Add(Groups.Work, Phone2);
            PhoneContact Phone3 = new PhoneContact(string.Empty, string.Empty, Groups.Friends);
            Phone3.AddColor("Yellow");
            Phone3.AddRington("Elvesssssssss");
            Phone3.AddBirthday(string.Empty);
            Types.Add(Groups.Friends, Phone3);

        }
        public IProtoType GetType(Groups type)
        {
            ColorPrinting.Printer.Print("created by protoType", (PhoneContact)Types[type]);
            return Types[type].Clone();
        }
    }
}
