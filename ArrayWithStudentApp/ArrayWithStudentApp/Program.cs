using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];

            Student  student1 =new Student();
            student1.regNo = "1781";
            student1.firstName = "Simi";
            student1.lastName = "Rahman";



            Student student2 = new Student();
            student2.regNo = "1782";
            student2.firstName = "Ishaq";
            student2.lastName = "Ali";

            Student student3 =new Student();
            student3.regNo = "1783";
            student3.firstName = "Rakib";
            student3.lastName = "Hassan";


            students[0] = student1;
            students[1] = student2;
            students[2] = student3;


            foreach (Student aStudtent in students)
            {
                Console.WriteLine(aStudtent.regNo +" " + aStudtent.GetFulName());
            }
            Console.Read();
        }
    }
}
