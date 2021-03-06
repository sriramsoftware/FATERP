// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class CMConsultantAssignedWorkAreaPage : ConsultantBasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "CMConsultantAssignedWorkAreaEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/CM/CMConsultantAssignedWorkArea.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Consultant Assigned Work Area", " - ", base.Page.Title);

            ucCMConsultantAssignedWorkAreaEntity.ContentHolderPageUrl = "~/CM/CMConsultantAssignedWorkArea.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
