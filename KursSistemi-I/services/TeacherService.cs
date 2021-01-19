using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursSistemi_I.services
{
    public class TeacherService
    {
        CourseOtomationEntities2 courseOtomationEntitiesTeacher;
        public TeacherService()
        {
            courseOtomationEntitiesTeacher = new CourseOtomationEntities2();
        }
        public Teacher getTeacher(int id)
        {

            var x = courseOtomationEntitiesTeacher.Teacher.Find(id);
            return x;
        }

        public List<Teacher> getTeachers()
        {

            return courseOtomationEntitiesTeacher.Teacher.ToList();
        }
        public Teacher addTeacher(Teacher teacher)
        {
            courseOtomationEntitiesTeacher.Teacher.Add(teacher);
            courseOtomationEntitiesTeacher.SaveChanges();
            return teacher;
        }

        public Teacher updateTeacher(int teacherIdd)
        {
            var x = courseOtomationEntitiesTeacher.Teacher.Find(teacherIdd);

            return x;
        }


        public bool deleteTeacher(int teacherId)
        {

            var x = courseOtomationEntitiesTeacher.Teacher.Find(teacherId);
            courseOtomationEntitiesTeacher.Teacher.Remove(x);
            courseOtomationEntitiesTeacher.SaveChanges();
            return true;
        }
    }
}
