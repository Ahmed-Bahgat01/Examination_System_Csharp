using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class InstructorDashboard : Form
    {
        // FIELDS
        private Instructor LoggedInInstructor = null;
        Entities context = null;

        // CONSTRUCTORS
        public InstructorDashboard(int _instructorId)
        {
            InitializeComponent();

            // initializing context
            context = new Entities();

            // get LoggedInInstructor
            LoggedInInstructor = context.select_instu(_instructorId).FirstOrDefault<Instructor>();

            ShowInstructorData();
            FillCoursesComboBox();
        }

        // METHODS
        private void FillCoursesComboBox()
        {
            coursesComboBox.DisplayMember = "name";
            coursesComboBox.ValueMember = "id";
            coursesComboBox.DataSource = LoggedInInstructor.Courses.ToList();
        }

        private void ShowInstructorData()
        {
            ShowWelcomeInstructor();
            LoggedInstructorIDLabel.Text = LoggedInInstructor.id.ToString();
            LoggedInstructorNameLabel.Text = LoggedInInstructor.name;
            LoggedInstructorDepartmentLabel.Text = LoggedInInstructor.Department.name;
        }

        private void ShowWelcomeInstructor()
        {
            welcomeLabel.Text = $"Welcome {LoggedInInstructor.name.Split(' ')[0]}";
        }

        // EVENT HANDLERS

        private void coursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // updating students
            StudentsGridView.DataSource = (coursesComboBox.SelectedItem as Course).Students.ToList();

            // updating topics
            TopicsGridView.DataSource = (coursesComboBox.SelectedItem as Course).Topics.ToList();

            // updating exams
            ExamsGridView.DataSource = (coursesComboBox.SelectedItem as Course).Exams.ToList();

            // updating numericupdown of exams id's
            ExamIdNumericUpDown.Maximum = (coursesComboBox.SelectedItem as Course).Exams.Count;

        }

        private void studentsGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // removing unnecessary columns
            StudentsGridView.Columns.Remove("Courses");
            StudentsGridView.Columns.Remove("Student_takes_exam");
            StudentsGridView.Columns.Remove("Student_answer_question");
            StudentsGridView.Columns.Remove("Department");
            StudentsGridView.Columns.Remove("fk_department");

            // clearing default cell selection
            StudentsGridView.ClearSelection();
        }

        private void TopicsGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // removing unnecessary columns
            TopicsGridView.Columns.Remove("fk_course");
            TopicsGridView.Columns.Remove("Course");

            // clearing default cell selection
            TopicsGridView.ClearSelection();
        }

        private void ExamsGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // removing unnecessary columns
            ExamsGridView.Columns.Remove("fk_course");
            ExamsGridView.Columns.Remove("Questions");
            ExamsGridView.Columns.Remove("Course");
            ExamsGridView.Columns.Remove("Student_takes_exam");

            // clearing default cell selection
            ExamsGridView.ClearSelection();
        }

        private void ShowStudentAnswersBtn_Click(object sender, EventArgs e)
        {
            //UpdateStudentAnswersGridViewDataSource();
            // get exam id 
            int examId = (int)ExamIdNumericUpDown.Value;
            // get selected student
            int selectedRowsCount = StudentsGridView.SelectedRows.Count;
            if (selectedRowsCount != 0)
            {
                Student stu = StudentsGridView.SelectedRows[0].DataBoundItem as Student;
                string logSource = "#UpdateStudentAnswersGridViewDataSource";
                StudentAnswersGridView.DataSource = context.get_exam_with_stu_answer_proc(logSource, examId, stu.id);
            }
            else
            {
                string warningMsg = "please select student row from students table";
                MessageBox.Show(warningMsg, "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExamIdNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            // preventing enter of decimals
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        ///     this handler is for all datagridview controls to select whole row when cell clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                (sender as DataGridView).Rows[e.RowIndex].Selected = true;
            }
        }

        /// <summary>
        ///     this event handler is for all datagridview controls to select whole row when cell doubleclicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentAnswersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                (sender as DataGridView).Rows[e.RowIndex].Selected = true;
            }
        }

        private void ShowExamBtn_Click(object sender, EventArgs e)
        {
            //TODO: TO BE LINKED WITH HESHAM FORM
        }

        private void GenerateExamBtn_Click(object sender, EventArgs e)
        {
            //TODO: TO BE LINKED WITH HESHAM FORM
        }
    }
}
