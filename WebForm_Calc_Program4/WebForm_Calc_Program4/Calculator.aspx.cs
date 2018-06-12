using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_Calc_Program4
{
    public partial class Calculator : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["value"] = "0";
                Session["calc"] = "";
                Session["calc_pressed"] = "0";
            }
        }
        protected void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || (Session["calc_pressed"].ToString() == "1"))
                result.Text = "";

            Session["calc_pressed"] = "0";
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }


        protected void btnClear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            Session["value"] = "0";
            Session["calc"] = "";
            Session["calc_pressed"] = "0";
        }

        protected void Calc_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Session["calc"] = b.Text;
            Session["value"] = result.Text;
            Session["calc_pressed"] = "1";
        }

        protected void btnEqual_Click(object sender, EventArgs e)
        {
            switch (Session["calc"].ToString())
            {
                case "+":
                    result.Text = (Double.Parse(Session["value"].ToString()) + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (Double.Parse(Session["value"].ToString()) - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (Double.Parse(Session["value"].ToString()) * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (Double.Parse(Session["value"].ToString()) / Double.Parse(result.Text)).ToString();
                    break;

            }
           
        }
    }
}