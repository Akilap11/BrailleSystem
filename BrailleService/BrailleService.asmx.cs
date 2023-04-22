using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Services;
using System.Web.UI;

namespace BrailleService
{
    /// <summary>
    /// Summary description for BrailleService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BrailleService : System.Web.Services.WebService
    {
        [WebMethod]
        public double CalculateRectangleArea(double hight, double width)
        {
            Console.WriteLine("Hight: " + hight);
            Console.WriteLine("Width: " + width);
            return hight * width;
        }

        [WebMethod]
        public double CalculateCircleArea(double radius)
        {
            Console.WriteLine("Radius: " + radius);
            return Math.PI * radius * radius;
        }

        [WebMethod]
        public double CalculateTriangleArea(double baseLength, double height)
        {
            Console.WriteLine("Base Length: " + baseLength);
            return 0.5 * baseLength * height;
        }

        [WebMethod]

        //convert A-Z characters to Braille
        public string ConvertToBraille(string text)
        {
            string braille = "";
            foreach (char c in text)
            {
                if (c == 'A')
                {
                    braille += "⠃";
                }
                else if (c == 'B')
                {
                    braille += "⠉";
                }
                else if (c == 'C')
                {
                    braille += "⠙";
                }
                else if (c == 'D')
                {
                    braille += "⠑";
                }
                else if (c == 'E')
                {
                    braille += "⠋";
                }
                else if (c == 'F')
                {
                    braille += "⠛";
                }
                else if (c == 'G')
                {
                    braille += "⠓";
                }
                else if (c == 'H')
                {
                    braille += "⠊";
                }
                else if (c == 'I')
                {
                    braille += "⠚";
                }
                else if (c == 'J')
                {
                    braille += "⠆";
                }
                else if (c == 'K')
                {
                    braille += "⠅";
                }
                else if (c == 'L')
                {
                    braille += "⠇";
                }
                else if (c == 'M')
                {
                    braille += "⠍";
                }
                else if (c == 'N')
                {
                    braille += "⠝";
                }
                else if (c == 'O')
                {
                    braille += "⠕";
                }
                else if (c == 'P')
                {
                    braille += "⠏";
                }
                else if (c == 'Q')
                {
                    braille += "⠟";
                }
                else if (c == 'R')
                {
                    braille += "⠗";
                }
                else if (c == 'S')
                {
                    braille += "⠎";
                }
                else if (c == 'T')
                {
                    braille += "⠞";
                }
                else if (c == 'U')
                {
                    braille += "⠥";
                }
                else if (c == 'V')
                {
                    braille += "⠧";
                }
                else if (c == 'W')
                {
                    braille += "⠺";
                }
                else if (c == 'X')
                {
                    braille += "⠭";
                }
                else if (c == 'Y')
                {
                    braille += "⠽";
                }
                else if (c == 'Z')
                {
                    braille += "⠵";
                }
                else
                {
                    braille += c;
                }



            }

            return braille;
        }

    }

}
