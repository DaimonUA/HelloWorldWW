using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*  DateTime now = DateTime.Now;
              txtb_message.Text = now.ToString();*/
            Unnamed1_Click(sender, e);
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //DateTime now = DateTime.Now;
            txtb_message.Text = DateTime.Now.ToString();

        }
    }
}