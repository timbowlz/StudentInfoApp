using System.Windows.Forms;

namespace StudentInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Image Selection and Save Handler
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; //File Types for Images
            openFileDialog1.Title = "Select a Profile Image"; // Dialog Title
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName); //Getting the Image File
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Properties.Settings.Default.ProfileImagePath = openFileDialog1.FileName; // Saving the Image Path to Settings
                Properties.Settings.Default.Save();
            }
        }

        // Image Load Handler
        private void Form1_Load_1(object sender, EventArgs e)
        {
            string imagePath = Properties.Settings.Default.ProfileImagePath;
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        // CheckBox Handlers
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var cb in new[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 })
                if (checkBox6.Checked)
                {
                    cb.Checked = false;
                }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                checkBox6.Checked = false;
            }
        }

        // Radio Button Validation Handler
        bool radioSelected = false;
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            radioSelected = groupBox1.Controls.OfType<RadioButton>().Any(rb => rb.Checked);
        }

        // Submition Handler
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNo.Text) ||
                pictureBox1.Image == null ||
                !radioSelected)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Data submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}