using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> 
        {
            new Student {
                Id = 1,
                FirstName = "Bobby",
                LastName = "Mahaffey"
            },
            new Student {
                Id = 2,
                FirstName = "Kristina",
                LastName = "Mahaffey"
            }
        };

        public static List<Instructor> Instructors = new List<Instructor> 
        {
            new Instructor {
                Id = 1,
                FirstName = "Professor",
                LastName = "Aden"
            },
            new Instructor {
                Id = 2,
                FirstName = "Professor",
                LastName = "Yang"
            }
        };
    }
}