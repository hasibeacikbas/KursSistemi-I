using KursSistemi_I.services;
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
    public partial class AddTeachersForm : Form
    {
        TeacherService teacherService = new TeacherService();
        List<Teacher> teachersList = new List<Teacher>();
        public AddTeachersForm()
        {
            InitializeComponent();
        }
        

        private void AddTeachersForm_Load(object sender, EventArgs e)
        {
            

        }

        private void teacherAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = new Teacher();
                teacher.Name = teacherNameTxt.Text;
                teacher.Surname = teacherSurnameTxt.Text;
                teacher.PhoneNumber = teacherPhoneNumberTxt.Text;
                teacher.MailAddress = teacherMailAddressTxt.Text;
                teacherService.addTeacher(teacher);

                MessageBox.Show("Öğretmen Kaydedildi.");
                textBoxClear();

            }
            catch (Exception exc)
            {

                throw;
            }
        }
        private void textBoxClear()
        {
            teacherIDTxt.Clear();
            teacherNameTxt.Clear();
            teacherSurnameTxt.Clear();
            teacherPhoneNumberTxt.Clear();
            teacherMailAddressTxt.Clear();
        }

        private void teacherClrBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(teacherIDTxt.Text);
            teacherService.deleteTeacher(id);
            MessageBox.Show("Öğrenci Sistemden Silindi");
            textBoxClear();
        }

        private void teacherListBtn_Click(object sender, EventArgs e)
        {
            teacherDataTableGridView.DataSource = teacherService.getTeachers();
            textBoxClear();
        }

        private void teacherUpdtBtn_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(teacherIDTxt.Text);
            var y = teacherService.updateTeacher(idd);
            y.Name = teacherNameTxt.Text;
            y.Surname = teacherSurnameTxt.Text;
            y.PhoneNumber = teacherPhoneNumberTxt.Text;
            y.MailAddress = teacherMailAddressTxt.Text;
        }
    }
}
