namespace SayıTopForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int teksayılar = 0;
        int ciftsayılar = 0;
        int sayi;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            sayi = Convert.ToInt32(textBox1.Text);

            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    ciftsayılar = ciftsayılar + i;
                    label4.Text = ciftsayılar.ToString();

                }
                else
                {
                    teksayılar = teksayılar + i;
                    label3.Text = teksayılar.ToString();
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
