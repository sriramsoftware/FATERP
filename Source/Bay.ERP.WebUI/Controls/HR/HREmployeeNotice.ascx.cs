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
using System.Drawing;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeNoticeControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeNoticeID
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
                if (_EmployeeNoticeID > 0)
                {
                    if (_HREmployeeNoticeEntity.EmployeeNoticeID != _EmployeeNoticeID)
                    {
                        _HREmployeeNoticeEntity = FCCHREmployeeNotice.GetFacadeCreate().GetByID(_EmployeeNoticeID);
                    }
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
            CheckNewNotice();
          
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
            lvHREmployeeNotice.DataBind();
        }

        private HREmployeeNoticeEntity BuildHREmployeeNoticeEntity()
        {
            HREmployeeNoticeEntity hREmployeeNoticeEntity = CurrentHREmployeeNoticeEntity;

           


            return hREmployeeNoticeEntity;
        }

        private void SaveHREmployeeNoticeEntity()
        {
           
        }

        private void CheckNewNotice()
        {
            Int64 countNewNotice = 0;
            String fe = "SendToEmployeeID = " + OverviewEmployeeID + " and ViewCount <= 0";
            IList<HREmployeeNoticeEntity> list = FCCHREmployeeNotice.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (list != null && list.Count > 0)
            {
                countNewNotice = list.Count;
                this.messageDetails.Text = "You have " + countNewNotice + " new Issue send by HR. Please read new issues.";
                this.MPE.Show();
            }
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

        #region List View Event

        protected void lvHREmployeeNotice_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                HREmployeeNotice_DetailedEntity ent = (HREmployeeNotice_DetailedEntity)dataItem.DataItem;
                HyperLink hypPreview = (HyperLink)e.Item.FindControl("hypPreview");
                Label lblNewOrOld = (Label)e.Item.FindControl("lblNewOrOld");

                if (ent.ViewCount <= 0)
                {
                    lblNewOrOld.Text = "! New";
                    lblNewOrOld.ForeColor = Color.Red;
                }
                else
                {
                    lblNewOrOld.Text = "Seen";
                    lblNewOrOld.ForeColor = Color.DarkCyan;
                    
                }


                hypPreview.NavigateUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeeNoticePreview.aspx", string.Empty, UrlConstants.OVERVIEW_HR_EMPLOYEE_NOTICE_ID, ent.EmployeeNoticeID.ToString()).ToString();
                hypPreview.Target = "_blank";

            }
        }

        protected void lvHREmployeeNotice_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeNoticeID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeNoticeID);

            if (EmployeeNoticeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeNoticeID = EmployeeNoticeID;

                    PrepareEditView();

                    //cpeEditor.Collapsed = false;
                    //cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeNoticeEntity.FLD_NAME_EmployeeNoticeID, EmployeeNoticeID.ToString(), SQLMatchType.Equal);

                        HREmployeeNoticeEntity hREmployeeNoticeEntity = new HREmployeeNoticeEntity();


                        result = FCCHREmployeeNotice.GetFacadeCreate().Delete(hREmployeeNoticeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeNoticeID = 0;
                            _HREmployeeNoticeEntity = new HREmployeeNoticeEntity();
                            PrepareInitialView();
                            BindHREmployeeNoticeList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Notice has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Notice.", true);
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

        protected void odsHREmployeeNotice_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeNoticeEntity.FLD_NAME_SendToEmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        

        #endregion Event
    }
}
