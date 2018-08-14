using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentGradesNS;

namespace studengradetest
{
    [TestClass]
    public class UnitTestGrades
    {
        [TestMethod]
        public void PickGrades_updateGrades()
        {
            double presnetgrade = 78;
            double pickgrade = 78;
            //double expected = 77;
            StudentGrades randgrade = new StudentGrades("Mr.A", presnetgrade);

            randgrade.pick(pickgrade);
            

            //double actual = randgrade.Grades;
            //Assert.AreEqual(pickgrade, presnetgrade, "No improvement in the grade");
            //Console.WriteLine("The Grade is same as previous");

                        
        }
    }
}
