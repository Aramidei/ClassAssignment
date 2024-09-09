using System;
using System.Net;
using System.Xml.Linq;


namespace ClassAssignment
{

    class Program
    {



        static void Main(string[] args)

        {

            
            List<Faculty> faculties = new List<Faculty>
            {
                new Faculty { FacultyId = Guid.NewGuid(), FacultyName = "Engineering" },
                new Faculty { FacultyId = Guid.NewGuid(), FacultyName = "Sciences" },
                new Faculty { FacultyId = Guid.NewGuid(), FacultyName = "Law" },
            };


            List<Department> departments = new List<Department>
            {
                new Department{DeptId = Guid.NewGuid(), DepartmentName = "Computer Engineering", Faculty = { FacultyId = Guid.NewGuid(), FacultyName = "Engineering" } },
                new Department{DeptId = Guid.NewGuid(), DepartmentName = "Public Law", Faculty = { FacultyId = Guid.NewGuid(), FacultyName = "Law" } },
                new Department{DeptId = Guid.NewGuid(), DepartmentName = "MicrBiology", Faculty = { FacultyId = Guid.NewGuid(), FacultyName = "Sciences" } },

            };


            List<Lecturer> lecturers = new List<Lecturer>
            {

                new Lecturer{WorkId = Guid.NewGuid(), Name = "James Ayi", LecturerDepartment = new Department { DeptId = Guid.NewGuid(), DepartmentName = "Mechanical Engineering", Faculty = { FacultyId = Guid.NewGuid(), FacultyName = "Engineering" } }  },
                new Lecturer{WorkId = Guid.NewGuid(), Name = "Queen Precious", LecturerDepartment = new Department { DeptId = Guid.NewGuid(), DepartmentName = "Mass Communication", Faculty = { FacultyId = Guid.NewGuid(), FacultyName = "Humanities" } }  },
                new Lecturer{WorkId = Guid.NewGuid(), Name = "Tunde Brown ", LecturerDepartment = new Department { DeptId = Guid.NewGuid(), DepartmentName = "Physics", Faculty = { FacultyId = Guid.NewGuid(), FacultyName = "Sciences" } }  },

            };




            List<Student> students = new List<Student>
            {
                new Student { MatricNo = "45ENG76G", Name = "Will Drew", Department = new Department { DeptId = Guid.NewGuid(), DepartmentName = "Criminal Law", Faculty = { FacultyId = Guid.NewGuid(), FacultyName = "Law" } } },
                new Student { MatricNo = "45ENG76G", Name = "Tom Jay ", Department = new Department { DeptId = Guid.NewGuid(), DepartmentName = "Theatre Arts", Faculty = { FacultyId = Guid.NewGuid(), FacultyName = "Arts" } } },
                new Student { MatricNo = "45ENG76G", Name = "Justice White", Department = new Department { DeptId = Guid.NewGuid(), DepartmentName = "Mechatronics Engineering", Faculty = { FacultyId = Guid.NewGuid(), FacultyName = "Engineering" } } },
            };


            List<Course> courses = new List<Course>
            {

                new Course {CourseID = Guid.NewGuid(), CourseTitle = "Engineering Mathematics", CourseCode = "MTH 309",Lecturer = new Lecturer {WorkId = Guid.NewGuid(), Name = "Mercy Jones", LecturerDepartment = new Department { DeptId = Guid.NewGuid(), DepartmentName = "Mechanical Engineering", Faculty = { FacultyId = Guid.NewGuid(), FacultyName = "Engineering" }} } },
                new Course {CourseID = Guid.NewGuid(), CourseTitle = "System Control", CourseCode = "EEE 542",Lecturer = new Lecturer {WorkId = Guid.NewGuid(), Name = "Sarah paul", LecturerDepartment = new Department { DeptId = Guid.NewGuid(), DepartmentName = "Electrical Engineering", Faculty = { FacultyId = Guid.NewGuid(), FacultyName = "Engineering" }} } },
                new Course {CourseID = Guid.NewGuid(), CourseTitle = "Quantum Physics", CourseCode = "PHY 359",Lecturer = new Lecturer {WorkId = Guid.NewGuid(), Name = "Isaac King", LecturerDepartment = new Department { DeptId = Guid.NewGuid(), DepartmentName = "Physice", Faculty = { FacultyId = Guid.NewGuid(), FacultyName = "Sciences" }} } },

            };


            var firstStudent = students.First();

            firstStudent.RecordGrade("Sarah Williams",78,"MTH 101" );


            var firstLecturer = lecturers.First();

            firstLecturer.CreateCourse();




        }




    }
}
