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
        public string Getshapevalues(string shape, string unit, string unit2, string hight, string width)
        {
          
            
            int rectangle()
            {
                int a = Convert.ToInt32(hight);
                int b = Convert.ToInt32(width);
                int c = (a * b);
                Console.WriteLine(c);
                return c;

            }
            int triangle()
            {
                int a = Convert.ToInt32(hight);
                int b = Convert.ToInt32(width);

                int c = 1 / 2 * a * b;
                Console.WriteLine(c);
                return c;

                
            }

            int circle()
            {
                int a = Convert.ToInt32(hight);

                int c = 2 * 3 * a;

                Console.WriteLine(c);
                return c;
                
            }

            if (shape == "circle")
            {
                Console.WriteLine("Circle INK values are: ");
                circle();
            }

            if (shape == "triangle")
            {
                Console.WriteLine("Triangle INK values are: ");
                triangle();
            }

            if (shape == "rectangle")
            {
                Console.WriteLine("Rectangle INK values are: ");
                rectangle();
            }

         
            return shape;
            
        }
    }
    
}
