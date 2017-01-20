using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = MapPath("~/Uploads");
        string[] files = Directory.GetFiles(path);
        ddlfiles.DataSource = files;
        ddlfiles.DataBind();
    }
}