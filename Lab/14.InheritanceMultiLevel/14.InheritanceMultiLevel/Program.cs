using System;

namespace _14.InheritanceMultiLevel
{
    class Person
    {
        private string name;
        private int age;

        public Person()
        {
            name = "Unknown";
            age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }

    class Teacher : Person
    {
        private string Subject;
        private int Experience;

        public Teacher()
        {
            Subject = "Not Assigned";
            Experience = 0;
        }

        public Teacher(string name, int age, string Subject, int Experience) : base(name, age)
        {
            this.Subject = Subject;
            this.Experience = Experience;
        }

        public string subject
        {
            get { return Subject; }
            set { Subject = value; }
        }

        public int experience
        {
            get { return Experience; }
            set { Experience = value; }
        }

        public void DisplayTeacherInfo()
        {
            base.DisplayPersonInfo();
            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("Experience: " + experience + " years");
        }
    }

    class HeadTeacher : Teacher
    {
        private int NumberOfTeachersManaged;

        public HeadTeacher()
        {
            NumberOfTeachersManaged = 0;
        }

        public HeadTeacher(string name, int age, string subject, int Experience, int NumberOfTeachersManaged)
            : base(name, age, subject, Experience)
        {
            this.NumberOfTeachersManaged = NumberOfTeachersManaged;
        }

        public int NumberofTeacherManagedd
        {
            get { return this.NumberOfTeachersManaged; }
            set { this.NumberOfTeachersManaged = value; }
        }

        public void DisplayHeadTeacherInfo()
        {
            base.DisplayTeacherInfo();
            Console.WriteLine("Number of Teachers Managed: " + NumberOfTeachersManaged);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            HeadTeacher h1 = new HeadTeacher();
            h1.Name = "Asif Nazrul";
            h1.Age = 47;
            h1.subject = "Law";
            h1.experience = 15;
            h1.NumberofTeacherManagedd = 30;
            h1.DisplayHeadTeacherInfo();

            Console.WriteLine();

            HeadTeacher h2 = new HeadTeacher("Dr. Md. Younus", 85, "Economics", 35, 45);
            h2.DisplayHeadTeacherInfo();

            Console.ReadKey();
        }
    }
}
