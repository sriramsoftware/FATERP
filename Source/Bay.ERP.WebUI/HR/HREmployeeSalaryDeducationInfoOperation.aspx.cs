// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeSalaryDeducationInfoOperationPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "HREmployeeSalaryDeducationInfoOperationEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/HR/HREmployeeSalaryDeducationInfoOperation.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Employee Salary Deducation Info", " - ", base.Page.Title);

            ucHREmployeeSalaryDeducationInfoOperationEntity.ContentHolderPageUrl = "~/HREmployeeSalaryDeducationInfo.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
