using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace what_is_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Type t = typeof(Student);//反射
            object o = Activator.CreateInstance(t, 2, "ackurdeeve");
            Student stu1 = o as Student;
            Console.WriteLine(stu1.ID);
            Console.WriteLine(stu1.Name);
            stu1.Report();
            Console.ReadKey();

        }
    }

    class Student
    {
        public Student(int id, string name)//实例构造器
        {
            this.ID = id;
            this.Name = name;
        }

        ~Student()//
        {
            Console.WriteLine("Bye!Release system resources");
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public void Report()
        {
            Console.WriteLine($"I am #{ID} student, my name is {Name}.");
        }
    }
}
