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
    }
    
}
