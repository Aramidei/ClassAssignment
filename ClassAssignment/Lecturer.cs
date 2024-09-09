using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Lecturer
    {

        public Guid WorkId { get; set; }

        public string Name { get; set; }

        public Department LecturerDepartment { get; set; }




        private Guid GenerateCourseRef()
        {
            var courseRef = Guid.NewGuid(); ;

            return courseRef;
        }




        public Course CreateCourse()
        {
            Course course = new Course();

            Console.WriteLine("Input course Title");

            course.CourseTitle = Console.ReadLine();

            Console.WriteLine("Input course Title");


            course.CourseCode = Console.ReadLine();

            course.CourseID = GenerateCourseRef();


            return course;


        }


    }




}
