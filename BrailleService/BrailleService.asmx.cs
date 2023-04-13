using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public string GetBrailleDotsForShape(string shape, string unit,string unit2, string hight, string width)
        {
            // Define a dictionary of shape names and their corresponding Braille representations
            Dictionary<string, string> shapesToBraille = new Dictionary<string, string>()
                {
                    { "circle", "001111" },
                    { "square", "011111" },
                    { "triangle", "100000" }
                };

            // Look up the corresponding Braille representation for the selected shape
            if (shapesToBraille.TryGetValue(shape, out string braille))
            {
                // Create a label control to display the Braille dots
                System.Web.UI.WebControls.Label brailleLabel = new System.Web.UI.WebControls.Label();

                // Set the label's text to the Braille representation
                brailleLabel.Text = braille;

                // Set the label's font size and style
                brailleLabel.Font.Size = 36;
                brailleLabel.Font.Bold = true;

                // Render the Braille dots as HTML
                StringWriter stringWriter = new StringWriter();
                using (HtmlTextWriter writer = new HtmlTextWriter(stringWriter))
                {
                    brailleLabel.RenderControl(writer);
                }

                return stringWriter.ToString();
            }
            else
            {
                // Return an error message if the selected shape is not supported
                return "Error: Shape not supported.";
            }
        }
    }
    
}
