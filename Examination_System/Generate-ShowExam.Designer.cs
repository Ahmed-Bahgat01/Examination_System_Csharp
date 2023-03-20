namespace Examination_System
{
    partial class Generate_ShowExam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.instname = new System.Windows.Forms.Label();
            this.instadept = new System.Windows.Forms.Label();
            this.genbutton = new System.Windows.Forms.Button();
            this.showbutton = new System.Windows.Forms.Button();
            this.examlist = new System.Windows.Forms.ComboBox();
            this.examlabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.courselist = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mcqno = new System.Windows.Forms.TextBox();
            this.tfno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // instname
            // 
            this.instname.AutoSize = true;
            this.instname.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.instname.Location = new System.Drawing.Point(103, 5);
            this.instname.Name = "instname";
            this.instname.Size = new System.Drawing.Size(94, 34);
            this.instname.TabIndex = 0;
            this.instname.Text = "label1";
            // 
            // instadept
            // 
            this.instadept.AutoSize = true;
            this.instadept.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instadept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.instadept.Location = new System.Drawing.Point(127, 47);
            this.instadept.Name = "instadept";
            this.instadept.Size = new System.Drawing.Size(58, 23);
            this.instadept.TabIndex = 1;
            this.instadept.Text = "labe2";
            // 
            // genbutton
            // 
            this.genbutton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.genbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genbutton.Location = new System.Drawing.Point(525, 17);
            this.genbutton.Name = "genbutton";
            this.genbutton.Size = new System.Drawing.Size(171, 64);
            this.genbutton.TabIndex = 2;
            this.genbutton.Text = "Generate Exam";
            this.genbutton.UseVisualStyleBackColor = false;
            this.genbutton.Click += new System.EventHandler(this.genbutton_Click);
            // 
            // showbutton
            // 
            this.showbutton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.showbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbutton.Location = new System.Drawing.Point(707, 19);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(171, 62);
            this.showbutton.TabIndex = 3;
            this.showbutton.Text = "Show Exam";
            this.showbutton.UseVisualStyleBackColor = false;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // examlist
            // 
            this.examlist.FormattingEnabled = true;
            this.examlist.Location = new System.Drawing.Point(727, 99);
            this.examlist.Name = "examlist";
            this.examlist.Size = new System.Drawing.Size(121, 21);
            this.examlist.TabIndex = 4;
            // 
            // examlabel
            // 
            this.examlabel.AutoSize = true;
            this.examlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examlabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.examlabel.Location = new System.Drawing.Point(755, 82);
            this.examlabel.Name = "examlabel";
            this.examlabel.Size = new System.Drawing.Size(73, 18);
            this.examlabel.TabIndex = 5;
            this.examlabel.Text = "Exam List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 136);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Size = new System.Drawing.Size(906, 404);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(319, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Course";
            // 
            // courselist
            // 
            this.courselist.FormattingEnabled = true;
            this.courselist.Location = new System.Drawing.Point(385, 17);
            this.courselist.Name = "courselist";
            this.courselist.Size = new System.Drawing.Size(121, 21);
            this.courselist.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(398, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "MCQ";
            // 
            // mcqno
            // 
            this.mcqno.Location = new System.Drawing.Point(385, 61);
            this.mcqno.Name = "mcqno";
            this.mcqno.Size = new System.Drawing.Size(58, 20);
            this.mcqno.TabIndex = 11;
            // 
            // tfno
            // 
            this.tfno.Location = new System.Drawing.Point(449, 61);
            this.tfno.Name = "tfno";
            this.tfno.Size = new System.Drawing.Size(57, 20);
            this.tfno.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(464, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "T/F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(368, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "*the sum of the question should be 10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 34);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Department :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.instname);
            this.panel1.Controls.Add(this.instadept);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 100);
            this.panel1.TabIndex = 17;
            // 
            // Generate_ShowExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(904, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tfno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mcqno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courselist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.examlabel);
            this.Controls.Add(this.examlist);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.genbutton);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Generate_ShowExam";
            this.Text = "Generate_ShowExam";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instname;
        private System.Windows.Forms.Label instadept;
        private System.Windows.Forms.Button genbutton;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.ComboBox examlist;
        private System.Windows.Forms.Label examlabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courselist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mcqno;
        private System.Windows.Forms.TextBox tfno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}