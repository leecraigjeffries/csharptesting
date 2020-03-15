using System;

namespace Practice
{
    class Person
    {
        private string _name;
        public string Name {
            get { return _name; }
            set
            {
                _name = "Hello " + value;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "Lee"
            };

            Console.WriteLine(person.Name);
        }

    }
}
