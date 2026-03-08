double hasilSimpan = 0;
bool sedangInputAngka = true;
namespace TP_MODUL3_103022430010 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (!sedangInputAngka) {
                labelOutput.Text = "";
                sedangInputAngka = true;
            }
            if (labelOutput.Text == "0") {
                labelOutput.Text = tombol.Text;
            } else {
                labelOutput.Text += tombol.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            hasilSimpan += double.Parse(labelOutput.Text);
            labelOutput.Text = hasilSimpan.ToString();
            sedangInputAngka = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hasilSimpan += double.Parse(labelOutput.Text);

            labelOutput.Text = hasilSimpan.ToString();

            hasilSimpan = 0;
            sedangInputAngka = false;
        }
    }
}
