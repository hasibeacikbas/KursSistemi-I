using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursSistemi_I.services
{
    class CourseService
    {
        CourseOtomationEntities2 courseOtomationEntitiesCourse;
        public CourseService()
        {
            courseOtomationEntitiesCourse = new CourseOtomationEntities2();
        }
        public Course getCourse(int id)
        {
            var x = courseOtomationEntitiesCourse.Course.Find(id);
            return x;
        }

        public List<Course> getCourses()
        {

            return courseOtomationEntitiesCourse.Course.ToList();
        }
        public Course addCourse(Course course)
        {
            courseOtomationEntitiesCourse.Course.Add(course);
            courseOtomationEntitiesCourse.SaveChanges();
            return course;
        }
    }
}
