
namespace KursSistemi_I
{
    partial class AddCourseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.createEtude = new System.Windows.Forms.Button();
            this.teacherNameComBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.MaskedTextBox();
            this.clockTxt = new System.Windows.Forms.MaskedTextBox();
            this.lessonNameComBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CourseDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.etudeGive = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EtudeID = new System.Windows.Forms.TextBox();
            this.studentEtudeComBox = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.createEtude);
            this.groupBox1.Controls.Add(this.teacherNameComBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTxt);
            this.groupBox1.Controls.Add(this.clockTxt);
            this.groupBox1.Controls.Add(this.lessonNameComBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "deneme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createEtude
            // 
            this.createEtude.Location = new System.Drawing.Point(52, 233);
            this.createEtude.Name = "createEtude";
            this.createEtude.Size = new System.Drawing.Size(180, 37);
            this.createEtude.TabIndex = 1;
            this.createEtude.Text = "Etüt Oluştur";
            this.createEtude.UseVisualStyleBackColor = true;
            this.createEtude.Click += new System.EventHandler(this.createEtude_Click);
            // 
            // teacherNameComBox
            // 
            this.teacherNameComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherNameComBox.FormattingEnabled = true;
            this.teacherNameComBox.Location = new System.Drawing.Point(112, 90);
            this.teacherNameComBox.Name = "teacherNameComBox";
            this.teacherNameComBox.Size = new System.Drawing.Size(228, 28);
            this.teacherNameComBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Öğretmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(112, 139);
            this.dateTxt.Mask = "00/00/0000";
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(228, 27);
            this.dateTxt.TabIndex = 4;
            this.dateTxt.ValidatingType = typeof(System.DateTime);
            // 
            // clockTxt
            // 
            this.clockTxt.Location = new System.Drawing.Point(112, 188);
            this.clockTxt.Mask = "00:00";
            this.clockTxt.Name = "clockTxt";
            this.clockTxt.Size = new System.Drawing.Size(228, 27);
            this.clockTxt.TabIndex = 2;
            this.clockTxt.ValidatingType = typeof(System.DateTime);
            this.clockTxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lessonNameComBox
            // 
            this.lessonNameComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lessonNameComBox.FormattingEnabled = true;
            this.lessonNameComBox.Location = new System.Drawing.Point(112, 40);
            this.lessonNameComBox.Name = "lessonNameComBox";
            this.lessonNameComBox.Size = new System.Drawing.Size(228, 28);
            this.lessonNameComBox.TabIndex = 1;
            this.lessonNameComBox.SelectedIndexChanged += new System.EventHandler(this.lessonNameComBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CourseDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(12, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 252);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // CourseDataGridView
            // 
            this.CourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseDataGridView.Location = new System.Drawing.Point(3, 16);
            this.CourseDataGridView.Name = "CourseDataGridView";
            this.CourseDataGridView.Size = new System.Drawing.Size(833, 233);
            this.CourseDataGridView.TabIndex = 0;
            this.CourseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseDataGridView_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Öğrenci:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // etudeGive
            // 
            this.etudeGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etudeGive.Location = new System.Drawing.Point(106, 172);
            this.etudeGive.Name = "etudeGive";
            this.etudeGive.Size = new System.Drawing.Size(180, 37);
            this.etudeGive.TabIndex = 8;
            this.etudeGive.Text = "Etüt Ver";
            this.etudeGive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Etüt No:";
            // 
            // EtudeID
            // 
            this.EtudeID.Enabled = false;
            this.EtudeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EtudeID.Location = new System.Drawing.Point(127, 60);
            this.EtudeID.Margin = new System.Windows.Forms.Padding(2);
            this.EtudeID.Name = "EtudeID";
            this.EtudeID.Size = new System.Drawing.Size(168, 26);
            this.EtudeID.TabIndex = 11;
            // 
            // studentEtudeComBox
            // 
            this.studentEtudeComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentEtudeComBox.FormattingEnabled = true;
            this.studentEtudeComBox.Location = new System.Drawing.Point(116, 102);
            this.studentEtudeComBox.Name = "studentEtudeComBox";
            this.studentEtudeComBox.Size = new System.Drawing.Size(198, 28);
            this.studentEtudeComBox.TabIndex = 12;
            this.studentEtudeComBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.studentEtudeComBox);
            this.groupBox5.Controls.Add(this.EtudeID);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.etudeGive);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(467, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 239);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(869, 641);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox clockTxt;
        private System.Windows.Forms.ComboBox lessonNameComBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox dateTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox teacherNameComBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createEtude;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView CourseDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button etudeGive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EtudeID;
        private System.Windows.Forms.ComboBox studentEtudeComBox;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}