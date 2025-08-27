namespace StudentInfoApp
{
    partial class Form1
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
            tabPage3 = new TabPage();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox1.SuspendLayout();
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
            button1.Location = new Point(103, 390);
            button1.Name = "button1";
            button1.Size = new Size(162, 23);
            button1.TabIndex = 3;
            button1.Text = "Upload Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(103, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 169);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
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
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Checked = true;
            checkBox6.CheckState = CheckState.Checked;
            checkBox6.Location = new Point(235, 125);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(55, 19);
            checkBox6.TabIndex = 10;
            checkBox6.Text = "None";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(6, 196);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(383, 45);
            trackBar1.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 167);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 8;
            label8.Text = "Satisfaction";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(116, 125);
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
            checkBox4.Location = new Point(10, 125);
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
            checkBox3.Location = new Point(235, 100);
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
            checkBox2.Location = new Point(116, 100);
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
            checkBox1.Location = new Point(10, 100);
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
            label7.Location = new Point(6, 76);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 2;
            label7.Text = "Interests";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bachelor of Science In Information Technology", "Bachelor of Multimedia Arts" });
            comboBox1.Location = new Point(6, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Bachelor of Science In Computer Science";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 0;
            label6.Text = "Course";
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
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(200, 23);
            dateBirth.TabIndex = 10;
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
            txtPhoneNo.PromptChar = '0';
            txtPhoneNo.Size = new Size(194, 23);
            txtPhoneNo.TabIndex = 5;
            txtPhoneNo.Text = " 9121231234";
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Summary";
            tabPage2.UseVisualStyleBackColor = true;
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
    }
}
