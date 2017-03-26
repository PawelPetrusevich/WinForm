using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2_ListBox
{
    [Serializable]
    class Person
    {

        string name;
        string lastName;
        string fatherName;
        string number;

#region property
        public string Name
        {
          get { return name; }
          set { name = value; }
        }

        public string LastName
        {
          get { return lastName; }
          set { lastName = value; }
        }
        
        public string FatherName
        {
          get { return fatherName; }
          set { fatherName = value; }
        }
        
        public string Number
        {
          get { return number; }
          set { number = value; }
        }
#endregion  
        public Person(string name, string lastName, string faterName, string number)
        {
            Name = name;
            LastName = lastName;
            FatherName = faterName;
            Number = number;
        }
    }
}
