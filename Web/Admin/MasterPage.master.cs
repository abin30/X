﻿using System;
using NewLife.Reflection;
using System.Web.UI.HtmlControls;
using System.Reflection;

public partial class Admin_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //PropertyInfo pix = PropertyInfoX.Create(Page.GetType(), "Navigation");
        //if (pix != null) Navigation.Text = (String)pix.GetValue(Page);
        Navigation.Text = (String)Reflect.GetValue(Page, "Navigation", false);

        Page.ClientScript.RegisterClientScriptInclude("jquery", ResolveUrl("~/Scripts/jquery-1.4.1.min.js"));
        Page.ClientScript.RegisterClientScriptInclude("adminstyle", ResolveUrl("~/Scripts/adminstyle.js"));
        //Page.ClientScript.RegisterClientScriptInclude("css", "~/Admin/images/css.css");

        HtmlLink link = new HtmlLink();
        link.Href = ResolveUrl("~/Admin/images/css.css");
        link.Attributes["rel"] = "stylesheet";
        link.Attributes["type"] = "text/css";
        Page.Header.Controls.Add(link);
    }
}