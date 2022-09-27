using System;
using System.Collections.Generic;
using System.Text;

namespace observerPattern
{
    class Course : ICourse
    {
        List<ICourseList> observers;
        private string name;

        public Course()
        {
            observers = new List<ICourseList>();
        }

        public void attach(ICourseList observer)
        {
            observers.Add(observer);
        }

        public void deattach(ICourseList observer)
        {
            observers.Remove(observer);
        }

        public void notify()
        {
            foreach(ICourseList observer in observers)
            {
                observer.update(this); //updating (this) same course
            }
            
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
            notify();
        }

    }
}
