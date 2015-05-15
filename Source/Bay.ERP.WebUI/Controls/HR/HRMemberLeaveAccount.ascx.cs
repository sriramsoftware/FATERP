// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Linq;

namespace Bay.ERP.Web.UI
{
    public partial class HRMemberLeaveAccountControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _MemberLeaveAccountID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public HRMemberLeaveAccountEntity _HRMemberLeaveAccountEntity
        {
            get
            {
                HRMemberLeaveAccountEntity entity = new HRMemberLeaveAccountEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HRMemberLeaveAccountEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HRMemberLeaveAccountEntity CurrentHRMemberLeaveAccountEntity
        {
            get
            {
                if (_MemberLeaveAccountID > 0)
                {
                    if (_HRMemberLeaveAccountEntity.MemberLeaveAccountID != _MemberLeaveAccountID)
                    {
                        _HRMemberLeaveAccountEntity = FCCHRMemberLeaveAccount.GetFacadeCreate().GetByID(_MemberLeaveAccountID);
                    }
                }

                return _HRMemberLeaveAccountEntity;
            }
            set
            {
                _HRMemberLeaveAccountEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {   
        }

        private void PrepareValidator()
        {
        }

        private Int64 GetFiscalYear()
        {
            Int64 fiscalyearID = 0;
            IList<ACFiscalYearEntity> lst = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            ACFiscalYearEntity ent = lst.Where(x => x.IsClosed == false).Single();
            return fiscalyearID = ent.FiscalYearID;
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareValidator();
            }
        }

        #endregion

        #region ObjectDataSource Event

        protected void odsHRMemberLeaveAccount_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HRMemberLeaveAccount." + HRMemberLeaveAccountEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #endregion Event
    }
}
