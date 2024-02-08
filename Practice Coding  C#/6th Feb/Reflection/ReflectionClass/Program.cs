using System;
using System.Reflection;

namespace ReflectionClass
{

    class Student
    { 
        public int RollNo
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
        public Student()
        {
            RollNo = 0;
            Name = string.Empty;
        }

        public Student(int rno, string n)
        {
            RollNo = rno;
            Name = n;
        }

        public void displayData()
        {
            Console.WriteLine("Roll Number : {0}", RollNo);
            Console.WriteLine("Name : {0}", Name);
        }
    }

    class Program
    {

        public static void Main(string[] args)
        {
            Assembly executing = Assembly.GetExecutingAssembly();
            /*Student std = new Student(1223,"StdName");
            std.displayData();*/
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine("Class==>{0} ",  item.Name);

                MethodInfo[] methodInfos = item.GetMethods();
                foreach (var methodInfo in methodInfos)
                {
                    Console.WriteLine("Method==> {0}", methodInfo.Name);

                    ParameterInfo[] parameters = methodInfo.GetParameters();
                    foreach (var parameterInfo in parameters)
                    {
                        Console.WriteLine("Parameter==> {0} type==> {1}", parameterInfo.Name, parameterInfo.ParameterType);
                    }
                }
            }
            Console.ReadLine();

        }
    }
}

