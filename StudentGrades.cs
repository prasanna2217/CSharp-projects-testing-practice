using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesNS
{
    public class StudentGrades
    {
        private string n_StudentName;

        private double n_Grades;
        
        private bool n_none = false;

        public const string GradeNotFoundsMessage = "The grade is same as previous";

        public const string GradeLessThanExpectedMessage = "Grade is less than present one, need to improve";

        public const string GradeNotValidMessage1 = "Grade not valid";
        
        public const string GradeNotValidMessage = "Grade exceeds limit";

        public StudentGrades(string StudentName, double Grades)
        {
            n_StudentName = StudentName;
            n_Grades = Grades;
        }

        public string StudentName
        {
            get { return n_StudentName; }
        }

        public double Grades
        {
            get { return n_Grades; }
        }

        public void pick(double randgrade)
        {
            if (n_none)
            {
                throw new Exception("Not Found");
            }
            if (randgrade > n_Grades)
            {
                Console.WriteLine("There is imrovement in grades");
            }
            if (randgrade == n_Grades)
            {
                throw new ArgumentOutOfRangeException("randgrade", randgrade, GradeNotFoundsMessage);
            }
            if (randgrade < 0)
            {
                throw new ArgumentOutOfRangeException("randgrade", randgrade, GradeNotValidMessage1);
            }
            if (randgrade < n_Grades)
            {
                throw new ArgumentOutOfRangeException("randgrade", randgrade, GradeLessThanExpectedMessage);
            }
           
            if (randgrade > 100)
            {
                throw new ArgumentOutOfRangeException("randgrade", randgrade, GradeNotValidMessage);
            }
            n_Grades -= randgrade;
        }

        public void Enter(double randgrade)
        {
            if(n_none)
            {
                throw new Exception("Not found in Reconds");
            }
            if(randgrade<50)
            {
                throw new ArgumentOutOfRangeException("randgrade");
            }
            n_Grades += randgrade;
        }

        private void NoneRecord()
        {
            n_none = true;
        }

        private void FoundRecord()
        {
            n_none = false;
        }

        public static void Main()
        {
            StudentGrades sg = new StudentGrades("Mr. A", 78.6);
            StudentGrades sg1 = new StudentGrades("Mr. B", 98);
            StudentGrades sg2 = new StudentGrades("Mr. C", 48.2);
            StudentGrades sg3 = new StudentGrades("Mr. D", 30.6);

            sg.pick(70);
            sg1.pick(100);
            sg2.pick(40);
            sg3.pick(30);

            sg.Enter(80);
            sg1.Enter(70);
            sg2.Enter(50);
            sg3.Enter(20);
            Console.WriteLine("Current Grade is ${0}", sg.Grades);
            Console.WriteLine("Current Grade is ${0}", sg1.Grades);
            Console.WriteLine("Current Grade is ${0}", sg2.Grades);
            Console.WriteLine("Current Grade is ${0}", sg3.Grades);
           

        }
    }
}
