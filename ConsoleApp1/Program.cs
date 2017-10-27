using System;

namespace Codecool
{
    class Person
    {
        public String Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }

        public static void Main(string[] args)
        {

            Person person = new Person();
            person.Name = "Julie Smith";
            person.Gender = Genders.FEMALE;
            person.BirthDate = new DateTime(1983, 11, 3);

            Employee worker = new Employee();
            worker.Salary = 1500;
            worker.Name = "Joe Fahey";
            worker.Gender = Genders.MALE;
            worker.BirthDate = new DateTime(1965, 2, 15);
            worker.Profession = "plumber";
            worker.Room = new Room(13);

            Console.WriteLine(person.ToString());
            Console.WriteLine(worker.ToString());
            Console.ReadKey();
        }

        override
            public String ToString()
        {
            return $"Name: {Name}, Birth date: {BirthDate.ToString("yyyy MM dd")}, Gender: {Gender}";
        }
    }

    enum Genders
    {
        MALE,
        FEMALE
    }
}