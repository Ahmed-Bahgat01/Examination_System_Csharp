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
    public partial class Generate_ShowExam : Form
    {
        Entities Ent = new Entities();
        Instructor _instructor = new Instructor();
        public Generate_ShowExam()
        {
            InitializeComponent();
            _instructor = Ent.Instructors.Find(3);
            instname.Text = _instructor.name;
            instadept.Text = _instructor.Department.name;
            UpdateList();
            UpdateCourse();

        }
        public void UpdateList()
        {
            examlist.Items.Clear();

            foreach (var exam in Ent.Exams)
            {
                    examlist.Items.Add($"ID : {exam.id},Course : {exam.Course.name}");
            }
        }
        public void UpdateCourse()
        {
            courselist.Items.Clear();
            foreach (var course in _instructor.Courses)
            {
                courselist.Items.Add(course.name);
            }
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            if (examlist.SelectedItem != null)
            {
                int examid = int.Parse(examlist.SelectedItem.ToString().Split(',')[0].Remove(0,5));
                dataGridView1.DataSource = Ent.get_exam_questions_proc("C#", examid);
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Choose an Exam");

            }

        }

        private void genbutton_Click(object sender, EventArgs e)
        {
            int mcq = 0;
            int tf = 0;
            if (mcqno.Text != null &&
                tfno.Text != null &&
                int.TryParse(mcqno.Text, out mcq) &&
                int.TryParse(tfno.Text, out tf)
               )

            {
                if (mcq + tf <= 10 && courselist.SelectedItem!=null)
                {
                    foreach (var course in _instructor.Courses)
                    {
                        if (course.name == courselist.SelectedItem.ToString())
                        {

                            Ent.generate_exam(course.id, tf, mcq);
                            MessageBox.Show($"An Exam has been generated for Course : {course.name}");
                            UpdateList();
                            
                        }
                    }

                }
            }


        }
    }
}
