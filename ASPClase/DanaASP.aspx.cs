using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ASPClase
{
    public partial class DanaASP : System.Web.UI.Page
    {
        Dictionary<string, DateTime> birthdays = new Dictionary<string, DateTime>();
        string connectionStr = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=cumples;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            // Hacemos connexion BBDD
            SqlConnection con = new SqlConnection(connectionStr);
            string query = "SELECT * FROM persona";
            SqlDataAdapter adpt = new SqlDataAdapter(query, con);

            // Añadimos los cumpleaños al diccionario
            birthdays.Add("Dana", new DateTime(1900, 1, 16));
            birthdays.Add("Marc", new DateTime(1900, 5, 30));
            birthdays.Add("Jordi", new DateTime(1900, 12, 22));
            birthdays.Add("Sergi", new DateTime(1900, 8, 12));
            birthdays.Add("Michael", new DateTime(1900, 12, 10));
            birthdays.Add("Daniel", new DateTime(1900, 7, 1));

            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "nombre";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM persona where id = '" + DropDownList1.SelectedValue + "'", con);
            SqlDataAdapter Adpt = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            Adpt.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            Label1.Text = DropDownList1.SelectedValue;
        }

        public void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            ShowDate.Text = "Has seleccionado: " + Calendar1.SelectedDate.ToString("D");

            foreach (var person in birthdays)
            {
                if (person.Value.Month == Calendar1.SelectedDate.Month && person.Value.Day == Calendar1.SelectedDate.Day)
                {
                    ShowDate.Text += "<br> Es el cumple de " + person.Key;
                }
            }
        }
    }
}