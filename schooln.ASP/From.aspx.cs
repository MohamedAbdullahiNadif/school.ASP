using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schooln.ASP
{
    public partial class From : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            indx form2 = new indx();
            indx.ShowDialog();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
   
        }
    }
}