using CreationalPatterns.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreationalPatterns.Groups;

namespace CreationalPatterns
{
    internal class SIMContact: ContactPerson, IProtoType
    {
        public override Groups Group
        {
            get { return base._group; }
            set { base._group = Groups.General; }
        }

        public SIMContact(string name, string phoneNumber, Groups group) : base(name, phoneNumber, group)
        {

            Group = Groups.General;
            AddColor("");
        }

        public SIMContact(SIMContact simContact) : base(simContact)
        {
            AddColor("");
        }

        public override void AddColor(string color)
        {
            Properties["color"] = "gray";
        }
        public IProtoType Clone()
        {
            Console.WriteLine("clonning sim Contact");
            return new SIMContact(this);
        }
    }
}
