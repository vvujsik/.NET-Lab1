using Lab1;
using System.Drawing;

namespace GuiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ilosc_text_TextChanged(object sender, EventArgs e)
        {
            int wynik;
            result_text.Text = string.Empty;
            if (int.TryParse(ilosc_text.Text, out wynik))
            {
                ilosc_text.BackColor = Color.White;
            }
            else
            {
                ilosc_text.BackColor = Color.Red;
            }
            if (int.TryParse(ilosc_text.Text, out int n) && int.TryParse(ziarno_text.Text, out int seed))
            {
                Problem problem = new Problem(n, seed);
                textBox1.Text = problem.ToString();
            }
        }

        private void ziarno_text_TextChanged(object sender, EventArgs e)
        {
            result_text.Text = string.Empty;
            if (int.TryParse(ziarno_text.Text, out int wynik))
            {
                ziarno_text.BackColor = Color.White;
            }
            else
            {
                ziarno_text.BackColor = Color.Red;
            }
            if (int.TryParse(ilosc_text.Text, out int n) && int.TryParse(ziarno_text.Text, out int seed))
            {
                Problem problem = new Problem(n,seed);
                textBox1.Text = problem.ToString();
            }
        }

        private void pojemnosc_text_TextChanged(object sender, EventArgs e)
        {
            result_text.Text = string.Empty;
            int wynik;
            if (int.TryParse(pojemnosc_text.Text, out wynik))
            {
                pojemnosc_text.BackColor = Color.White;
            }
            else
            {
                pojemnosc_text.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, seed, capacity;
            if (int.TryParse(pojemnosc_text.Text,out capacity) && int.TryParse(ilosc_text.Text, out n) && int.TryParse(ziarno_text.Text, out seed))
            {
                Problem problem = new Problem(n, seed);
                Result wynik = problem.solve(capacity);
                result_text.Text = wynik.ToString();
            }
        }
    }
}
