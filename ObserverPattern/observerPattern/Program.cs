using System;

namespace observerPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseList businessCourseList = new CourseList();
            businessCourseList.setName("business");
            CourseList CSCourseList = new CourseList();
            CSCourseList.setName("Computer Sceince");
            Course ProgrammingOnTheWeb = new Course();
            ProgrammingOnTheWeb.attach(CSCourseList);
            ProgrammingOnTheWeb.setName("Programming on The Web");
            Course Fundementals_of_Managament = new Course();
            Fundementals_of_Managament.attach(businessCourseList);
            Fundementals_of_Managament.setName("Fundementals of Managament");
        }
    }
}
