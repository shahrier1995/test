using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hudai
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s1 = "abcd";
            string s2 = "acdqrt";
            var both = s1.Intersect(s2);
            var count = both.Count();
            Console.WriteLine(both);
            Label1.Text = string.Join(",", both.ToArray());

        }
    }
}