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

                Session["operando1"] = Convert.ToInt32(textBox.Text);
                textBox.Text = "";
                Session["operador"] = btn.Text[0];
                textBox.Text += Session["operador"];
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
                // Si no se ha elegido un operador sale error
                if (Session["operador"] == null)
                    throw new FormatException();

                Session["operando2"] = Convert.ToInt32(textBox.Text);
                textBox.Text = "";

                // Hacemos calculo segun el operador
                switch (Session["operador"])
                {
                    case '+':
                        Session["resultado"] = (int) Session["operando1"] + (int) Session["operando2"];
                        break;

                    case '-':
                        Session["resultado"] = (int) Session["operando1"] - (int) Session["operando2"];
                        break;

                    case '*':
                        Session["resultado"] = (int) Session["operando1"] * (int) Session["operando2"];
                        break;

                    case '/':
                        Session["resultado"] = (int) Session["operando1"] / (int) Session["operando2"];
                        break;

                    default:
                        break;
                }

                // Mostramos resultado, lo guardamos en primer operando y borramos el operador y segundo operando
                textBox.Text += Session["resultado"];
                Session["operando1"] = Session["resultado"];

                Session["operador"] = null;
                Session["operando2"] = null;
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
            Session["operador"] = null;
            Session["operando1"] = null;
            Session["operando2"] = null;
            Session["resultado"] = null;
        }
    }
}