using System.Globalization;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        double numero1; double numero2; string operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(textBox1.Text); operacion = "+"; textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(textBox1.Text); operacion = "-"; textBox1.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(textBox1.Text); operacion = "*"; textBox1.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(textBox1.Text); operacion = "/"; textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(textBox1.Text); operacion = "^"; textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(textBox1.Text); operacion = "√"; textBox1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double resultado = 0; if (operacion == "√") { resultado = Math.Sqrt(numero1); } else { numero2 = double.Parse(textBox1.Text); if (operacion == "+") { resultado = numero1 + numero2; } else if (operacion == "-") { resultado = numero1 - numero2; } else if (operacion == "*") { resultado = numero1 * numero2; } else if (operacion == "/") { if (numero2 == 0) { MessageBox.Show("No se puede dividir entre cero"); return; } resultado = numero1 / numero2; } else if (operacion == "^") { resultado = Math.Pow(numero1, numero2); } }
            textBox1.Text = resultado.ToString();
        }
        

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); numero1 = 0; numero2 = 0; operacion = "";
        }
    }
}

