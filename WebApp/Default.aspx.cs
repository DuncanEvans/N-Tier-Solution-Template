using BusinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BusinessLogic.BusinessLogic bll = new BusinessLogic.BusinessLogic();
            dishe dish = bll.GetRandomDish();

            //Label1.Visible = true;
            //Label1.Text = "Main: " + dish.name;
        }
    }
}