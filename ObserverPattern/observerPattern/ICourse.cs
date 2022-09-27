using System;
using System.Collections.Generic;
using System.Text;

namespace observerPattern
{
    interface ICourse
    {
        void notify();
        void attach(ICourseList observer);
        void deattach(ICourseList observer);

    }
}
