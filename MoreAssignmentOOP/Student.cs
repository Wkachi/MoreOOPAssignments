using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAssignmentOOP
{
    public static class Student
    {
        public static string FullName { get; set; }
        public static string Course { get; set; }
        public static string Subject { get; set; }
        public static string University { get; set; }
        public static Guid Email { get; set; }
        public static int PhoneNumber { get; set; }

        //public  static void StudentInfo(string fullName, string course, string subject, string university, Guid email, int phoneNumber)
        //{
        //    FullName = fullName;
        //    Console.WriteLine(fullName);
        //    Course = course;
        //    Console.WriteLine(Course);
        //    Subject = subject;
        //    University = university;
        //    Email = email;
        //    PhoneNumber = phoneNumber;
        //}

        public static void StudentInfo(string fullName)
        {
           // FullName = fullName;
            Console.WriteLine("Hello" + fullName);
            //Course = course;
            //Console.WriteLine(Course);
            //Subject = subject;
            //University = university;
            //Email = email;
            //PhoneNumber = phoneNumber;
        }
    }

   

}
