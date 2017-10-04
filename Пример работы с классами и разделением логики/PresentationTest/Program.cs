using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
	public class Program
	{
		static void Main(string[] args){
            People t = new People(10,10);
            Console.WriteLine(t.Age);
            Console.WriteLine(t.NormalAge);
            t.Age = 15;
            t.NormalAge = 17;

            string inp = Console.ReadLine();

            var newArr = inp.Split(',',' ');
            People newt = new People(Convert.ToInt32(newArr[0]), Convert.ToInt32(newArr[1]));
            Console.ReadLine();
        }
    }
}