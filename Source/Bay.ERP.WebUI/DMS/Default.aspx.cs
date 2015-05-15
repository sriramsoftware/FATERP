using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bay.ERP.Web.UI;

public partial class DMS_Default : BasePage
{
    #region Veriables

    #endregion

    #region Properties

    public override string UniqueKey
    {
        get
        {
            return "DMSDefaultEntity_Page";
        }
    }

    #endregion

    #region Methods



    #endregion

    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        base.Page.Title = String.Concat("Default", " - ", base.Page.Title);

        //ucCMConsultantEntity.ContentHolderPageUrl = "~/CM/CMConsultant.aspx";

        if (!IsPostBack)
        {

        }
    }

    #endregion
}