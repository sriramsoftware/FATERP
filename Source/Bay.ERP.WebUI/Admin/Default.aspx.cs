// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 30-Nov-2011, 02:42:57




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Web.UI.WebControls;

namespace Bay.ERP.Web.UI
{
    public partial class AdminDefaultPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "AdminDefaultEntity_Page";
            }
        }

        //public override string WebUserControlPaths
        //{
        //    get
        //    {
        //        return "~/Controls/BD/BDProject.ascx;";
        //    }
        //}

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Default", " - ", base.Page.Title);

            //ucBDProjectEntity.ContentHolderPageUrl = "~/Admin/Default.aspx";

            if (!IsPostBack)
            {
            }
        }

        #endregion
    }
}
