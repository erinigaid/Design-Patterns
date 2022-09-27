using System;
using System.Collections.Generic;
using System.Text;

namespace observerPattern
{
    public class CourseList : ICourseList
    {
       private string name;
        
        void ICourseList.update(ICourse course)
        {
            Course c = course as Course;
            Console.WriteLine("Course list " + name + " updated to: "+ c.getName());
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
}
