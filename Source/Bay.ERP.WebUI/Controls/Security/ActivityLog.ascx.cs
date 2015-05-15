// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jul-2013, 10:18:14




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
    public partial class ActivityLogControl : BaseControl
    {       
        #region Properties

        public Int64 _ActivityLogID
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

        public ActivityLogEntity _ActivityLogEntity
        {
            get
            {
                ActivityLogEntity entity = new ActivityLogEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ActivityLogEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ActivityLogEntity CurrentActivityLogEntity
        {
            get
            {
                if (_ActivityLogID > 0)
                {
                    if (_ActivityLogEntity.ActivityLogID != _ActivityLogID)
                    {
                        _ActivityLogEntity = FCCActivityLog.GetFacadeCreate().GetByID(_ActivityLogID);
                    }
                }

                return _ActivityLogEntity;
            }
            set
            {
                _ActivityLogEntity = value;
            }
        }

        public Guid Overview_aspnetUserID
        {
            get
            {
                Guid aspnetUserID = new Guid("{00000000-0000-0000-0000-000000000000}");
                
                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ASP_NET_USER_ID]))
                {
                    aspnetUserID = new Guid(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ASP_NET_USER_ID].ToString());
                }

                return aspnetUserID;
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
            //BindActivityLogList();
        }

        private void BindList()
        {
            BindActivityLogList();
        }

        private void BindActivityLogList()
        {
            lvActivityLog.DataBind();
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

                base.LogActivity("Viewing Activity History...", true);
            }
        }

        #endregion

        #region List View Event

        protected void lvActivityLog_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ActivityLogID;

            Int64.TryParse(e.CommandArgument.ToString(), out ActivityLogID);

            if (ActivityLogID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ActivityLogID = ActivityLogID;

                   
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ActivityLogEntity.FLD_NAME_ActivityLogID, ActivityLogID.ToString(), SQLMatchType.Equal);

                        ActivityLogEntity activityLogEntity = new ActivityLogEntity();


                        result = FCCActivityLog.GetFacadeCreate().Delete(activityLogEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ActivityLogID = 0;
                            _ActivityLogEntity = new ActivityLogEntity();
                            PrepareInitialView();
                            BindActivityLogList();

                            MiscUtil.ShowMessage(lblMessage, "Activity Log has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Activity Log.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsActivityLog_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(ActivityLogEntity.FLD_NAME_UserId, Overview_aspnetUserID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #endregion Event
    }
}
