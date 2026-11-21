using EtgAcademy2026.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtgAcademy2026.Service
{
    internal class SchoolRegistration()
    {




        


        public Models.ResponseHeader RegisterStudent(Student student)
        {
            // Logic to register a student
            Console.WriteLine($"Registering student: {student.Name}, Age: {student.Age}, Matric No: {student.MatricNo}");
            return new Models.ResponseHeader
            {
                ResponseCode = "200",
                ResponseMessage = "Student registered successfully"
            };
        }

        public Models.ResponseHeader RegisterStudents(List<Student> students)
        {

            string[] arr = { "1,1,2,3,4,5" };
            HashSet<int> uniqueNumbers = new HashSet<int>();
            Dictionary<string, int> numberCounts = new Dictionary<string, int>();

            numberCounts.Add("Basic", 3);
            numberCounts.Add("Bearer", 5);


            string input = "0123456789";


            input = input.Replace("0", "Zero");
            input = input.Insert(0, "Start-");
            input = input.Remove(3, 3);







            foreach (var student in students)
            {
                RegisterStudent(student);
            }
            return new Models.ResponseHeader
            {
                ResponseCode = "200",
                ResponseMessage = "All students registered successfully"
            };
        }


        //Param byVal and by Ref
        public void UpdateStudentAgeByValue(Student student, int newAge)
        {
            student.Age = newAge;
            Console.WriteLine($"Updated student age to {student.Age} (by value)");
        }
        public void UpdateStudentAgeByReference(ref Student student, int newAge)
        {
            student.Age = newAge;
            Console.WriteLine($"Updated student age to {student.Age} (by reference)");
        }






    }
}
