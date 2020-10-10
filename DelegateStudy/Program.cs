using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateStudy
{
    class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }

        public override string ToString()
        {
            return this.Name+":" + this.Score;
        }

        public Student(string name, double score)
        {
            this.Name = name;
            this.Score = score;
        }

    }

    class Students
    {
        private List<Student> listOfStudent = new List<Student>();
        public delegate void PrintProcess(Student list);
        public void Add(Student student)
        {
            listOfStudent.Add(student);
        }
        public void Print()
        {
            Print((student) =>
            {
                Console.WriteLine(student);
            });
        }

        public void Print(PrintProcess process)
        {
            foreach (var item in listOfStudent)
            {
                process(item);
            }
        }
    }
    //delegate class 내부,외부 에서 선언할 수 있음
    class Program
    {
        public delegate void TestDelegate();

        public delegate void CustomDelegate();
        public void Method(CustomDelegate customDelegate)
        {
            customDelegate();
        }

        static void Main(string[] args)
        {
            TestDelegate delegateA=TestMethod;
            TestDelegate delegateB=delegate() { };
            TestDelegate delegateC = () => { };

            delegateA();
            delegateB();
            delegateC();

            ////////////////////////

            Students students = new Students();
            students.Add(new Student("박소원", 4.2));
            students.Add(new Student("김정우", 3.3));

            students.Print();
            students.Print((student) =>
            {
                Console.WriteLine();
                Console.WriteLine("이름: " + student.Name);
                Console.WriteLine("점수: " + student.Score);
            });
        }
        static void TestMethod()
        {

        }
    }
}
