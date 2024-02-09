using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerialDeserialFile;

namespace SerializationFile
{
    [Serializable]
    public class Student
    {
        public int rollno;
        public string name;
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.rollno = 122;
            std.name = "Testing";

            SerialDeserial serial = new SerialDeserial();
            string path = "C:\\Users\\sparshita_chowdhury\\Documents\\My GitHub\\Sparshita.NET\\Practice Coding  C#\\8th Feb\\SerialDeserialFile\\SerializationFile\\";
            serial.Serialize(path, std);
            Console.WriteLine("file created successfully");
            Console.Read();

            SerialDeserial desrial = new SerialDeserial();
            string filePath = "C:\\Users\\sparshita_chowdhury\\Documents\\My GitHub\\Sparshita.NET\\Practice Coding  C#\\8th Feb\\SerialDeserialFile\\SerializationFile\\";
            Student student= new Student();

            List<Student> stdDeserail = desrial.Deserialize<Student>(path:filePath);
            // Use the deserialized object
           foreach(Student s in stdDeserail)
            {
                Console.WriteLine($"RollNo: {s.rollno}, Name: {s.name}");
            }
           
            Console.ReadLine();
        }
    }
}
