using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MaterialAdvertisement.Main;
using TTD.Common;

namespace MaterialAdvertisement
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int control = Utility.GetIntParameter("ctl");           
            Utility.LoadPageContent(this.PlaceHolder1, MainCtrlSetting.GetControlFileName((MainCtrlSetting.ControlName)control, AdminSite.Global.MainControlsPath));
        }
    }
}