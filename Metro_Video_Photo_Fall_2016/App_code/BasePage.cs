using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro_Video_Photo_Fall_2016.App_code
{
    public class BasePage : System.Web.UI.Page
    {
        public BasePage()
        {
            //Call Check for Page Title Event
            this.PreRender += Page_PreRender;
        }

        #region Preferred Theme
        //private void Page_PreInit(object sender, EventArgs e)
        //{
        //  HttpCookie preferredTheme = Request.Cookies.Get("PreferredTheme");
        //  if (preferredTheme != null)
        //  {
        //    this.Page.Theme = preferredTheme.Value;
        //  }
        //}
        #endregion

        #region Check for Page Title
        private void Page_PreRender(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Title) || this.Title.Equals("Untitled Page", StringComparison.CurrentCultureIgnoreCase))
            {
                throw new Exception(
                "Page title cannot be \"Untitled Page\" or an empty string.");
            }
        }
        #endregion
    }
}