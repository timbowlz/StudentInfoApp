namespace StudentInfoApp
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            txtStudentIdNo = new TextBox();
            label18 = new Label();
            comboBox2 = new ComboBox();
            label17 = new Label();
            checkBox6 = new CheckBox();
            trackBar1 = new TrackBar();
            label8 = new Label();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            dateBirth = new DateTimePicker();
            label5 = new Label();
            btnFemale = new RadioButton();
            btnMale = new RadioButton();
            label4 = new Label();
            txtPhoneNo = new MaskedTextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            groupBox4 = new GroupBox();
            satisfaction = new Label();
            label27 = new Label();
            college = new Label();
            label26 = new Label();
            listBox1 = new ListBox();
            course = new Label();
            label01 = new Label();
            studentIdNo = new Label();
            label15 = new Label();
            label14 = new Label();
            groupBox3 = new GroupBox();
            dateOfBirth = new Label();
            gender = new Label();
            phoneNo = new Label();
            firstName = new Label();
            lastName = new Label();
            label10 = new Label();
            label13 = new Label();
            label9 = new Label();
            label12 = new Label();
            label11 = new Label();
            tabPage3 = new TabPage();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 453);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 425);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Info Form";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(388, 391);
            button2.Name = "button2";
            button2.Size = new Size(395, 23);
            button2.TabIndex = 4;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(95, 390);
            button1.Name = "button1";
            button1.Size = new Size(170, 23);
            button1.TabIndex = 3;
            button1.Text = "Upload Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(95, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 170);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtStudentIdNo);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(trackBar1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(388, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 374);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Academic Information";
            // 
            // txtStudentIdNo
            // 
            txtStudentIdNo.Location = new Point(10, 37);
            txtStudentIdNo.Name = "txtStudentIdNo";
            txtStudentIdNo.PlaceholderText = "25-0000-000";
            txtStudentIdNo.Size = new Size(216, 23);
            txtStudentIdNo.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(10, 19);
            label18.Name = "label18";
            label18.Size = new Size(79, 15);
            label18.TabIndex = 11;
            label18.Text = "School ID No.";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.Simple;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "CAMP - College of Allied Medical Professions", "CAS - College of Arts and Science", "CBA - College of Business and Accountancy", "CCS - College of Computer Studies", "CEA - College of Enigeering and Architecture", "CON - College of Nursing" });
            comboBox2.Location = new Point(10, 151);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(300, 23);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "CCS - College of Computer Studies";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 133);
            label17.Name = "label17";
            label17.Size = new Size(47, 15);
            label17.TabIndex = 11;
            label17.Text = "College";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Checked = true;
            checkBox6.CheckState = CheckState.Checked;
            checkBox6.Location = new Point(235, 266);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(55, 19);
            checkBox6.TabIndex = 10;
            checkBox6.Text = "None";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(6, 323);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(383, 45);
            trackBar1.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 294);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 8;
            label8.Text = "Satisfaction";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(116, 266);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(58, 19);
            checkBox5.TabIndex = 7;
            checkBox5.Text = "Music";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(10, 266);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(59, 19);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "Sports";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(235, 241);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(68, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Gaming";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(116, 241);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(113, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Problem Solving";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(10, 241);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Programming";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 217);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 2;
            label7.Text = "Interests";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bachelor of Science In Computer Science", "Bachelor of Science In Information Technology", "Bachelor of Multimedia Arts" });
            comboBox1.Location = new Point(10, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Bachelor of Science In Computer Science";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 76);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 0;
            label6.Text = "Course";
            label6.Click += label6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateBirth);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnFemale);
            groupBox1.Controls.Add(btnMale);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPhoneNo);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 199);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateBirth
            // 
            dateBirth.Location = new Point(6, 157);
            dateBirth.MaxDate = new DateTime(2012, 12, 31, 0, 0, 0, 0);
            dateBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(200, 23);
            dateBirth.TabIndex = 10;
            dateBirth.Value = new DateTime(2012, 12, 31, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 139);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 9;
            label5.Text = "Date of Birth";
            // 
            // btnFemale
            // 
            btnFemale.AutoSize = true;
            btnFemale.Location = new Point(287, 98);
            btnFemale.Name = "btnFemale";
            btnFemale.Size = new Size(63, 19);
            btnFemale.TabIndex = 8;
            btnFemale.TabStop = true;
            btnFemale.Text = "Female";
            btnFemale.UseVisualStyleBackColor = true;
            btnFemale.CheckedChanged += btnFemale_CheckedChanged;
            // 
            // btnMale
            // 
            btnMale.AutoSize = true;
            btnMale.Location = new Point(230, 98);
            btnMale.Name = "btnMale";
            btnMale.Size = new Size(51, 19);
            btnMale.TabIndex = 7;
            btnMale.TabStop = true;
            btnMale.Text = "Male";
            btnMale.UseVisualStyleBackColor = true;
            btnMale.CheckedChanged += btnMale_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 76);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(6, 94);
            txtPhoneNo.Mask = "0000 000 0000";
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.PromptChar = 'X';
            txtPhoneNo.Size = new Size(194, 23);
            txtPhoneNo.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(150, 37);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Juan";
            txtFirstName.Size = new Size(216, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(6, 37);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "dela Cruz";
            txtLastName.Size = new Size(127, 23);
            txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 19);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Phone No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Last Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Summary";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.Location = new Point(567, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 206);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(satisfaction);
            groupBox4.Controls.Add(label27);
            groupBox4.Controls.Add(college);
            groupBox4.Controls.Add(label26);
            groupBox4.Controls.Add(listBox1);
            groupBox4.Controls.Add(course);
            groupBox4.Controls.Add(label01);
            groupBox4.Controls.Add(studentIdNo);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Location = new Point(7, 218);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(531, 196);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Academic Information";
            // 
            // satisfaction
            // 
            satisfaction.AutoSize = true;
            satisfaction.Location = new Point(298, 137);
            satisfaction.Name = "satisfaction";
            satisfaction.Size = new Size(10, 15);
            satisfaction.TabIndex = 14;
            satisfaction.Text = " ";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(295, 122);
            label27.Name = "label27";
            label27.Size = new Size(68, 15);
            label27.TabIndex = 13;
            label27.Text = "Satisfaction";
            // 
            // college
            // 
            college.AutoSize = true;
            college.Location = new Point(11, 137);
            college.Name = "college";
            college.Size = new Size(10, 15);
            college.TabIndex = 12;
            college.Text = " ";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(12, 122);
            label26.Name = "label26";
            label26.Size = new Size(47, 15);
            label26.TabIndex = 11;
            label26.Text = "College";
            label26.Click += label26_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(295, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(215, 79);
            listBox1.TabIndex = 10;
            // 
            // course
            // 
            course.AutoSize = true;
            course.Location = new Point(11, 85);
            course.Name = "course";
            course.Size = new Size(10, 15);
            course.TabIndex = 9;
            course.Text = " ";
            // 
            // label01
            // 
            label01.AutoSize = true;
            label01.Location = new Point(11, 70);
            label01.Name = "label01";
            label01.Size = new Size(44, 15);
            label01.TabIndex = 8;
            label01.Text = "Course";
            // 
            // studentIdNo
            // 
            studentIdNo.AutoSize = true;
            studentIdNo.Location = new Point(11, 34);
            studentIdNo.Name = "studentIdNo";
            studentIdNo.Size = new Size(10, 15);
            studentIdNo.TabIndex = 7;
            studentIdNo.Text = " ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(295, 19);
            label15.Name = "label15";
            label15.Size = new Size(51, 15);
            label15.TabIndex = 6;
            label15.Text = "Interests";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 19);
            label14.Name = "label14";
            label14.Size = new Size(84, 15);
            label14.TabIndex = 5;
            label14.Text = "Student ID No.";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateOfBirth);
            groupBox3.Controls.Add(gender);
            groupBox3.Controls.Add(phoneNo);
            groupBox3.Controls.Add(firstName);
            groupBox3.Controls.Add(lastName);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(7, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(531, 206);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personal Information";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dateOfBirth
            // 
            dateOfBirth.AutoSize = true;
            dateOfBirth.Location = new Point(12, 164);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(10, 15);
            dateOfBirth.TabIndex = 9;
            dateOfBirth.Text = " ";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Location = new Point(12, 124);
            gender.Name = "gender";
            gender.Size = new Size(10, 15);
            gender.TabIndex = 8;
            gender.Text = " ";
            // 
            // phoneNo
            // 
            phoneNo.AutoSize = true;
            phoneNo.Location = new Point(12, 80);
            phoneNo.Name = "phoneNo";
            phoneNo.Size = new Size(10, 15);
            phoneNo.TabIndex = 7;
            phoneNo.Text = " ";
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(154, 34);
            firstName.Name = "firstName";
            firstName.Size = new Size(10, 15);
            firstName.TabIndex = 6;
            firstName.Text = " ";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(12, 34);
            lastName.Name = "lastName";
            lastName.Size = new Size(10, 15);
            lastName.TabIndex = 5;
            lastName.Text = " ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(154, 19);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 1;
            label10.Text = "First Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 149);
            label13.Name = "label13";
            label13.Size = new Size(73, 15);
            label13.TabIndex = 4;
            label13.Text = "Date of Birth";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 19);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 0;
            label9.Text = "Last Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 109);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 3;
            label12.Text = "Gender";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 65);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 2;
            label11.Text = "Phone No.";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 425);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information";
            Load += Form1_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private RadioButton btnFemale;
        private RadioButton btnMale;
        private Label label4;
        private MaskedTextBox txtPhoneNo;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private DateTimePicker dateBirth;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private TrackBar trackBar1;
        private Label label8;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label7;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private CheckBox checkBox6;
        private Label label9;
        private Label label12;
        private Label label11;
        private Label label10;
        private GroupBox groupBox3;
        private Label label13;
        private PictureBox pictureBox2;
        private Label lastName;
        private ComboBox comboBox2;
        private Label label17;
        private TextBox txtStudentIdNo;
        private Label label18;
        private Label dateOfBirth;
        private Label gender;
        private Label phoneNo;
        private Label firstName;
        private GroupBox groupBox4;
        private Label college;
        private Label label26;
        private ListBox listBox1;
        private Label course;
        private Label label01;
        private Label studentIdNo;
        private Label label15;
        private Label label14;
        private Label satisfaction;
        private Label label27;
    }
}
