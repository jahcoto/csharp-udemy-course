namespace CSharpUdemyCourse
{
    public partial class frmUdemyCourse : Form
    {
        public frmUdemyCourse()
        {
            InitializeComponent();
        }

        private void frmUdemyCourse_Load(object sender, EventArgs e)
        {
            this.txtName.Text = "Jonathan";
            this.txtLastName.Text = "Hernandez";
            this.txtUserName.Text = "johernandez";
            this.txtPassword.Text = "123456";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.txtDigitalClock.Text = DateTime.Now.ToString();
            if (DateTime.Now.Minute < 10)
            {
                if (DateTime.Now.Second < 10)
                {
                    this.txtDigitalClock.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour.ToString() + ":0" + DateTime.Now.Minute.ToString() + ":0" + DateTime.Now.Second.ToString();
                }
                else
                {
                    this.txtDigitalClock.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour.ToString() + ":0" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
                }
            }
            else
            {
                if (DateTime.Now.Second < 10)
                {
                    this.txtDigitalClock.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":0" + DateTime.Now.Second.ToString();
                }
                else
                {
                    this.txtDigitalClock.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled= true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the user: " + txtName.Text, "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("User Deleted!!!", "Information!");
            } 
            else 
            {
                MessageBox.Show("User Not Deleted!!!", "Information!");
            } 

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string URL = "https://d500.epimg.net/cincodias/imagenes/2016/07/04/lifestyle/1467646262_522853_1467646344_noticia_normal.jpg";
            pictureBox1.ImageLocation = URL;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int year;

            int.TryParse(this.txtYearOfBirth.Text, out year);

            int age = DateTime.Now.Year - year;

            MessageBox.Show("Your age is: " + age.ToString() + " YearsOld.");
        }
    }
}