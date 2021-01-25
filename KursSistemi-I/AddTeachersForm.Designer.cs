
namespace KursSistemi_I
{
    partial class AddTeachersForm
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
            this.teacherUpdtBtn = new System.Windows.Forms.Button();
            this.teacherListBtn = new System.Windows.Forms.Button();
            this.teacherClrBtn = new System.Windows.Forms.Button();
            this.lessonTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teacherPhoneNumberTxt = new System.Windows.Forms.MaskedTextBox();
            this.teacherAddBtn = new System.Windows.Forms.Button();
            this.teacherIDTxt = new System.Windows.Forms.TextBox();
            this.teacherMailAddressTxt = new System.Windows.Forms.TextBox();
            this.teacherSurnameTxt = new System.Windows.Forms.TextBox();
            this.teacherNameTxt = new System.Windows.Forms.TextBox();
            this.studentIDLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.teacherDataTableGridView = new System.Windows.Forms.DataGridView();
            this.courseOtomationDataSet = new KursSistemi_I.CourseOtomationDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new KursSistemi_I.CourseOtomationDataSetTableAdapters.TeacherTableAdapter();
            this.ogretmenNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataTableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseOtomationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teacherUpdtBtn);
            this.groupBox1.Controls.Add(this.teacherListBtn);
            this.groupBox1.Controls.Add(this.teacherClrBtn);
            this.groupBox1.Controls.Add(this.lessonTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.teacherPhoneNumberTxt);
            this.groupBox1.Controls.Add(this.teacherAddBtn);
            this.groupBox1.Controls.Add(this.teacherIDTxt);
            this.groupBox1.Controls.Add(this.teacherMailAddressTxt);
            this.groupBox1.Controls.Add(this.teacherSurnameTxt);
            this.groupBox1.Controls.Add(this.teacherNameTxt);
            this.groupBox1.Controls.Add(this.studentIDLbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(661, 308);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // teacherUpdtBtn
            // 
            this.teacherUpdtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherUpdtBtn.Location = new System.Drawing.Point(457, 238);
            this.teacherUpdtBtn.Margin = new System.Windows.Forms.Padding(4);
            this.teacherUpdtBtn.Name = "teacherUpdtBtn";
            this.teacherUpdtBtn.Size = new System.Drawing.Size(168, 50);
            this.teacherUpdtBtn.TabIndex = 16;
            this.teacherUpdtBtn.Text = "Güncelle";
            this.teacherUpdtBtn.UseVisualStyleBackColor = true;
            this.teacherUpdtBtn.Click += new System.EventHandler(this.teacherUpdtBtn_Click);
            // 
            // teacherListBtn
            // 
            this.teacherListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherListBtn.Location = new System.Drawing.Point(457, 169);
            this.teacherListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.teacherListBtn.Name = "teacherListBtn";
            this.teacherListBtn.Size = new System.Drawing.Size(168, 50);
            this.teacherListBtn.TabIndex = 15;
            this.teacherListBtn.Text = "Listele";
            this.teacherListBtn.UseVisualStyleBackColor = true;
            this.teacherListBtn.Click += new System.EventHandler(this.teacherListBtn_Click);
            // 
            // teacherClrBtn
            // 
            this.teacherClrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherClrBtn.Location = new System.Drawing.Point(457, 98);
            this.teacherClrBtn.Margin = new System.Windows.Forms.Padding(4);
            this.teacherClrBtn.Name = "teacherClrBtn";
            this.teacherClrBtn.Size = new System.Drawing.Size(168, 50);
            this.teacherClrBtn.TabIndex = 14;
            this.teacherClrBtn.Text = "Sil";
            this.teacherClrBtn.UseVisualStyleBackColor = true;
            this.teacherClrBtn.Click += new System.EventHandler(this.teacherClrBtn_Click);
            // 
            // lessonTxt
            // 
            this.lessonTxt.Location = new System.Drawing.Point(169, 255);
            this.lessonTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lessonTxt.Name = "lessonTxt";
            this.lessonTxt.Size = new System.Drawing.Size(232, 22);
            this.lessonTxt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ders:";
            // 
            // teacherPhoneNumberTxt
            // 
            this.teacherPhoneNumberTxt.Location = new System.Drawing.Point(169, 126);
            this.teacherPhoneNumberTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherPhoneNumberTxt.Mask = "(999) 000-0000";
            this.teacherPhoneNumberTxt.Name = "teacherPhoneNumberTxt";
            this.teacherPhoneNumberTxt.Size = new System.Drawing.Size(232, 22);
            this.teacherPhoneNumberTxt.TabIndex = 11;
            // 
            // teacherAddBtn
            // 
            this.teacherAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherAddBtn.Location = new System.Drawing.Point(457, 25);
            this.teacherAddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.teacherAddBtn.Name = "teacherAddBtn";
            this.teacherAddBtn.Size = new System.Drawing.Size(168, 50);
            this.teacherAddBtn.TabIndex = 10;
            this.teacherAddBtn.Text = "Ekle";
            this.teacherAddBtn.UseVisualStyleBackColor = true;
            this.teacherAddBtn.Click += new System.EventHandler(this.teacherAddBtn_Click);
            // 
            // teacherIDTxt
            // 
            this.teacherIDTxt.Location = new System.Drawing.Point(169, 213);
            this.teacherIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.teacherIDTxt.Name = "teacherIDTxt";
            this.teacherIDTxt.Size = new System.Drawing.Size(232, 22);
            this.teacherIDTxt.TabIndex = 9;
            // 
            // teacherMailAddressTxt
            // 
            this.teacherMailAddressTxt.Location = new System.Drawing.Point(169, 170);
            this.teacherMailAddressTxt.Margin = new System.Windows.Forms.Padding(4);
            this.teacherMailAddressTxt.Name = "teacherMailAddressTxt";
            this.teacherMailAddressTxt.Size = new System.Drawing.Size(232, 22);
            this.teacherMailAddressTxt.TabIndex = 8;
            // 
            // teacherSurnameTxt
            // 
            this.teacherSurnameTxt.Location = new System.Drawing.Point(169, 89);
            this.teacherSurnameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.teacherSurnameTxt.Name = "teacherSurnameTxt";
            this.teacherSurnameTxt.Size = new System.Drawing.Size(232, 22);
            this.teacherSurnameTxt.TabIndex = 6;
            // 
            // teacherNameTxt
            // 
            this.teacherNameTxt.Location = new System.Drawing.Point(169, 50);
            this.teacherNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.teacherNameTxt.Name = "teacherNameTxt";
            this.teacherNameTxt.Size = new System.Drawing.Size(232, 22);
            this.teacherNameTxt.TabIndex = 5;
            // 
            // studentIDLbl
            // 
            this.studentIDLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.studentIDLbl.AutoSize = true;
            this.studentIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentIDLbl.Location = new System.Drawing.Point(8, 213);
            this.studentIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentIDLbl.Name = "studentIDLbl";
            this.studentIDLbl.Size = new System.Drawing.Size(122, 22);
            this.studentIDLbl.TabIndex = 4;
            this.studentIDLbl.Text = "Öğretmen No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
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
            this.label3.Size = new System.Drawing.Size(76, 22);
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
            this.label2.Size = new System.Drawing.Size(66, 22);
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
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.teacherDataTableGridView);
            this.groupBox2.Location = new System.Drawing.Point(13, 329);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(813, 258);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // teacherDataTableGridView
            // 
            this.teacherDataTableGridView.AutoGenerateColumns = false;
            this.teacherDataTableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacherDataTableGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.teacherDataTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataTableGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogretmenNoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.dersDataGridViewTextBoxColumn});
            this.teacherDataTableGridView.DataSource = this.teacherBindingSource;
            this.teacherDataTableGridView.Location = new System.Drawing.Point(8, 23);
            this.teacherDataTableGridView.Margin = new System.Windows.Forms.Padding(4);
            this.teacherDataTableGridView.Name = "teacherDataTableGridView";
            this.teacherDataTableGridView.RowHeadersWidth = 51;
            this.teacherDataTableGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teacherDataTableGridView.Size = new System.Drawing.Size(797, 228);
            this.teacherDataTableGridView.TabIndex = 0;
            // 
            // courseOtomationDataSet
            // 
            this.courseOtomationDataSet.DataSetName = "CourseOtomationDataSet";
            this.courseOtomationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.courseOtomationDataSet;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // ogretmenNoDataGridViewTextBoxColumn
            // 
            this.ogretmenNoDataGridViewTextBoxColumn.DataPropertyName = "OgretmenNo";
            this.ogretmenNoDataGridViewTextBoxColumn.HeaderText = "OgretmenNo";
            this.ogretmenNoDataGridViewTextBoxColumn.Name = "ogretmenNoDataGridViewTextBoxColumn";
            this.ogretmenNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // dersDataGridViewTextBoxColumn
            // 
            this.dersDataGridViewTextBoxColumn.DataPropertyName = "Ders";
            this.dersDataGridViewTextBoxColumn.HeaderText = "Ders";
            this.dersDataGridViewTextBoxColumn.Name = "dersDataGridViewTextBoxColumn";
            // 
            // AddTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(865, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTeachersForm";
            this.Text = "AddTeachersForm";
            this.Load += new System.EventHandler(this.AddTeachersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataTableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseOtomationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox teacherPhoneNumberTxt;
        private System.Windows.Forms.Button teacherAddBtn;
        private System.Windows.Forms.TextBox teacherIDTxt;
        private System.Windows.Forms.TextBox teacherMailAddressTxt;
        private System.Windows.Forms.TextBox teacherSurnameTxt;
        private System.Windows.Forms.TextBox teacherNameTxt;
        private System.Windows.Forms.Label studentIDLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView teacherDataTableGridView;
        private System.Windows.Forms.TextBox lessonTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button teacherUpdtBtn;
        private System.Windows.Forms.Button teacherListBtn;
        private System.Windows.Forms.Button teacherClrBtn;
        private CourseOtomationDataSet courseOtomationDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private CourseOtomationDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersDataGridViewTextBoxColumn;
    }
}