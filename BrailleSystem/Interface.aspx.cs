using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BrailleSystem
{
    public partial class Interface : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.Text == "Select")
            {
                Label5.Visible = false;
                Label6.Visible = false;
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                DropDownList2.Visible = false;
                DropDownList3.Visible = false;
            }
            if (DropDownList1.Text == "Circle")
            {
                Label5.Text = "Radius";
                Label5.Visible = true;
                Label6.Visible = false;
                TextBox1.Visible = true;
                TextBox2.Visible = false;
                DropDownList2.Visible = true;
                DropDownList3.Visible = false;
            }
            if (DropDownList1.Text == "Triangle") 
            {
                Label5.Text = "Hight";
                Label5.Visible = true;
                Label6.Visible = true;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = true;

            }
            if (DropDownList1.Text == "Rectangle")
            {

                Label5.Text = "Hight";
                Label5.Visible = true;
                Label6.Visible = true;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = true;
            }
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // get parameters fromthe form and pass them to the web service
            string shape = DropDownList1.Text;
            string unit = DropDownList2.Text;
            string unit2 = DropDownList3.Text;
            string hight = TextBox1.Text;
            string width = TextBox2.Text;
            // call the web service
            BrailleService.BrailleServiceSoapClient brailleService = new BrailleService.BrailleServiceSoapClient();

            string braille = brailleService.GetBrailleDotsForShape(shape, unit, unit2, hight, width);
            // display the results
            Label4.Text = braille.ToString();


        }
    }
}