namespace Examination_System
{
    partial class InstructorDashboard
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.coursesComboBox = new System.Windows.Forms.ComboBox();
            this.OpenExamWizardBtn = new System.Windows.Forms.Button();
            this.StudentsGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExamIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ShowStudentAnswersBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TopicsGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExamsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentAnswersGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.LoggedInstructorIDLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LoggedInstructorNameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LoggedInstructorDepartmentLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamIdNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopicsGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentAnswersGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(4, 20);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(98, 25);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // coursesComboBox
            // 
            this.coursesComboBox.FormattingEnabled = true;
            this.coursesComboBox.Location = new System.Drawing.Point(532, 84);
            this.coursesComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coursesComboBox.Name = "coursesComboBox";
            this.coursesComboBox.Size = new System.Drawing.Size(213, 21);
            this.coursesComboBox.TabIndex = 1;
            this.coursesComboBox.SelectedIndexChanged += new System.EventHandler(this.coursesComboBox_SelectedIndexChanged);
            // 
            // OpenExamWizardBtn
            // 
            this.OpenExamWizardBtn.Location = new System.Drawing.Point(22, 258);
            this.OpenExamWizardBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenExamWizardBtn.Name = "OpenExamWizardBtn";
            this.OpenExamWizardBtn.Size = new System.Drawing.Size(98, 49);
            this.OpenExamWizardBtn.TabIndex = 3;
            this.OpenExamWizardBtn.Text = "Open Exam Wizard";
            this.OpenExamWizardBtn.UseVisualStyleBackColor = true;
            this.OpenExamWizardBtn.Click += new System.EventHandler(this.OpenExamWizardBtn_Click);
            // 
            // StudentsGridView
            // 
            this.StudentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGridView.Location = new System.Drawing.Point(0, 34);
            this.StudentsGridView.Margin = new System.Windows.Forms.Padding(0);
            this.StudentsGridView.Name = "StudentsGridView";
            this.StudentsGridView.ReadOnly = true;
            this.StudentsGridView.RowHeadersWidth = 51;
            this.StudentsGridView.RowTemplate.Height = 24;
            this.StudentsGridView.Size = new System.Drawing.Size(232, 206);
            this.StudentsGridView.TabIndex = 5;
            this.StudentsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsGridView_CellClick);
            this.StudentsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentAnswersGridView_CellDoubleClick);
            this.StudentsGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.studentsGridView_DataBindingComplete);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ExamIdNumericUpDown);
            this.groupBox1.Controls.Add(this.ShowStudentAnswersBtn);
            this.groupBox1.Controls.Add(this.StudentsGridView);
            this.groupBox1.Location = new System.Drawing.Point(9, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(235, 327);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Exam ID";
            // 
            // ExamIdNumericUpDown
            // 
            this.ExamIdNumericUpDown.Location = new System.Drawing.Point(17, 288);
            this.ExamIdNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExamIdNumericUpDown.Name = "ExamIdNumericUpDown";
            this.ExamIdNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.ExamIdNumericUpDown.TabIndex = 7;
            this.ExamIdNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExamIdNumericUpDown_KeyPress);
            // 
            // ShowStudentAnswersBtn
            // 
            this.ShowStudentAnswersBtn.Location = new System.Drawing.Point(124, 258);
            this.ShowStudentAnswersBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowStudentAnswersBtn.Name = "ShowStudentAnswersBtn";
            this.ShowStudentAnswersBtn.Size = new System.Drawing.Size(92, 50);
            this.ShowStudentAnswersBtn.TabIndex = 6;
            this.ShowStudentAnswersBtn.Text = "Show Student Answers";
            this.ShowStudentAnswersBtn.UseVisualStyleBackColor = true;
            this.ShowStudentAnswersBtn.Click += new System.EventHandler(this.ShowStudentAnswersBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.TopicsGridView);
            this.groupBox2.Location = new System.Drawing.Point(526, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(223, 327);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Topics";
            // 
            // TopicsGridView
            // 
            this.TopicsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TopicsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TopicsGridView.Location = new System.Drawing.Point(5, 34);
            this.TopicsGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopicsGridView.Name = "TopicsGridView";
            this.TopicsGridView.ReadOnly = true;
            this.TopicsGridView.RowHeadersWidth = 51;
            this.TopicsGridView.RowTemplate.Height = 24;
            this.TopicsGridView.Size = new System.Drawing.Size(213, 206);
            this.TopicsGridView.TabIndex = 0;
            this.TopicsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsGridView_CellClick);
            this.TopicsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentAnswersGridView_CellDoubleClick);
            this.TopicsGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TopicsGridView_DataBindingComplete);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.ExamsGridView);
            this.groupBox3.Controls.Add(this.OpenExamWizardBtn);
            this.groupBox3.Location = new System.Drawing.Point(320, 180);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(142, 327);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exams";
            // 
            // ExamsGridView
            // 
            this.ExamsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExamsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamsGridView.Location = new System.Drawing.Point(0, 34);
            this.ExamsGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExamsGridView.Name = "ExamsGridView";
            this.ExamsGridView.ReadOnly = true;
            this.ExamsGridView.RowHeadersWidth = 51;
            this.ExamsGridView.RowTemplate.Height = 24;
            this.ExamsGridView.Size = new System.Drawing.Size(138, 206);
            this.ExamsGridView.TabIndex = 0;
            this.ExamsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsGridView_CellClick);
            this.ExamsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentAnswersGridView_CellDoubleClick);
            this.ExamsGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ExamsGridView_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Course";
            // 
            // StudentAnswersGridView
            // 
            this.StudentAnswersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentAnswersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentAnswersGridView.Location = new System.Drawing.Point(0, 32);
            this.StudentAnswersGridView.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.StudentAnswersGridView.Name = "StudentAnswersGridView";
            this.StudentAnswersGridView.ReadOnly = true;
            this.StudentAnswersGridView.RowHeadersWidth = 51;
            this.StudentAnswersGridView.RowTemplate.Height = 24;
            this.StudentAnswersGridView.Size = new System.Drawing.Size(738, 159);
            this.StudentAnswersGridView.TabIndex = 9;
            this.StudentAnswersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsGridView_CellClick);
            this.StudentAnswersGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentAnswersGridView_CellDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.58823F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoggedInstructorIDLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LoggedInstructorNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LoggedInstructorDepartmentLabel, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 57);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 81);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // LoggedInstructorIDLabel
            // 
            this.LoggedInstructorIDLabel.AutoSize = true;
            this.LoggedInstructorIDLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInstructorIDLabel.Location = new System.Drawing.Point(69, 0);
            this.LoggedInstructorIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoggedInstructorIDLabel.Name = "LoggedInstructorIDLabel";
            this.LoggedInstructorIDLabel.Size = new System.Drawing.Size(41, 19);
            this.LoggedInstructorIDLabel.TabIndex = 1;
            this.LoggedInstructorIDLabel.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // LoggedInstructorNameLabel
            // 
            this.LoggedInstructorNameLabel.AutoSize = true;
            this.LoggedInstructorNameLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInstructorNameLabel.Location = new System.Drawing.Point(69, 27);
            this.LoggedInstructorNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoggedInstructorNameLabel.Name = "LoggedInstructorNameLabel";
            this.LoggedInstructorNameLabel.Size = new System.Drawing.Size(41, 19);
            this.LoggedInstructorNameLabel.TabIndex = 3;
            this.LoggedInstructorNameLabel.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Department";
            // 
            // LoggedInstructorDepartmentLabel
            // 
            this.LoggedInstructorDepartmentLabel.AutoSize = true;
            this.LoggedInstructorDepartmentLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInstructorDepartmentLabel.Location = new System.Drawing.Point(69, 54);
            this.LoggedInstructorDepartmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoggedInstructorDepartmentLabel.Name = "LoggedInstructorDepartmentLabel";
            this.LoggedInstructorDepartmentLabel.Size = new System.Drawing.Size(41, 19);
            this.LoggedInstructorDepartmentLabel.TabIndex = 5;
            this.LoggedInstructorDepartmentLabel.Text = "label9";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.StudentAnswersGridView);
            this.groupBox4.Location = new System.Drawing.Point(9, 523);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(740, 219);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student Answer";
            // 
            // InstructorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(992, 609);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.coursesComboBox);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InstructorDashboard";
            this.Text = "InstructorDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InstructorDashboard_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamIdNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopicsGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExamsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentAnswersGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ComboBox coursesComboBox;
        private System.Windows.Forms.Button OpenExamWizardBtn;
        private System.Windows.Forms.DataGridView StudentsGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView TopicsGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ExamsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ExamIdNumericUpDown;
        private System.Windows.Forms.Button ShowStudentAnswersBtn;
        private System.Windows.Forms.DataGridView StudentAnswersGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LoggedInstructorIDLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LoggedInstructorNameLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LoggedInstructorDepartmentLabel;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}