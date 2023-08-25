using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WingtipToys
{
    public partial class FormTest : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string a, b;
        protected void Button1_Click(object sender, EventArgs e)
        {
            //a = TextBox1.Text;
            //b = TextBox2.Text;
            //TextBox1.Text = TextBox2.Text = string.Empty;
            ViewState["username"] = TextBox1.Text;
            ViewState["password"] = TextBox2.Text;
            TextBox1.Text = TextBox2.Text = string.Empty;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(ViewState["username"] != null)
            {
                TextBox1.Text = ViewState["username"].ToString();
            }
            if(ViewState["password"] != null)
            {
                TextBox2.Text = ViewState["password"].ToString();
            }
            
        }




    }
}