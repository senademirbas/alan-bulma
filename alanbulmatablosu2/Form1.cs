namespace alanbulmatablosu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kare
            int kenarkare = Convert.ToInt32((textBox1).Text);
            int karealan = kenarkare * kenarkare;
            labelkare.Text = karealan.ToString();

            //dikd�rtgen
            int uzunkenar = Convert.ToInt32((textBox2).Text);
            int k�sakenar = Convert.ToInt32((textBox3).Text);
            int dikd�rtgenalan = uzunkenar * k�sakenar;
            labeldikd�rtgen.Text = dikd�rtgenalan.ToString();

            //daire
            double yaricap = Convert.ToDouble(textBox4.Text);
            double dairealan = Math.PI * (yaricap * yaricap);
            labeldaire.Text = dairealan.ToString("F3");

        }
    }
}
