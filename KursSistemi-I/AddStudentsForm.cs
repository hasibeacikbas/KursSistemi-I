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

namespace KursSistemi_I
{
    public partial class AddStudentsForm : Form
    {
        StudentService studentService = new StudentService();

        public AddStudentsForm()
        {
            InitializeComponent(); 
        }
        private void AddStudentsForm_Load(object sender, EventArgs e)
        {

        }
        private void studentAddBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                Student student = new Student();
                student.Name = studentNameTxt.Text;
                student.Surname = studentSurnameTxt.Text;
                student.PhoneNumber = studentPhoneNumberTxt.Text;
                student.MailAddress = studentMailAddressTxt.Text;
                studentService.addStudent(student);
               
                MessageBox.Show("Öğrenci Kaydedildi.");
                textBoxClear();
                
            }
            catch (Exception exc)
            {

                throw;
            } 
        }

        private void textBoxClear()
        {
            studentIDTxt.Clear();
            studentNameTxt.Clear();
            studentSurnameTxt.Clear();
            studentPhoneNumberTxt.Clear();
            studentMailAddressTxt.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentClrBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(studentIDTxt.Text);
            studentService.deleteStudent(id);
            MessageBox.Show("Öğrenci Sistemden Silindi");
            textBoxClear();    
        }

        private void studentListBtn_Click(object sender, EventArgs e)
        {
            studentDataTableGridView.DataSource = studentService.getStudents();
            textBoxClear();
        }

        private void studentUpdtBtn_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(studentIDTxt.Text);
            var y = studentService.updateStudent(idd);
            y.Name = studentNameTxt.Text;
            y.Surname = studentSurnameTxt.Text;
            y.PhoneNumber = studentPhoneNumberTxt.Text;
            y.MailAddress = studentMailAddressTxt.Text;
            
        }
    }

}
