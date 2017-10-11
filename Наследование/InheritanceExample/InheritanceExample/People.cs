using System;
using System.Dynamic;

namespace InheritanceExample
{
    public class People
    {
        public People(int age, string name, string lastName)
        {
            Age = age;
            Name = name;
            LastName = lastName;
        }
        public virtual string PrintInformation()
        {
            string res = "Name= " + Name + " LastName=" + LastName + " Age=" + Age;
            return res;
        }
        
        public int Age { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
    }
}