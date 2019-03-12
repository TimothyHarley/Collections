using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsWithBlackHair = new List<string> {"Nathan", "Austin", "Marty McFly"};

            var studentsByHairColor = new Dictionary<string, List<string>>()
            {
                {"Black", studentsWithBlackHair }
            };

            studentsByHairColor.Add("Bald", new List<string> {"Martin"});

            var theBlackHairedStudents = studentsByHairColor["Black"];

            if (theBlackHairedStudents == studentsWithBlackHair)
            {
                Console.WriteLine("They are the same");
            }

            studentsByHairColor["Black"].Add("new person");

            foreach (var (hairColor,students) in studentsByHairColor)
            {
                Console.WriteLine($"The following students have {hairColor} hair.");

                students.Add("new person");

                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }

            Console.ReadLine();

        }
    }
}
