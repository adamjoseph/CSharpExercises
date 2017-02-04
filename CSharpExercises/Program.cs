using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assert("HelloWorld() should return \"Hello World!\"", Exercises.HelloWorld() == "Hello World!");
            //Assert("SayHello() should return name", Exercises.SayHello("Adam") == "Hello Adam!");
            //Assert("SumNum() should return value", Exercises.SumNum(2, 4) == 6);
            //Assert("Divide() should divide two numbers", Exercises.Divide(10, 5) == 2);
            //Assert("CanOpenCheckingAccount() should return true if age > 18", Exercises.CanOpenCheckingAccount(21) == true);
            //Assert("GetFirstName() return first word of string", Exercises.GetFirstName("Rob Malarkey") == "Rob");
            //Assert("ReverseStringHard() reverses a string", Exercises.ReverseStringHard("noisiveleT") == "Television");
            //Assert("ReverseStringEasy() reverses a string", Exercises.ReverseStringEasy("noisiveleT") == "Television");
            //Assert("PrintTimesTable(9) should print correctly", Exercises.PrintTimesTable(9) == Constants.TimesTableFor9);
            //Assert("ConvertKelvinToFahrenheit should convert 273K to 32 F", Exercises.ConvertKelvinToFahrenheit(273) == 32);
            //Assert("GetAverageHard should return 5 for [5, 7, 3]", Exercises.GetAverageHard(new int[] { 5, 7, 3}) == 5);
            //Assert("GetAverageEasy should return 5 for [5, 7, 3]", Exercises.GetAverageEasy(new int[] { 5, 7, 3}) == 5);
            //Assert("DrawTriangle() should print right-triangle", Exercises.DrawTriangle(8, 5) == Constants.TriangleFor8and5);
            //Assert("GetMilesPerHour should return 100MPH for 150, 1, 30", Exercises.GetMilesPerHour(150, 1, 30, 0) == "100MPH");
            //Assert("IsVowel should return true for u", Exercises.IsVowel('u') == true);
            //Assert("IsConsonant() should retrun true for t", Exercises.IsConsonant('t') == true);
            //Assert("CollatzConjecture should return 7 for 3", Exercises.CollatzConjecture(3) == 7 );
            //Assert("GetNext7Days() should return the next 7 dates", JsonConvert.SerializeObject(Exercises.GetNext7Days(DateTime.Parse("08/22/2016"))) == JsonConvert.SerializeObject(Constants.Next7Days));
            //Assert("IsLeapYear() should return true for 2016", Exercises.IsInLeapYear(new DateTime(2016, 8, 3)) == true);


            Console.WriteLine("Press any key to exit");
            Console.ReadLine();








            //Person[] people = new Person[4];

            //people[0] = new Person { Id = 1, FirstName = "Blaine" };
            //people[1] = new Person { Id = 2, FirstName = "Cameron" };
            //people[2] = new Person { Id = 3, FirstName = "Jennifer" };
            //people[3] = new Person { Id = 4, FirstName = "Ryan" };

            //Console.WriteLine("Length of array: {0}", people.Length);

            //int id = 2;

            //// Grab the person to delete from the list
            //foreach (var person in people)
            //{
            //    if(person.Id == 2)
            //    {
            //        people.Remove(person);
            //        break;
            //    }
            //}

        }
            static void Assert(string exerciseName, bool condition)
            {
                if (condition)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"[PASS]-{exerciseName}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[FAIL] -{ exerciseName}");
                }
                Console.ForegroundColor = ConsoleColor.White;
            

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
