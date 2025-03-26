using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    internal class ContactDirector
    {
        IContactBuilder ContactBuilder;

        public ContactDirector(IContactBuilder contactBuilder)
        {
            ContactBuilder=contactBuilder;
        }
        public void ChangeBuilder(IContactBuilder contactBuilder)
        {
            ContactBuilder = contactBuilder;
        }
        public ContactPerson SetContact1(string name,string phoneNumber, Groups group,string rington,string color)
        {
            ContactBuilder.Reset(name, phoneNumber, group);
            ContactBuilder.AddRington(rington);
            ContactBuilder.AddColor(color);
            return ContactBuilder.Save();
        }
        public ContactPerson SetContact2(string name, string phoneNumber, Groups group, string birthday, string email)
        {
            ContactBuilder.Reset(name, phoneNumber, group);
            ContactBuilder.AddBirthday(birthday);
            ContactBuilder.AddEmail(email);
            return ContactBuilder.Save();
        }

    }
}
