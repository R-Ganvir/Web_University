using IITUniversity.Models;
using IITUniversity.DataContext;
using System;
using System.Linq;
namespace IITUniversity.PreloadData
{
    public class DbInitializer
    {
        public static void Initialize(CollegeContext context) { 
        
            context.Database.EnsureCreated();

            if (context.Students.Any()) {
                return;
            }

            var students = new Student[] {
                new Student{ID=1001, FirstName = "Anirudh", LastName = "Reddy", CourseJoinDate = DateTime.Parse("2017-06-05") },
                new Student{ID=1102, FirstName = "Divya", LastName = "Pariti", CourseJoinDate = DateTime.Parse("2017-07-05") },
                new Student{ID=1211, FirstName = "Kavya", LastName = " ", CourseJoinDate = DateTime.Parse("2017-06-05") },
                new Student{ID=4321, FirstName = "Luckey", LastName = "Bairagi", CourseJoinDate = DateTime.Parse("2017-06-05") },
                new Student{ID=5643, FirstName = "Mushraff", LastName = "Noufal", CourseJoinDate = DateTime.Parse("2017-08-05") },
                new Student{ID=8734, FirstName = "Nagavelli", LastName = "Rohith Kumar", CourseJoinDate = DateTime.Parse("2017-06-05") },
                new Student{ID=6555, FirstName = "Perla Likhith", LastName = "Krishna Sai", CourseJoinDate = DateTime.Parse("2017-08-05") },
                new Student{ID=6723, FirstName = "Pradipta", LastName = "Gosh", CourseJoinDate = DateTime.Parse("2017-07-05") },
                new Student{ID=6785, FirstName = "Raj", LastName = "Gupta", CourseJoinDate = DateTime.Parse("2017-08-05") },
                new Student{ID=5678, FirstName = "Raj Jitendra", LastName = "Patil", CourseJoinDate = DateTime.Parse("2017-06-05") },
                new Student{ID=1523, FirstName = "Rizwan", LastName = "Absari", CourseJoinDate = DateTime.Parse("2017-06-05") },
                new Student{ID=5234, FirstName = "Rupesh", LastName = "Narendra Ganvir", CourseJoinDate = DateTime.Parse("2017-08-05") },
                new Student{ID=1284, FirstName = "Shaik", LastName = "Rihaj Basha", CourseJoinDate = DateTime.Parse("2017-06-05") },
                new Student{ID=3456, FirstName = "Shivam", LastName = "Kumar", CourseJoinDate = DateTime.Parse("2017-08-05") },
                new Student{ID=5184, FirstName = "Umesh", LastName = "Kumar", CourseJoinDate = DateTime.Parse("2017-07-05") },
                new Student{ID=2832, FirstName = "Varsha Keshava", LastName = "Prasad", CourseJoinDate = DateTime.Parse("2017-07-05") },
                new Student{ID=3731, FirstName = "Yasaswini", LastName = "Krishnasri Bathula", CourseJoinDate = DateTime.Parse("2017-08-05") },
                new Student{ID=8310, FirstName = "Vaddi", LastName = "Krishna Mohan", CourseJoinDate = DateTime.Parse("2017-06-05") }
            };

            foreach (Student s in students) { 
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[] {
                new Course{CourseID=4012, Title="Quantum Mechanics", Credits=3 },
                new Course{CourseID=1050, Title="Thermodynamics", Credits=3 },
                new Course{CourseID=1134, Title="Digital Signal Processing", Credits=2 },
                new Course{CourseID=8310, Title="Data Mining", Credits=3 },
                new Course{CourseID=8753, Title="Core Java", Credits=4 },
                new Course{CourseID=4421, Title="Cyber Security", Credits=4 },
                new Course{CourseID=6762, Title="Aritficial Intelligence", Credits=5 },
                new Course{CourseID=7235, Title="Machine Learning with Python", Credits=3 },
                new Course{CourseID=3315, Title="Advanced Java Script", Credits=5 }
            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[] {
                new Enrollment{ EnrollmentID=1823, StudentID=1001, CourseID=4012, Grade=Grade.Distinction},
                new Enrollment{ EnrollmentID=1321, StudentID=1001, CourseID=1050, Grade=Grade.FirstClass},
                new Enrollment{ EnrollmentID=1124, StudentID=1001, CourseID=1134, Grade=Grade.SecondClass},
                new Enrollment{ EnrollmentID=1163, StudentID=1102, CourseID=4012, Grade=Grade.ThirdClass},
                new Enrollment{ EnrollmentID=4232, StudentID=1102, CourseID=3315, Grade=Grade.Fail},
                new Enrollment{ EnrollmentID=5654, StudentID=1102, CourseID=7235, Grade=Grade.Distinction},
                new Enrollment{ EnrollmentID=7853, StudentID=1211, CourseID=8310, Grade=Grade.FirstClass},
                new Enrollment{ EnrollmentID=5466, StudentID=1211, CourseID=4012, Grade=Grade.SecondClass},
                new Enrollment{ EnrollmentID=4563, StudentID=4321, CourseID=8310, Grade=Grade.ThirdClass},
                new Enrollment{ EnrollmentID=1286, StudentID=4321, CourseID=8753, Grade=Grade.Fail},
                new Enrollment{ EnrollmentID=5689, StudentID=4321, CourseID=4012, Grade=Grade.FirstClass},
                new Enrollment{ EnrollmentID=7756, StudentID=5643, CourseID=1134, Grade=Grade.SecondClass},
                new Enrollment{ EnrollmentID=4465, StudentID=5643, CourseID=8310, Grade=Grade.ThirdClass},
                new Enrollment{ EnrollmentID=8864, StudentID=5643, CourseID=7235, Grade=Grade.Fail},
                new Enrollment{ EnrollmentID=3346, StudentID=5643, CourseID=3315, Grade=Grade.Distinction},
                new Enrollment{ EnrollmentID=9845, StudentID=8734, CourseID=6762, Grade=Grade.FirstClass},
                new Enrollment{ EnrollmentID=9121, StudentID=8734, CourseID=7235, Grade=Grade.SecondClass},
                new Enrollment{ EnrollmentID=9734, StudentID=8734, CourseID=8753, Grade=Grade.ThirdClass},
                new Enrollment{ EnrollmentID=4927, StudentID=6555, CourseID=4012, Grade=Grade.Fail},
                new Enrollment{ EnrollmentID=5586, StudentID=6555, CourseID=4421, Grade=Grade.Distinction},
                new Enrollment{ EnrollmentID=9544, StudentID=6723, CourseID=4012, Grade=Grade.FirstClass},
                new Enrollment{ EnrollmentID=6864, StudentID=6723, CourseID=6762, Grade=Grade.SecondClass},
                new Enrollment{ EnrollmentID=8893, StudentID=6785, CourseID=8310, Grade=Grade.ThirdClass},
                new Enrollment{ EnrollmentID=7345, StudentID=6785, CourseID=4012, Grade=Grade.Fail},
                new Enrollment{ EnrollmentID=6963, StudentID=6785, CourseID=3315, Grade=Grade.Distinction},
                new Enrollment{ EnrollmentID=8243, StudentID=5678, CourseID=4012, Grade=Grade.FirstClass},
                new Enrollment{ EnrollmentID=1987, StudentID=5678, CourseID=3315, Grade=Grade.SecondClass},
                new Enrollment{ EnrollmentID=1992, StudentID=1523, CourseID=4012, Grade=Grade.ThirdClass},
                new Enrollment{ EnrollmentID=1993, StudentID=1523, CourseID=8753, Grade=Grade.Fail},
                new Enrollment{ EnrollmentID=1994, StudentID=5234, CourseID=4012, Grade=Grade.Distinction},
                new Enrollment{ EnrollmentID=1995, StudentID=5234, CourseID=8310, Grade=Grade.FirstClass},
                new Enrollment{ EnrollmentID=2001, StudentID=5234, CourseID=6762, Grade=Grade.SecondClass},
                new Enrollment{ EnrollmentID=2002, StudentID=1284, CourseID=1134, Grade=Grade.ThirdClass},
                new Enrollment{ EnrollmentID=2003, StudentID=1284, CourseID=4012, Grade=Grade.Fail},
                new Enrollment{ EnrollmentID=2004, StudentID=3456, CourseID=3315, Grade=Grade.Distinction},
                new Enrollment{ EnrollmentID=2005, StudentID=3456, CourseID=6762, Grade=Grade.FirstClass},
                new Enrollment{ EnrollmentID=2006, StudentID=5184, CourseID=4012, Grade=Grade.SecondClass},
                new Enrollment{ EnrollmentID=2007, StudentID=5184, CourseID=8753, Grade=Grade.ThirdClass},
                new Enrollment{ EnrollmentID=2008, StudentID=2832, CourseID=8753, Grade=Grade.Fail},
                new Enrollment{ EnrollmentID=2009, StudentID=2832, CourseID=4012, Grade=Grade.Distinction},
                new Enrollment{ EnrollmentID=2010, StudentID=2832, CourseID=4421, Grade=Grade.FirstClass},
                new Enrollment{ EnrollmentID=2011, StudentID=3731, CourseID=3315, Grade=Grade.SecondClass},
                new Enrollment{ EnrollmentID=2012, StudentID=3731, CourseID=6762, Grade=Grade.ThirdClass},
                new Enrollment{ EnrollmentID=2013, StudentID=3731, CourseID=4012, Grade=Grade.Fail},
                new Enrollment{ EnrollmentID=2014, StudentID=8310, CourseID=3315, Grade=Grade.Distinction},
                new Enrollment{ EnrollmentID=2015, StudentID=8310, CourseID=6762, Grade=Grade.FirstClass}
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
