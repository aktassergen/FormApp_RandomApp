namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool result1=int.TryParse(textBox1.Text, out int number1);
            bool result2=int.TryParse(textBox2.Text, out int number2);

            if(result1==true && result2 == true)
            {
                Random rnd = new Random();
                int rnd2 = rnd.Next(number1,number2+1);
                label4.Text = rnd2.ToString();
            }
            else
            {
                if(result1==false)
                MessageBox.Show("Could you please, you can write the Min Value INTERNAL ");
                else
                MessageBox.Show("Could you please, you can write the Max Value INTERNAL ");

            }






        }
    }
}