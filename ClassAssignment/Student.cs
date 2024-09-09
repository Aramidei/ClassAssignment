using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Student
    {
        public string MatricNo { get; set; }

        public string Name {  get; set; }

        public Department Department { get; set; }




        public void RecordGrade(string Name, int score, string Course)
        {
            var grade = GradeCalculator(score);

            Console.WriteLine($"{Name}, you have a {grade} in {Course}");


        }





        private char GradeCalculator(int score)
        {

            if (score >= 80)
            {
                return 'A';
            }


            else if (score < 80 && score >= 60)
            {
                return 'B';
            }


            else if (score < 60 && score >= 45)
            {
                return 'C';
            }

            return 'F';

        }

    }






}
