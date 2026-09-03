using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioBryanSincal15_VID
{
    public partial class Form1 : Form
    {
        private enum Entrada
        {
            Ninguna,
            Digito,
            Operador,
            CE
        }
        private Entrada ultimaEntrada;
        private bool comaDecimal;
        private char operador;
        private double operador1;
        private double operador2;
        private double memoria = 0;
        public Form1()
        {
            InitializeComponent();
            ultimaEntrada = Entrada.Ninguna;
            comaDecimal = false;
            operador = '\0';
            operador1 = 0;
            operador2 = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (ultimaEntrada != Entrada.Digito)
                return;

            operador2 = double.Parse(pantalla.Text);

            double resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = operador1 + operador2;
                    break;

                case '-':
                    resultado = operador1 - operador2;
                    break;

                case '*':
                    resultado = operador1 * operador2;
                    break;

                case '/':
                    if (operador2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero.");
                        return;
                    }

                    resultado = operador1 / operador2;
                    break;

                case '%':
                    resultado = operador1 % operador2;
                    break;

                default:
                    return;
            }

            pantalla.Text = resultado.ToString();

            operador1 = resultado;
            ultimaEntrada = Entrada.Digito;
            comaDecimal = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string texto = pantalla.Text;

            int posicion = -1;

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                if (texto[i] == '+' ||
                    texto[i] == '-' ||
                    texto[i] == '*' ||
                    texto[i] == '/')
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion == -1)
            {
                pantalla.Text = "0";
            }
            else
            {
                pantalla.Text = texto.Substring(0, posicion + 1) + "0";
            }

            ultimaEntrada = Entrada.CE;
            comaDecimal = false;

        }

        private void btDigito_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (ultimaEntrada != Entrada.Digito)
            {
                if (boton.Text == "0")
                    return;

                pantalla.Text = "";
                ultimaEntrada = Entrada.Digito;
            }

            pantalla.Text += boton.Text;
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (!comaDecimal)
            {
                pantalla.Text += ",";
                comaDecimal = true;

            }
        }

        private void btOperacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            // Guardar el primer número
            if (ultimaEntrada == Entrada.Digito)
            {
                operador1 = double.Parse(pantalla.Text);
            }

            // Guardar el operador
            operador = boton.Text[0];

            ultimaEntrada = Entrada.Operador;
            comaDecimal = false;
        }

        private void btC_Click(object sender, EventArgs e)
        {
            pantalla.Text = "0";

            operador1 = 0;
            operador2 = 0;
            operador = '\0';

            ultimaEntrada = Entrada.Ninguna;
            comaDecimal = false;
        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
