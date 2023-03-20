using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    enum MCQ
    { 
        A=1,
        B,
        C,
        D
    };
    
    public partial class ExamForm : Form
    {
        ConfirmationDialog confirmation=new ConfirmationDialog();
        Entities Ent=new Entities();
        List<get_exam_questions_proc_Result1> list = new List<get_exam_questions_proc_Result1>();
        public ExamForm()
        {
            
            foreach (var item in Ent.get_exam_questions_proc("C#", 1))
            {
                list.Add(item);
            }
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            int count = 0;
            foreach (Panel panel in tableLayoutPanel1.Controls)
            {
                if (list[count].question_type == "T/F")
                {
                    panel.Controls[1].Hide();
                    panel.Controls[0].Hide();
                }
                panel.Controls[4].Text = list[count].question_text;
                panel.Controls[3].Text = list[count].option_a;
                panel.Controls[2].Text = list[count].option_b;
                panel.Controls[1].Text = list[count].option_c;
                panel.Controls[0].Text = list[count].option_d;
                count++;
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            confirmation.ShowDialog();
            if (confirmation.DialogResult == DialogResult.OK)
            {
                int count = 0;
                foreach (Panel panel in tableLayoutPanel1.Controls)
                {
                    foreach (Control item in panel.Controls)
                    {
                        if (item is RadioButton)
                        {

                            RadioButton radiobutton = item as RadioButton;
                            if (radiobutton.Checked)
                            {
                                if (list[count].question_type == "MCQ")
                                {

                                    Ent.Insert_StuQuestion(2, list[count].id, 1, ((MCQ)radiobutton.TabIndex).ToString());
                                }
                                else
                                {

                                    Ent.Insert_StuQuestion(2, list[count].id, 1, radiobutton.Text);
                                }

                            }

                        }

                    }
                    count++;

                }
                Ent.ExamCorrection(1, 2);
                button1.Enabled= false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            tableLayoutPanel1.Visible = true;
            button2.Visible = false;
        }
    }
}
