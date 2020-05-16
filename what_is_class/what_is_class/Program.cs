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
            // The code provided will print ‘Hello World’ to the console.898
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Student stu1 = new Student(1,"ackurdeevesq");
            Student stu2 = new Student(2, "moonglaive");
            Student stu3 = new Student(3, "midicat");

            Console.WriteLine(Student.Amount);
        }
    }

    class Student
    {
        public static int Amount { get; set; }

        static Student()//静态属性测试
        {
            Amount = 110;
        }

        public Student(int id, string name) //实例构造器
        {
            this.ID = id;
            this.Name = name;
            Amount++;
        }

        //~Student() //
        //{
        //    Console.WriteLine("Bye!Release system resources");
        //}

        public int ID { get; set; }
        public string Name { get; set; }

        public void Report()
        {
            Console.WriteLine($"I am #{ID} student, my name is {Name}.");
        }
    }
}