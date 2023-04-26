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
            //get parameters fromthe form and pass them to the web service
            string shape = DropDownList1.Text;
            string text = DropDownList4.Text;

            string hight = TextBox1.Text;
            string width = TextBox2.Text;
            // call the web service
            BrailleService.BrailleServiceSoapClient brailleService = new BrailleService.BrailleServiceSoapClient();
            
            if (shape == "Circle")
            {
                double result = brailleService.CalculateCircleArea(Convert.ToDouble(hight));
                Label4.Text = result.ToString();
                Label8.Text = "Circle";
                Image2.ImageUrl = "https://webstockreview.net/images/dot-clipart-vector-15.png";
            }

            if (shape == "Triangle")
            {
                double result = brailleService.CalculateTriangleArea(Convert.ToDouble(hight), Convert.ToDouble(width));
                Label4.Text = result.ToString();
                Label8.Text = "Triangle";
                Image2.ImageUrl = "https://i.stack.imgur.com/dfeIy.png";
            }

            if (shape == "Rectangle")
            {
                double result = brailleService.CalculateRectangleArea(Convert.ToDouble(hight), Convert.ToDouble(width));
                Label4.Text = result.ToString();
                Label8.Text = "Rectangle";
                Image2.ImageUrl = "https://th.bing.com/th/id/R.33dcf6fb771af1c13e82563172b4bcb1?rik=hp0FGNMmz2ORYA&riu=http%3a%2f%2f2.bp.blogspot.com%2f-SFCKPO4--EQ%2fT38jYg5y6mI%2fAAAAAAAAEJQ%2fKSO58dFXynE%2fs1600%2fPicture1.png&ehk=TJFkGMm1V4BEVqCURDXnQ9f%2f291yhnUDO1HXA1lv4C0%3d&risl=&pid=ImgRaw&r=0";
            }


            if (text == "A")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "A";
                Image2.ImageUrl = "";
            }

            if (text == "B")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "B";
                Image2.ImageUrl = "";
            }
            if (text == "C")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "C";
                Image2.ImageUrl = "";
            }
            if (text == "D")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "D";
                Image2.ImageUrl = "";
            }
            
            if (text == "E")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "E";
                Image2.ImageUrl = "";
            }
            if (text == "F")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "F";
                Image2.ImageUrl = "";
            }
            if (text == "G")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "G";
                Image2.ImageUrl = "";
            }
            if (text == "H")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "H";
                Image2.ImageUrl = "";
            }

            if (text == "I")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "I";
                Image2.ImageUrl = "";
            }

            if (text == "J")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "J";
                Image2.ImageUrl = "";
            }

            if (text == "K")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "K";
                Image2.ImageUrl = "";
            }

            if (text == "L")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "L";
                Image2.ImageUrl = "";
            }

            if (text == "M")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "M";
                Image2.ImageUrl = "";
            }

            if (text == "N")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "N";
                Image2.ImageUrl = "";
            }

            if (text == "O")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "O";
                Image2.ImageUrl = "";
            }

            if (text == "P")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "P";
                Image2.ImageUrl = "";
            }

            if (text == "Q")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "Q";
                Image2.ImageUrl = "";
            }

            if (text == "R")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "R";
                Image2.ImageUrl = "";
            }

            if (text == "S")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "S";
                Image2.ImageUrl = "";
            }

            if (text == "T")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "T";
                Image2.ImageUrl = "";
            }

            if (text == "U")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "U";
                Image2.ImageUrl = "";
            }

            if (text == "V")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "V";
                Image2.ImageUrl = "";
            }

            if (text == "W")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "W";
                Image2.ImageUrl = "";
            }

            if (text == "X")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "X";
                Image2.ImageUrl = "";
                
            }

            if (text == "Y")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "Y";
                Image2.ImageUrl = "";
            }

            if (text == "Z")
            {
                string result = brailleService.ConvertToBraille(text);
                Label4.Text = result.ToString();
                Label8.Text = "Z";
                Image2.ImageUrl = "";
            }


            GridView2.DataSource = brailleService.GetCalculations();
            GridView2.DataBind();





        }

       
    }
}