using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBL_Engenharia
{
    public partial class wfrmEquipamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add(new ListItem { Text = "gil", Value = "1" });
        }
    }
}