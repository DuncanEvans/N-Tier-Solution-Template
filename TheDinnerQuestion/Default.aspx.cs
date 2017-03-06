using BusinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheDinnerQuestion
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSkin_Click(object sender, EventArgs e)
        {
            BusinessLogic.BusinessLogic bll = new BusinessLogic.BusinessLogic();
            dishe dish = bll.GetRandomDish();

            Label1.Visible = true;
            Label1.Text = "Main: " + dish.name;
        }
    }
}