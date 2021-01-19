
namespace KursSistemi_I
{
    partial class Form1
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
            this.addStudent = new System.Windows.Forms.Button();
            this.addTeacher = new System.Windows.Forms.Button();
            this.addEtude = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudent
            // 
            this.addStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addStudent.ForeColor = System.Drawing.Color.Black;
            this.addStudent.Location = new System.Drawing.Point(71, 62);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(268, 31);
            this.addStudent.TabIndex = 0;
            this.addStudent.Text = "Öğrenci Ekle/Sil";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // addTeacher
            // 
            this.addTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addTeacher.Location = new System.Drawing.Point(71, 111);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Size = new System.Drawing.Size(268, 31);
            this.addTeacher.TabIndex = 1;
            this.addTeacher.Text = "Öğretmen Ekle/Sil";
            this.addTeacher.UseVisualStyleBackColor = true;
            this.addTeacher.Click += new System.EventHandler(this.addTeacher_Click);
            // 
            // addEtude
            // 
            this.addEtude.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addEtude.Location = new System.Drawing.Point(71, 159);
            this.addEtude.Name = "addEtude";
            this.addEtude.Size = new System.Drawing.Size(268, 31);
            this.addEtude.TabIndex = 2;
            this.addEtude.Text = "Etüt Ekle/Sil";
            this.addEtude.UseVisualStyleBackColor = true;
            this.addEtude.Click += new System.EventHandler(this.addEtude_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 260);
            this.Controls.Add(this.addEtude);
            this.Controls.Add(this.addTeacher);
            this.Controls.Add(this.addStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button addTeacher;
        private System.Windows.Forms.Button addEtude;
    }
}

