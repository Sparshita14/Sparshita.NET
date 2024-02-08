using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace Serialization
{
    [Serializable]
    class Student
    {
        public int rollno;
        public string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream st = new FileStream("C:\\Users\\sparshita_chowdhury\\Documents\\My GitHub\\Sparshita.NET\\Practice Coding  C#\\6th Feb\\Serialization\\Serialization\\serial.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();

            #region Serialization]
            Student std= new Student(122,"NAME");
             bf.Serialize(st, std);
            string str=JsonSerializer.Serialize(bf);
            Console.WriteLine(str);
            Console.Read();

            #endregion
            /*
                        #region Deserialization
                        Student s =(Student)bf.Deserialize(st);
                        Console.WriteLine("rollno==>"+s.rollno);
                        Console.WriteLine("Name==>"+s.name);
                        #endregion

                        Console.Read();
            */
            st.Close();

           
           

        }
    }
}
