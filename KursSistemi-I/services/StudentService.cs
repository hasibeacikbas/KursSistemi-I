using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursSistemi_I.services
{
    public class StudentService
    {
        CourseOtomationEntities2 courseOtomationEntitiesStudent;
        
        public StudentService()
        {
            courseOtomationEntitiesStudent = new CourseOtomationEntities2();
        }

        public Student getStudent(int id)
        {

            var x = courseOtomationEntitiesStudent.Student.Find(id);
            return x;
        }   
        
        public List<Student> getStudents()
        {
           
            return courseOtomationEntitiesStudent.Student.ToList();
        } 
        public Student addStudent(Student student)
        {

            courseOtomationEntitiesStudent.Student.Add(student);
            courseOtomationEntitiesStudent.SaveChanges();
            return student;
        }
        
        public Student updateStudent(int studentIdd)
        {
            var x = courseOtomationEntitiesStudent.Student.Find(studentIdd);
            
            return x;
        }
        
        
        public bool deleteStudent(int studentId)
        {

            var x = courseOtomationEntitiesStudent.Student.Find(studentId);
            courseOtomationEntitiesStudent.Student.Remove(x);
            courseOtomationEntitiesStudent.SaveChanges();
            return true;
        }
    }
}
