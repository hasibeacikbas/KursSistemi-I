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
using KursSistemi_I.services;


namespace KursSistemi_I
{
    public partial class AddCourseForm : Form
    {
        CourseService courseService = new CourseService();
        CourseOtomationEntities2 CourseOtomationEntities;
        public AddCourseForm()
        {
            
            CourseOtomationEntities = new CourseOtomationEntities2();
            InitializeComponent();
        }

        private void LoadDataLessons()
        {
            //var a = CourseOtomationEntities.Course.ToList();
            //string b = a[0].Teacher.Name;
            lessonNameComBox.DataSource = CourseOtomationEntities.Lesson.ToList();
            lessonNameComBox.ValueMember = "LessonID";
            lessonNameComBox.DisplayMember = "Name";
        }
        private void LoadDataTeachers()
        {
            bool control;
            int lessonid;
            control = int.TryParse(lessonNameComBox.SelectedValue.ToString(), out lessonid);
            if (control)
            {
                teacherNameComBox.DataSource = CourseOtomationEntities.Teacher.Where(x => x.Lesson == lessonid).ToList();
                teacherNameComBox.ValueMember = "TeacherID";
                teacherNameComBox.DisplayMember = "FullName";
            }
        }
        private void LoadDataStudent()
        {
            studentEtudeComBox.DataSource = CourseOtomationEntities.Student.ToList();
            studentEtudeComBox.ValueMember = "StudentID";
            studentEtudeComBox.DisplayMember = "FullName";
        }
        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            LoadDataLessons();
            LoadDataTeachers();
            LoadDataStudent();


            //CourseDataGridView.AutoGenerateColumns = false;
            //CourseDataGridView.AutoSize = true;
            //CourseDataGridView.DataSource = BindingSource;

            //DataGridViewColumn dataGridViewColumn = new DataGridViewTextBoxColumn();
            //dataGridViewColumn.DataPropertyName = "Teacher";
            //dataGridViewColumn.Name = "Teacher";
            //CourseDataGridView.Columns.Add(dataGridViewColumn);
            //CourseDataGridView.DataSource = CourseOtomationEntities.Course.ToList();
            //CourseDataGridView.Columns["Teacher"].DataPropertyName = "CourseID";

            //Course course = new Course();
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
            LoadDataTeachers();
            LoadDataStudent();
        }

        private void createEtude_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = new Course();
                course.CourseLessonID = Convert.ToByte(lessonNameComBox.SelectedValue);
                course.CourseTeacherID = Convert.ToByte(teacherNameComBox.SelectedValue);

                course.Date = dateTxt.Text;
                course.Time = clockTxt.Text;
                courseService.addCourse(course);
            }
            catch (Exception exc)
            {

                throw;
            }
        }

        private void CourseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int selected = CourseDataGridView.SelectedCells[0].RowIndex;
            //EtudeID.Text = CourseDataGridView.Rows[selected].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in CourseOtomationEntities.Course
                        join d2  in CourseOtomationEntities.Lesson
                        on d1.CourseLessonID equals d2.LessonID
                        join d3 in CourseOtomationEntities.Teacher
                        on d1.CourseTeacherID equals d3.TeacherID

                        select new
                        {
                            KURSNO=d1.CourseID,
                            DERS=d2.Name,
                            ÖĞRETMEN=d3.Name + " " + d3.Surname,
                            

                        };
            CourseDataGridView.DataSource = sorgu.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
