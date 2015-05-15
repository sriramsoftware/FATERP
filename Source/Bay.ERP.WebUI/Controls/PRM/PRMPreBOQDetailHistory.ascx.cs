// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    public partial class PRMPreBOQDetailHistoryControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _PRMPreBOQDetailHistoryID
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

        public PRMPreBOQDetailHistoryEntity _PRMPreBOQDetailHistoryEntity
        {
            get
            {
                PRMPreBOQDetailHistoryEntity entity = new PRMPreBOQDetailHistoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMPreBOQDetailHistoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMPreBOQDetailHistoryEntity CurrentPRMPreBOQDetailHistoryEntity
        {
            get
            {
                if (_PRMPreBOQDetailHistoryID > 0)
                {
                    if (_PRMPreBOQDetailHistoryEntity.PRMPreBOQDetailHistoryID != _PRMPreBOQDetailHistoryID)
                    {
                        _PRMPreBOQDetailHistoryEntity = FCCPRMPreBOQDetailHistory.GetFacadeCreate().GetByID(_PRMPreBOQDetailHistoryID);
                    }
                }

                return _PRMPreBOQDetailHistoryEntity;
            }
            set
            {
                _PRMPreBOQDetailHistoryEntity = value;
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
        }

        private void BindList()
        {
            BindPRMPreBOQDetailHistoryList();
        }

        private void BindPRMPreBOQDetailHistoryList()
        {
            lvPRMPreBOQDetailHistory.DataBind();
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
            }
        }

        #endregion

        #region ObjectDataSource Event

        protected void odsPRMPreBOQDetailHistory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMPreBOQ." + PRMPreBOQDetailHistory_CustomEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #endregion Event
    }
}
