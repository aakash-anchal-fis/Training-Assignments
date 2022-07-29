using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "Select", "IIT Madras", "III Mumbai", "IIT Delhi", "IIT Kanpur", "IIT Kharagpur", "IIT Hyderabad", "IIT Goa" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "IIT Madras")
            {
                Label1.Text = "RANK 1";
            }
            else if (DropDownList1.Text == "III Mumbai")
            {
                Label1.Text = "RANK 2";
            }
            else if (DropDownList1.Text == "IIT Delhi")
            {
                Label1.Text = "RANK 3";
            }
            else if (DropDownList1.Text == "IIT Kanpur")
            {
                Label1.Text = "RANK 4";
            }
            else if (DropDownList1.Text == "IIT Kharagpur")
            {
                Label1.Text = "RANK 5";
            }
            else if (DropDownList1.Text == "IIT Hyderabad")
            {
                Label1.Text = "RANK 6";
            }
            else if (DropDownList1.Text == "IIT Goa")
            {
                Label1.Text = "RANK 7";
            }
            else if (DropDownList1.Text == "Select")
            {
                Label1.Text = "Select any college from the list and click on the submit button.";
            }
            else
                Label1.Text = "";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".png";
        }
    }
}