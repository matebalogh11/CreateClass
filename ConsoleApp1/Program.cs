using System;

namespace Codecool
{
    class Person
    {
        String Name { get; set; }
        DateTime BirthDate { get; set; }
        Genders Gender { get; set; }

        static void Main(string[] args)
        {

            Person person = new Person();
            person.Name = "Julie Smith";
            person.Gender = Genders.FEMALE;
            person.BirthDate = new DateTime(1983, 11, 3);

            Console.WriteLine(person.ToString());
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
