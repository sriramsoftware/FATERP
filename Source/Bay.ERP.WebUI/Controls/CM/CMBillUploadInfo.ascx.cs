// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2012, 11:26:30




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using AjaxControlToolkit;
using System.IO;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class CMBillUploadInfoControl : BaseControl
    {       
        #region Properties

        public Int64 _BillUploadInfoID
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

        public CMBillUploadInfoEntity _CMBillUploadInfoEntity
        {
            get
            {
                CMBillUploadInfoEntity entity = new CMBillUploadInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMBillUploadInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMBillUploadInfoEntity CurrentCMBillUploadInfoEntity
        {
            get
            {
                if (_BillUploadInfoID > 0)
                {
                    if (_CMBillUploadInfoEntity.BillUploadInfoID != _BillUploadInfoID)
                    {
                        _CMBillUploadInfoEntity = FCCCMBillUploadInfo.GetFacadeCreate().GetByID(_BillUploadInfoID);
                    }
                }

                return _CMBillUploadInfoEntity;
            }
            set
            {
                _CMBillUploadInfoEntity = value;
            }
        }

        public Int64 CMBillID
        {
            get
            {
                Int64 cMBillID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CM_BILL_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CM_BILL_ID], out cMBillID);
                }

                return cMBillID;
            }
        }

        #endregion

        #region Methods

        private void BindList()
        {
            BindCMBillUploadInfoList();
        }

        private void BindCMBillUploadInfoList()
        {
            lvCMBillUploadInfo.DataBind();
        }

        private void BuildDropDownList()
        {
            MiscUtil.PopulateStartWithAPPanel(ddlAPPanelID, false,MasterDataConstants.APPanelStartWith.BILL);
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            EnableDisableApprovalProcessCheck();
        }

        private void EnableDisableApprovalProcessCheck()
        {
            APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.BILL, CMBillID);

            if (aPApprovalProcessEntity.APApprovalProcessID > 0)
            {
                btnInitiateApprovalProcess.Enabled = false;
            }
            else
            {
                btnInitiateApprovalProcess.Enabled = true;
            }
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            afuFiles.UploadedComplete += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedComplete);
            afuFiles.UploadedFileError += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedFileError);

            btnInitiateApprovalProcess.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnInitiateApprovalProcess, "").ToString());

            if (!IsPostBack)
            {
                PrepareInitialView();
            }
        }

        #endregion

        #region List View Event

        protected void lvCMBillUploadInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BillUploadInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out BillUploadInfoID);

            if (BillUploadInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BillUploadInfoID = BillUploadInfoID;
                
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillUploadInfoEntity.FLD_NAME_BillUploadInfoID, BillUploadInfoID.ToString(), SQLMatchType.Equal);

                        CMBillUploadInfoEntity cMBillUploadInfoEntity = new CMBillUploadInfoEntity();


                        result = FCCCMBillUploadInfo.GetFacadeCreate().Delete(cMBillUploadInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BillUploadInfoID = 0;
                            _CMBillUploadInfoEntity = new CMBillUploadInfoEntity();
                            BindCMBillUploadInfoList();

                            MiscUtil.ShowMessage(lblMessage, "C MBill Upload Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MBill Upload Info.", true);
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

        protected void odsCMBillUploadInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillUploadInfoEntity.FLD_NAME_BillID, CMBillID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindCMBillUploadInfoList();
        }

        protected void btnInitiateApprovalProcess_Click(object sender, EventArgs e)
        {
            #region Approval Process

            if (ddlAPPanelID != null && ddlAPPanelID.SelectedValue != "0")
            {

                Boolean apResult = APRobot.CreateApprovalProcessForNewBill(CMBillID, Int64.Parse(ddlAPPanelID.SelectedValue.ToString()));

                if (apResult == true)
                {
                    MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                }

                EnableDisableApprovalProcessCheck();
            }

            #endregion
        }

        protected void btnAddAnotherBill_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CM/CMBill.aspx");
        }

        protected void btnResetApprovalProcess_Click(object sender, EventArgs e)
        {
            //#region Approval Process

            //Boolean apResult = APRobot.ResetApprovalProcessForRequisition(CMBillID);

            //if (apResult == true)
            //{
            //    MiscUtil.ShowMessage(lblMessage, "Approval Process has been reset successfully.", UIConstants.MessageType.GREEN);
            //}
            //else
            //{
            //    MiscUtil.ShowMessage(lblMessage, "Failed to reset approval process.", UIConstants.MessageType.RED);
            //}

            //EnableDisableApprovalProcessCheck();

            //#endregion
        }

        #endregion

        #region File Uploader Events

        protected void afuFiles_UploadedComplete(object sender, AsyncFileUploadEventArgs e)
        {
            CMBillUploadInfoEntity ent = new CMBillUploadInfoEntity();
            ent.BillID = this.CMBillID;
            ent.OriginalFileName = Path.GetFileName(e.FileName);
            ent.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(e.FileName);
            ent.FileType = "";
            ent.Extension = Path.GetExtension(e.FileName);
            ent.Path = FileUploadConstants.Bill.BILL_UPLOAD+ ent.CurrentFileName;
            ent.Remarks = String.Empty;

            FCCCMBillUploadInfo.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);

            // file upload

            afuFiles.SaveAs(Server.MapPath(ent.Path));

            //LoadFileListGried
            BindCMBillUploadInfoList();
        }

        protected void afuFiles_UploadedFileError(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "error", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Error: " + e.StatusMessage + "';", true);
        }

        #endregion

        #endregion Event
    }
}
