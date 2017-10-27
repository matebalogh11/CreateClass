using System;

namespace Codecool
{
    class Employee : Person
    {
        public int Salary { get; set; }
        public String Profession { get; set; }
        public Room Room { get; set; }

        override
            public String ToString()
        {
            return $"{base.ToString()}, Salary: {Salary}$, Profession: {Profession}, Room number: {Room.RoomNumber}";
        }

    }
}
