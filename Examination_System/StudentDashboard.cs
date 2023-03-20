using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class StudentDashboard : Form
    {
        Student student=new Student();
        Entities ent = new Entities();
        public StudentDashboard(Student s)
        {
            InitializeComponent();
            student = s;
            stuname.BackColor = Color.Transparent;
            deptname.BackColor = Color.Transparent;
            stuname.Text = s.name.ToString();
            deptname.Text = s.Department.name.ToString().TrimEnd(' ');
            GradeList();
            CourseList();
        }
        public void GradeList()
        {
            listBox1.Items.Clear();
            foreach (var item in student.Student_takes_exam)
            {
                listBox1.Items.Add($"Course : {item.Exam.Course.name}, Grade : {item.grade}");
            }
        }
        public void CourseList()
        {
            courselist.Items.Clear();
            foreach (var item in student.Courses)
            {
                courselist.Items.Add(item.name);
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (courselist.SelectedItem != null &&comboBox1.SelectedItem!=null)
            {
                this.Close();
                string coursename = courselist.SelectedItem.ToString();
                var exams = ent.Exams.Where(ex => ex.Course.name == coursename);
                int examId = int.Parse(comboBox1.SelectedItem.ToString());
                Exam exam = exams.Where(ex => ex.id == examId).FirstOrDefault();
                ExamForm examForm = new ExamForm(exam, student);
                examForm.Show();
            }
        }

        private void StudentDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.login.Show();
        }

        private void courselist_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            var exams = student.Courses.Where(c => c.name == courselist.Text).SelectMany(ex=>ex.Exams);
            foreach (var item in exams)
            {
                comboBox1.Items.Add(item.id);
            }
        }

       
    }
}
