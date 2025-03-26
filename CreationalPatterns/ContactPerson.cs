using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    internal abstract class ContactPerson
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        protected Groups _group;
        public virtual Groups Group
        {
            get { return _group; }
            set { _group = value; }
        }
        public Dictionary<string, string> Properties { get; private set; } = new Dictionary<string, string>();

        public ContactPerson(string name, string phoneNumber, Groups group)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Group = group;
        }

        public ContactPerson(ContactPerson contact)
        {
            Name = contact.Name;
            PhoneNumber = contact.PhoneNumber;
            Properties = contact.Properties;
            Group = contact.Group;
        }

        public virtual void AddColor(string color)
        {
            Properties["Color"] = color; 
        }

        public void AddEmail(string email)
        {
            Properties["Email"] = email; 
        }

        public virtual void AddBirthday(string birthday)
        {
            Properties["Birthday"] = birthday; 
        }

        public virtual void AddRington(string rington)
        {
            Properties["Sound"] = rington; 
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"{"Name",-15}: {Name,-15}");
            foreach (var item in Properties)
            {
                output.AppendLine($"{item.Key,-15}: {item.Value,-15}");
            }
            return output.ToString();
        }
    }
}