// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class ACGLAccountInqueryPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "ACGLAccountInqueryEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/AC/ACGLAccountInquery.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("GL Account Inquery", " - ", base.Page.Title);

            ucACGLAccountInqueryEntity.ContentHolderPageUrl = "~/ACGLAccountInquery.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}