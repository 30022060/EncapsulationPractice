using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapQuestions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("\t***PROGRAM START***");
            Console.Write("Please enter the student's name: ");
            string name = Console.ReadLine();
            CheckString(name);
            Console.WriteLine("NAME HAS BEEN ACCEPTED.");
            Console.ReadLine();

        }

        static string CheckString(string input)
        {
            do
            {
                if (input == "" || input == null)
                {
                    Console.WriteLine("ERROR. NAME INVALID. PLEASE TRY AGAIN.");
                }
            } while (input == "");
            return input;
        }
        class Student
        {
            private string name { get; set; }
            private string email { get; set; }
            private string address { get; set; }
            private string user { get; set; }
            private string password { get; set; }
            private string academic { get; set; }
            private string emergency { get; set; }

            int[] results = new int[4];
            public int[] Results
            {
                get { return results; }
                set { results = value; }
            }

            public string StudentInfo()
            {
                double average = 0;
                foreach (int x in Results)
                    average += x;
                average = average / Results.Length;

                return $"Name: {name}\nResult 1: {Results[0]}\nResult 2:{Results[1]} \nResult 3:{Results[2]} \nResult 4:{Results[3]}\nResult Average: {average}";

            }

        }
    }
}
