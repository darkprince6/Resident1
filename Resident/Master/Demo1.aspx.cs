﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Resident.Master
{
    public partial class Demo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDemo1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            lblDemo1.Visible = true;
        }
    }
}