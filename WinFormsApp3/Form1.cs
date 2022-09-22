using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        public int jero = 0;
        public int zero = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( zero == 1 && jero == 1)
            {
                MessageBox.Show("Podanê imiê: " + textBox1.Text + " Podane nazwisko: " + textBox2.Text + " a podana data to: " + dateTimePicker1.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            string jd = textBox1.Text;  
            if (jd == "")
            {
                MessageBox.Show("Dane w 1 tabelce s¹ wprowadzone niepoprawnie, spróbuj ponownie");
                zero = 0;
            }
            else
            {
                zero = 1;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            string bd = textBox2.Text;
            if (bd == "")
            {
                MessageBox.Show("Dane w 2 tabelce s¹ wprowadzone niepoprawnie, spróbuj ponownie");
                jero = 0;
            }
            else
            {
                jero = 1;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}