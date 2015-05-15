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

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeNoticePreviewControl : BaseControl
    {       
        #region Properties

        public Int64 OverviewNoticeID
        {
            get
            {
                Int64 overviewNoticeID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_HR_EMPLOYEE_NOTICE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_HR_EMPLOYEE_NOTICE_ID], out overviewNoticeID);
                }

                return overviewNoticeID;
            }
        }

        public HREmployeeNoticeEntity _HREmployeeNoticeEntity
        {
            get
            {
                HREmployeeNoticeEntity entity = new HREmployeeNoticeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeNoticeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeNoticeEntity CurrentHREmployeeNoticeEntity
        {
            get
            {
                if (OverviewNoticeID > 0)
                {
                    _HREmployeeNoticeEntity = FCCHREmployeeNotice.GetFacadeCreate().GetByID(OverviewNoticeID);
                }

                return _HREmployeeNoticeEntity;
            }
            set
            {
                _HREmployeeNoticeEntity = value;
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

        private void PrepareInitialView()
        {
            BuildDropDownList();

            DateTime seenNotice = DateTime.Now.Date;
            Int64 viewCount = 1;

            HREmployeeNoticeEntity entity = CurrentHREmployeeNoticeEntity;

            lblNoticeTextView.Text = Server.HtmlDecode(CurrentHREmployeeNoticeEntity.Text.ToString());
            if (CurrentHREmployeeNoticeEntity.ViewCount <= 0)
            {
                entity.SeenNotice = seenNotice;
                entity.ViewCount = viewCount;
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeNoticeEntity.FLD_NAME_EmployeeNoticeID, entity.EmployeeNoticeID.ToString(), SQLMatchType.Equal);
                FCCHREmployeeNotice.GetFacadeCreate().Update(entity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            }

        }

        private void PrepareEditView()
        {
            HREmployeeNoticeEntity hREmployeeNoticeEntity = CurrentHREmployeeNoticeEntity;


            if (!hREmployeeNoticeEntity.IsNew)
            {
              
            }
        }

        private void BindList()
        {
            BindHREmployeeNoticeList();
        }

        private void BindHREmployeeNoticeList()
        {
           
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #endregion Event
    }
}
