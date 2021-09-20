using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal decValueA = 0m;
            decimal decValueB = 0m;
            decimal decAdd = 0m;
            decValueA = Convert.ToDecimal(TextBox1.Text);
            decValueB = Convert.ToDecimal(TextBox2.Text);
            decAdd = decValueA + decValueB;
            Label3.Text = Convert.ToString(decAdd);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            decimal decValueA = 0m;
            decimal decValueB = 0m;
            decimal decSub = 0m;
            decValueA = Convert.ToDecimal(TextBox1.Text);
            decValueB = Convert.ToDecimal(TextBox2.Text);
            decSub = decValueA - decValueB;
            Label4.Text = Convert.ToString(decSub);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            decimal decValueA = 0m;
            decimal decValueB = 0m;
            decimal decMul = 0m;
            decValueA = Convert.ToDecimal(TextBox1.Text);
            decValueB = Convert.ToDecimal(TextBox2.Text);
            decMul = decValueA * decValueB;
            Label5.Text = Convert.ToString(decMul);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                decimal decValueA = 0m;
                decimal decValueB = 0m;
                decimal decDiv = 0m;
                decValueA = Convert.ToDecimal(TextBox1.Text);
                decValueB = Convert.ToDecimal(TextBox2.Text);
                decDiv = decValueA / decValueB;
                Label6.Text = Convert.ToString(decDiv);
            }
            catch
            {
                Label6.Text = "CANT DIVIDE BY ZERO";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            decimal decValueA = 0m;
            decimal decValueB = 0m;
            decimal decC = 0m;
            decValueA = Convert.ToDecimal(TextBox1.Text);
            decValueB = Convert.ToDecimal(TextBox2.Text);
            decC = decValueA + decValueB;
            Label3.Text = Convert.ToString(decC);
            decC = decValueA -decValueB;
            Label4.Text = Convert.ToString(decC);
            decC = decValueA * decValueB;
            Label5.Text = Convert.ToString(decC);
            decC = decValueA / decValueB;
            Label6.Text = Convert.ToString(decC);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";

        }
    }
}