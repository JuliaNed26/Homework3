using System;
using System.Collections.Generic;

namespace Task2
{
    abstract class Student
    {
        public string name;
        public string state;
        public Student(string _name,string _state)
        {
            name = _name;
            state = _state;
        }
        public void Relax()
        {
            state += "Relax ";
        }
        public void Read()
        {
            state += "Read ";
        }
        public void Write()
        {
            state += "Write ";
        }
        public abstract void Study();
    }

    class GoodStudent:Student
    {
        public GoodStudent(string _name,string _state):base(_name,_state)
        {
            state += " good ";
        }
        public override void Study()
        {
            for(int i=0;i<2;i++)
            {
                Read();
                Write();
            }
            Relax();
        }
    }

    class BadStudent:Student
    {
        public BadStudent(string _name, string _state) : base(_name, _state)
        {
            state += " bad ";
        }
        public override void Study()
        {
            for (int i = 0; i < 4; i++)
            {
                Relax();
            }
            Read();
        }
    }

    class Group
    {
        public string name;
        public List<Student> students;
        public Group(string _name)
        {
            name = _name;
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public string GetInfo()
        {
            string info = name + "\n";
            foreach(Student student in students)
            {
                info += student.name + "\n";
            }
            return info;
        }
        public string GetFullInfo()
        {
            string info = name + "\n";
            foreach (Student student in students)
            {
                info += student.name + " " + student.state + "\n";
            }
            return info;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Group k26 = new Group("K-26");
            GoodStudent vasya = new GoodStudent("Vasya Ivanov", "full-time");
            BadStudent petya = new BadStudent("Petya Piatochkin", "full-time");
            k26.AddStudent(vasya);
            k26.AddStudent(petya);
            vasya.Study();
            petya.Study();
            Console.WriteLine(k26.GetInfo());
            Console.WriteLine(k26.GetFullInfo());
        }
    }
}
