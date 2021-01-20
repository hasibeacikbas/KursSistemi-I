using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KursSistemi_I
{
    public partial class AddCourseForm : Form
    {

        CourseOtomationEntities2 CourseOtomationEntities;
        public AddCourseForm()
        {
            InitializeComponent();
           
        }

        private void LoadDataLessons()
        {
            CourseOtomationEntities = new CourseOtomationEntities2();
            lessonNameComBox.DataSource = CourseOtomationEntities.Lesson.ToList();
            lessonNameComBox.ValueMember = "LessonID";
            lessonNameComBox.DisplayMember = "Name";
        }
        private void LoadDataTeachers()
        {
            CourseOtomationEntities = new CourseOtomationEntities2();
            bool control;
            int lessonid;
            control = int.TryParse(lessonNameComBox.SelectedValue.ToString(), out lessonid);
            teacherNameComBox.DataSource = CourseOtomationEntities.Teacher.Where(x => x.Lesson == lessonid).ToList(); ;
            teacherNameComBox.ValueMember = "TeacherID";
            teacherNameComBox.DisplayMember = "Name";
            
        }


        void LessonList()
        {
            //Lessons l = new Lessons();
            //l.Name = "asd";

            //context.Lessons.Add(l);
            //connection.saveChanges();

            //IQueryable<Lessons> list = connection.Lessons.where(lesson => lesson.Id >5);

            // SqlDataAdapter lessonListDA = new SqlDataAdapter("Select * From Lesson",connection);
            //DataTable lessonListDT = new DataTable();
            //lessonListDA.Fill(lessonListDT);
            //lessonNameComBox.ValueMember = "DersNo";

            //lessonNameComBox.DisplayMember = "Ad";
            //lessonNameComBox.DataSource = lessonListDT;

                
            

        }
        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            LoadDataLessons();
            LoadDataTeachers();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lessonNameComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SqlDataAdapter teacherListDA = new SqlDataAdapter("Select * from Teacher where Ders=" + lessonNameComBox.SelectedValue, connection);
            //DataTable teacherListDT = new DataTable();
            //teacherListDA.Fill(teacherListDT);
            //teacherNameComBox.ValueMember = "OgretmenNo";
            //teacherNameComBox.DisplayMember = "Ad";
            //teacherNameComBox.DataSource = teacherListDT;
            //List<Lesson> lessons = CourseOtomationEntities.Lesson.ToList();

            //IQueryable<Lessons> list = connection.Lessons.where(lesson => lesson.Id >5); 
            //List<Teacher> teachers = CourseOtomationEntities.Teacher
            LoadDataTeachers();




        }

        private void createEtude_Click(object sender, EventArgs e)
        {
            
        }
    }
}
