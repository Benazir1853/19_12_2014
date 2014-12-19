using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoUsingStackPractice4App
{
    class Program
    {
        static void Main(string[] args)
        {
           Stack<Student> studentStack = new Stack<Student>();
            Student student1 = new Student();
            student1.firstName = "Sumona";
            student1.lastName = "Sharmin";
            studentStack.Push(student1);
            Student anotherStudent = new Student();
            anotherStudent.firstName = "Sumon";
            anotherStudent.lastName = "Talukdar";
            studentStack.Push(anotherStudent);

            foreach (Student aStudent in studentStack)
            {
                Console.WriteLine(aStudent.GetFullName());
            }
            Console.Read();

        }
    }
}
