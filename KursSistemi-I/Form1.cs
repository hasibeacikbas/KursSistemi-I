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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            
            AddStudentsForm addStudentsForm = new AddStudentsForm();
            addStudentsForm.FormClosing += delegate { this.Show(); };
            addStudentsForm.Show();
            this.Hide();

        }

        private void addTeacher_Click(object sender, EventArgs e)
        {
            AddTeachersForm addTeachersForm = new AddTeachersForm();
            addTeachersForm.FormClosing += delegate { this.Show(); };
            addTeachersForm.Show();
            this.Hide();
        }

        private void addEtude_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.FormClosing += delegate { this.Show(); };
            addCourseForm.Show();
            this.Hide();
        }
    }
}
