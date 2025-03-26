using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    internal interface IContactBuilder
    {
           
        public void Reset(string name,string phoneNumber, Groups group);
        public void AddColor(string color);
        public void AddEmail(string email);
        public void AddBirthday(string birthday);
        public void AddRington(string rington);
        public ContactPerson Save();
      
    }
}
