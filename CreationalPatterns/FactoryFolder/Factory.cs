using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreationalPatterns.Groups;

namespace CreationalPatterns.FactoryFolder
{
    internal abstract class Factory
    {
        public abstract ContactPerson CreateContactPerson(string _name, string _phoneNumber, Groups _group);
        
    }
}
