using System;
namespace Tutorial
{
    public class Student : People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(int age, string name){
            Name = name;
            Age = age;
        }

        public override void Do(object sender, EvtArgs e){
            Console.WriteLine($"Student: Name is {Name}, Age is {Age}, {e.Message} !");
        }
    }
}
