using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class LoginForm : Form
    {
        Entities DB = new Entities();
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (radioButtonStu.Checked == true && int.TryParse(textBox2.Text, out id))
            {
                try
                {
                    var std = (from d in DB.Students
                               where ((d.name == textBox1.Text) && d.id == id)
                               select d).First();
                    if (std != null)
                    {
                        StudentDashboard s1 = new StudentDashboard(std);
                        s1.Show();
                        Program.login.Hide();
                    }
                }
                catch
                {
                    DialogueBox ms = new DialogueBox("You entered a Wrong Name or ID");
                    ms.Show();
                }
            }
            else if (radioButtonIns.Checked == true && int.TryParse(textBox2.Text, out id))
            {
                try
                {
                    var ins = (from d in DB.Instructors
                               where ((d.name == textBox1.Text) && d.id == id)
                               select d).First();
                    if (ins != null)
                    {
                        InstructorDashboard i1 = new InstructorDashboard(ins);
                        i1.Show();
                        Program.login.Hide();

                    }
                }
                catch
                {
                    DialogueBox ms = new DialogueBox("You entered a Wrong Name or ID");
                    ms.Show();

                }
            }
            else
            {
                DialogueBox ms = new DialogueBox("You entered a Wrong Name or ID\n or a Missing Field");
                ms.Show();

            }
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();



        private void LoginForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
