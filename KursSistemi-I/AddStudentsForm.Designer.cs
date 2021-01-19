
namespace KursSistemi_I
{
    partial class AddStudentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentPhoneNumberTxt = new System.Windows.Forms.MaskedTextBox();
            this.studentAddBtn = new System.Windows.Forms.Button();
            this.studentIDTxt = new System.Windows.Forms.TextBox();
            this.studentMailAddressTxt = new System.Windows.Forms.TextBox();
            this.studentSurnameTxt = new System.Windows.Forms.TextBox();
            this.studentNameTxt = new System.Windows.Forms.TextBox();
            this.studentIDLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentTableAdapter = new KursSistemi_I.CourseOtomationDataSetTableAdapters.StudentTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studentDataTableGridView = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseOtomationDataSet = new KursSistemi_I.CourseOtomationDataSet();
            this.studentClrBtn = new System.Windows.Forms.Button();
            this.studentListBtn = new System.Windows.Forms.Button();
            this.studentUpdtBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataTableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseOtomationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentUpdtBtn);
            this.groupBox1.Controls.Add(this.studentListBtn);
            this.groupBox1.Controls.Add(this.studentClrBtn);
            this.groupBox1.Controls.Add(this.studentPhoneNumberTxt);
            this.groupBox1.Controls.Add(this.studentAddBtn);
            this.groupBox1.Controls.Add(this.studentIDTxt);
            this.groupBox1.Controls.Add(this.studentMailAddressTxt);
            this.groupBox1.Controls.Add(this.studentSurnameTxt);
            this.groupBox1.Controls.Add(this.studentNameTxt);
            this.groupBox1.Controls.Add(this.studentIDLbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(615, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // studentPhoneNumberTxt
            // 
            this.studentPhoneNumberTxt.Location = new System.Drawing.Point(155, 128);
            this.studentPhoneNumberTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentPhoneNumberTxt.Mask = "(999) 000-0000";
            this.studentPhoneNumberTxt.Name = "studentPhoneNumberTxt";
            this.studentPhoneNumberTxt.Size = new System.Drawing.Size(232, 22);
            this.studentPhoneNumberTxt.TabIndex = 11;
            // 
            // studentAddBtn
            // 
            this.studentAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentAddBtn.Location = new System.Drawing.Point(439, 25);
            this.studentAddBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentAddBtn.Name = "studentAddBtn";
            this.studentAddBtn.Size = new System.Drawing.Size(168, 50);
            this.studentAddBtn.TabIndex = 10;
            this.studentAddBtn.Text = "Ekle";
            this.studentAddBtn.UseVisualStyleBackColor = true;
            this.studentAddBtn.Click += new System.EventHandler(this.studentAddBtn_Click);
            // 
            // studentIDTxt
            // 
            this.studentIDTxt.Location = new System.Drawing.Point(155, 215);
            this.studentIDTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentIDTxt.Name = "studentIDTxt";
            this.studentIDTxt.Size = new System.Drawing.Size(232, 22);
            this.studentIDTxt.TabIndex = 9;
            // 
            // studentMailAddressTxt
            // 
            this.studentMailAddressTxt.Location = new System.Drawing.Point(155, 172);
            this.studentMailAddressTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentMailAddressTxt.Name = "studentMailAddressTxt";
            this.studentMailAddressTxt.Size = new System.Drawing.Size(232, 22);
            this.studentMailAddressTxt.TabIndex = 8;
            // 
            // studentSurnameTxt
            // 
            this.studentSurnameTxt.Location = new System.Drawing.Point(155, 91);
            this.studentSurnameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentSurnameTxt.Name = "studentSurnameTxt";
            this.studentSurnameTxt.Size = new System.Drawing.Size(232, 22);
            this.studentSurnameTxt.TabIndex = 6;
            // 
            // studentNameTxt
            // 
            this.studentNameTxt.Location = new System.Drawing.Point(155, 52);
            this.studentNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentNameTxt.Name = "studentNameTxt";
            this.studentNameTxt.Size = new System.Drawing.Size(232, 22);
            this.studentNameTxt.TabIndex = 5;
            // 
            // studentIDLbl
            // 
            this.studentIDLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.studentIDLbl.AutoSize = true;
            this.studentIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentIDLbl.Location = new System.Drawing.Point(8, 213);
            this.studentIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentIDLbl.Name = "studentIDLbl";
            this.studentIDLbl.Size = new System.Drawing.Size(128, 26);
            this.studentIDLbl.TabIndex = 4;
            this.studentIDLbl.Text = "Öğrenci No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.studentDataTableGridView);
            this.groupBox2.Location = new System.Drawing.Point(16, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(813, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // studentDataTableGridView
            // 
            this.studentDataTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataTableGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDataTableGridView.Location = new System.Drawing.Point(4, 19);
            this.studentDataTableGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentDataTableGridView.Name = "studentDataTableGridView";
            this.studentDataTableGridView.RowHeadersWidth = 51;
            this.studentDataTableGridView.Size = new System.Drawing.Size(805, 235);
            this.studentDataTableGridView.TabIndex = 0;
            this.studentDataTableGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            // 
            // courseOtomationDataSet
            // 
            this.courseOtomationDataSet.DataSetName = "CourseOtomationDataSet";
            this.courseOtomationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentClrBtn
            // 
            this.studentClrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentClrBtn.Location = new System.Drawing.Point(439, 83);
            this.studentClrBtn.Margin = new System.Windows.Forms.Padding(4);
            this.studentClrBtn.Name = "studentClrBtn";
            this.studentClrBtn.Size = new System.Drawing.Size(168, 50);
            this.studentClrBtn.TabIndex = 12;
            this.studentClrBtn.Text = "Sil";
            this.studentClrBtn.UseVisualStyleBackColor = true;
            this.studentClrBtn.Click += new System.EventHandler(this.studentClrBtn_Click);
            // 
            // studentListBtn
            // 
            this.studentListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentListBtn.Location = new System.Drawing.Point(439, 141);
            this.studentListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.studentListBtn.Name = "studentListBtn";
            this.studentListBtn.Size = new System.Drawing.Size(168, 50);
            this.studentListBtn.TabIndex = 13;
            this.studentListBtn.Text = "Listele";
            this.studentListBtn.UseVisualStyleBackColor = true;
            this.studentListBtn.Click += new System.EventHandler(this.studentListBtn_Click);
            // 
            // studentUpdtBtn
            // 
            this.studentUpdtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentUpdtBtn.Location = new System.Drawing.Point(439, 203);
            this.studentUpdtBtn.Margin = new System.Windows.Forms.Padding(4);
            this.studentUpdtBtn.Name = "studentUpdtBtn";
            this.studentUpdtBtn.Size = new System.Drawing.Size(168, 50);
            this.studentUpdtBtn.TabIndex = 14;
            this.studentUpdtBtn.Text = "Güncelle";
            this.studentUpdtBtn.UseVisualStyleBackColor = true;
            this.studentUpdtBtn.Click += new System.EventHandler(this.studentUpdtBtn_Click);
            // 
            // AddStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(875, 556);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddStudents";
            this.Load += new System.EventHandler(this.AddStudentsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataTableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseOtomationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button studentAddBtn;
        private System.Windows.Forms.TextBox studentIDTxt;
        private System.Windows.Forms.TextBox studentMailAddressTxt;
        private System.Windows.Forms.TextBox studentSurnameTxt;
        private System.Windows.Forms.TextBox studentNameTxt;
        private System.Windows.Forms.Label studentIDLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox studentPhoneNumberTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailAddressDataGridViewTextBoxColumn;
        private CourseOtomationDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private CourseOtomationDataSet courseOtomationDataSet;
        private System.Windows.Forms.DataGridView studentDataTableGridView;
        private System.Windows.Forms.Button studentClrBtn;
        private System.Windows.Forms.Button studentListBtn;
        private System.Windows.Forms.Button studentUpdtBtn;
    }
}