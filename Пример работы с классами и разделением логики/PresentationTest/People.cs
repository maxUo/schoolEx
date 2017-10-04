using System;
namespace Presentation
{
    public class People
    {
        public int Age { get; set; }
        public int NormalAge{
            get
            {
                return _normalAge;
            }
            set
            {
                _normalAge = value;
            }
        }
        private int _normalAge;
		public int Money { get; set; }

		public People(int money, int age)
        {
            Age = age;
            _normalAge = age;
            Money = money;
        }
    }
}
