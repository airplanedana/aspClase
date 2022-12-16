using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPClase
{
    public partial class Calculadora : System.Web.UI.Page
    {
        static private int operando1, operando2, resultado;
        static private char operador = ' ';

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void clickNumero(object sender, EventArgs e)
        {
            Button btn = (Button) sender;

            if ((textBox.Text == "+") || (textBox.Text == "-") || (textBox.Text == "*") || (textBox.Text == "/"))
            {
                textBox.Text = "";
                textBox.Text += btn.Text;
            }
            else
                textBox.Text += btn.Text;

            errores.Text = "";
        }

        protected void clickOperacion(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                operando1 = Convert.ToInt32(textBox.Text);
                textBox.Text = "";
                operador = btn.Text[0];
                textBox.Text += operador;
            }
            catch (FormatException ex)
            {
                errores.Text = "Debe elegir un operando antes del operador.";
            }
            catch (Exception ex)
            {
                errores.Text = "Se ha producido un error:\n" + ex.Message;
            }
        }

        protected void clickResultado(object sender, EventArgs e)
        {
            try
            {
                if (operador == ' ')
                    throw new FormatException();
                
                operando2 = Convert.ToInt32(textBox.Text);
                textBox.Text = "";

                switch (operador)
                {
                    case '+':
                        resultado = operando1 + operando2;
                        break;

                    case '-':
                        resultado = operando1 - operando2;
                        break;

                    case '*':
                        resultado = operando1 * operando2;
                        break;

                    case '/':
                        resultado = operando1 / operando2;
                        break;

                    default:
                        break;
                }

                textBox.Text += resultado;
                operando1 = resultado;
            }
            catch (FormatException ex)
            {
                errores.Text = "Debe elegir dos operandos y un operador para calcular el resultado.";
            }
            catch (Exception ex)
            {
                errores.Text = "Se ha producido un error:\n" + ex.Message;
            }
        }
        
        protected void clickClear(object sender, EventArgs e)
        {
            textBox.Text = "";
            errores.Text = "";
            operador = ' ';
            operando1 = 0;
            operando2 = 0;
            resultado = 0;
        }
    }
}