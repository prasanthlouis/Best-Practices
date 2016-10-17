using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wrong way
            Console.WriteLine(StringExtensions.ConvertToCapitalCase("hello there!"));
            var exp = "hello there!";
            Console.WriteLine(exp.ConvertToCapitalCase());
            Console.ReadLine();

            var person = new List<Person>()
            {
                new Person() {HasGlasses = true, Name = "Prasanth"},
                new Person() {HasGlasses = true, Name = "Nelson"},
                new Person() {HasGlasses = false, Name = "Mike"}
            };

            var personAge = new List<PersonAge>()
            {
                new PersonAge() {HasGlasses = true, Age = 23, Name = "Prasanth"},
                new PersonAge() {HasGlasses = true, Age = 20, Name = "Nelson"},
                new PersonAge() {HasGlasses = false, Age = 25, Name = "Mike"}
            };

            var query1 = person.Join(personAge, p => p.Name, pa => pa.Name,
                (p, pa) => new
                {
                    Name = p.Name,
                    HasGlasses = p.HasGlasses,
                    Age = pa.Age
                });
            foreach (var quer in query1)
            {
                Console.WriteLine($"Name: {quer.Name} Age: {quer.Age} HasGlasses: {quer.HasGlasses}");             
            }

            Console.ReadLine();
        }
    }

    public class PersonAge
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool HasGlasses { get; set; }

    }

    public class Person
    {
        public string Name { get; set; }

        public bool HasGlasses { get; set; }

    }

}
