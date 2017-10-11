using System;
using System.Collections.Generic;

namespace InheritanceExample
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            string name = "";
            string lastName = "";
            int age = 23;
            People myNewPeople = new People(age,name,lastName);
            /*
            string toPrint = myNewFather.PrintInformation();  
            Console.WriteLine(toPrint);
            */
            Father myNewFather = new Father(age,name,lastName);
            
            string toPrint = myNewFather.PrintInformation();  
            Console.WriteLine(toPrint);
            
        }
    }
}