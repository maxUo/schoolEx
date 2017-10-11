using System;

namespace InheritanceExample
{
    public class Father : People
    {
        public Father(int age, string name, string lastName) 
            : base(age, name, lastName)
        {
            Console.WriteLine(Age);
        }

        /*public override string PrintInformation()
        {

            string res = "I am your Father!";
            return res;
            //return base.PrintInformation();
        }*/
    }
}