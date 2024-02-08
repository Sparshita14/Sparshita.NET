using System;
using System.Text.Json;

namespace SerializeBasic
{
    public class Student
    {
        public int rollNo { get; set; }
        public string name { get; set; }
        
    }

    public class Program
    {
        public static void Main()
        {
            var stud = new Student
            {
                rollNo = 25,
                name = "hello"
            };

            string jsonString = JsonSerializer.Serialize(stud);

            Console.WriteLine(jsonString);
            Console.ReadLine(); 
        }
    }
}
