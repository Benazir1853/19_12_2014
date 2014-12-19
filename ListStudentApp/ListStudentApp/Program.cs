using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student();
            student1.regNo = "1781";
            student1.firstName = "Simi";
            student1.lastName = "Rahman";



            Student student2 = new Student();
            student2.regNo = "1782";
            student2.firstName = "Ishaq";
            student2.lastName = "Ali";

            Student student3 = new Student();
            student3.regNo = "1783";
            student3.firstName = "Rakib";
            student3.lastName = "Hassan";

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            foreach (Student astudent in students)
            {
               Console.WriteLine(astudent.regNo +" " +astudent.GetFulName()); 
            }
            Console.Read();
        }
    }
}
