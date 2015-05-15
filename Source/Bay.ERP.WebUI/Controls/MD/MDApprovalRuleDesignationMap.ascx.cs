// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Text;
using System.Data;

namespace Bay.ERP.Web.UI
{
    public partial class MDApprovalRuleDesignationMapControl : BaseControl
    {       
        #region Properties

        public Int64 CurrentApprovalRuleID
        {
            get
            {
                Int64 id = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[MDApprovalRuleEntity.FLD_NAME_ApprovalRuleID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[MDApprovalRuleEntity.FLD_NAME_ApprovalRuleID], out id);
                }

                return id;
            }
        }

        private MDApprovalRuleEntity CurrentMDApprovalRuleEntity
        {
            get
            {
                if (ViewState["CurrentApprovalRuleEntity"] == null)
                {
                    ViewState["CurrentApprovalRuleEntity"] = FCCMDApprovalRule.GetFacadeCreate().GetByID(CurrentApprovalRuleID);
                }

                return (MDApprovalRuleEntity)ViewState["CurrentApprovalRuleEntity"];
            }
        }
            
        public Int64 _ApprovalRuleDesignationMapID
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

        public MDApprovalRuleDesignationMapEntity _MDApprovalRuleDesignationMapEntity
        {
            get
            {
                MDApprovalRuleDesignationMapEntity entity = new MDApprovalRuleDesignationMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDApprovalRuleDesignationMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDApprovalRuleDesignationMapEntity CurrentMDApprovalRuleDesignationMapEntity
        {
            get
            {
                if (_ApprovalRuleDesignationMapID > 0)
                {
                    if (_MDApprovalRuleDesignationMapEntity.ApprovalRuleDesignationMapID != _ApprovalRuleDesignationMapID)
                    {
                        _MDApprovalRuleDesignationMapEntity = FCCMDApprovalRuleDesignationMap.GetFacadeCreate().GetByID(_ApprovalRuleDesignationMapID);
                    }
                }

                return _MDApprovalRuleDesignationMapEntity;
            }
            set
            {
                _MDApprovalRuleDesignationMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDDesignation(ddlDesignationID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDApprovalRuleDesignationMapEntity mDApprovalRuleDesignationMapEntity = CurrentMDApprovalRuleDesignationMapEntity;


            if (!mDApprovalRuleDesignationMapEntity.IsNew)
            {
                if (ddlDesignationID.Items.Count > 0 && mDApprovalRuleDesignationMapEntity.DesignationID != null)
                {
                    ddlDesignationID.SelectedValue = mDApprovalRuleDesignationMapEntity.DesignationID.ToString();
                }
                
                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDApprovalRuleDesignationMapList();
        }

        private void BindMDApprovalRuleDesignationMapList()
        {
            lvMDApprovalRuleDesignationMap.DataBind();
        }

        private MDApprovalRuleDesignationMapEntity BuildMDApprovalRuleDesignationMapEntity()
        {
            MDApprovalRuleDesignationMapEntity mDApprovalRuleDesignationMapEntity = CurrentMDApprovalRuleDesignationMapEntity;

            if (ddlDesignationID.Items.Count > 0)
            {
                if (ddlDesignationID.SelectedValue == "0")
                {
                }
                else
                {
                    mDApprovalRuleDesignationMapEntity.DesignationID = Int64.Parse(ddlDesignationID.SelectedValue);
                }
            }

            if (mDApprovalRuleDesignationMapEntity.IsNew)
            {
                mDApprovalRuleDesignationMapEntity.ApprovalRuleID = CurrentApprovalRuleID;
                

                #region Build XML String

                StringBuilder xmlStr = new StringBuilder();
                String subXmlStr = String.Empty;
                xmlStr.Append("<m>");

                subXmlStr = subXmlStr + "<i><a>" + CurrentApprovalRuleID + "</a></i>";
                
                xmlStr.Append(subXmlStr.ToString());
                xmlStr.Append("</m>");

                #endregion

                DataTable dt = FCCCommonDA_SP.GetFacadeCreate().GetDT(xmlStr.ToString(), CommonConstants.NEXT_SEQUENCENO_APPROVALRULE_DESIGNATIONMAP);
               
                Int32 nextSequenceID = 999;

                if( dt.Rows.Count > 0 )
                {
                    nextSequenceID = (Int32) dt.Rows[0]["MaxID"];
                }

                mDApprovalRuleDesignationMapEntity.SequeenceNo = nextSequenceID;

            }
                

            return mDApprovalRuleDesignationMapEntity;
        }

        private void SaveMDApprovalRuleDesignationMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDApprovalRuleDesignationMapEntity mDApprovalRuleDesignationMapEntity = BuildMDApprovalRuleDesignationMapEntity();

                    Int64 result = -1;

                    if (mDApprovalRuleDesignationMapEntity.IsNew)
                    {
                        result = FCCMDApprovalRuleDesignationMap.GetFacadeCreate().Add(mDApprovalRuleDesignationMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalRuleDesignationMapEntity.FLD_NAME_ApprovalRuleDesignationMapID, mDApprovalRuleDesignationMapEntity.ApprovalRuleDesignationMapID.ToString(), SQLMatchType.Equal);
                        result = FCCMDApprovalRuleDesignationMap.GetFacadeCreate().Update(mDApprovalRuleDesignationMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ApprovalRuleDesignationMapID = 0;
                        _MDApprovalRuleDesignationMapEntity = new MDApprovalRuleDesignationMapEntity();
                        PrepareInitialView();
                        BindMDApprovalRuleDesignationMapList();

                        if (mDApprovalRuleDesignationMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Rule Designation Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Rule Designation Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDApprovalRuleDesignationMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Approval Rule Designation Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Approval Rule Designation Map Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
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

        protected void lvMDApprovalRuleDesignationMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ApprovalRuleDesignationMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out ApprovalRuleDesignationMapID);

            if (ApprovalRuleDesignationMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ApprovalRuleDesignationMapID = ApprovalRuleDesignationMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalRuleDesignationMapEntity.FLD_NAME_ApprovalRuleDesignationMapID, ApprovalRuleDesignationMapID.ToString(), SQLMatchType.Equal);

                        MDApprovalRuleDesignationMapEntity mDApprovalRuleDesignationMapEntity = new MDApprovalRuleDesignationMapEntity();


                        result = FCCMDApprovalRuleDesignationMap.GetFacadeCreate().Delete(mDApprovalRuleDesignationMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ApprovalRuleDesignationMapID = 0;
                            _MDApprovalRuleDesignationMapEntity = new MDApprovalRuleDesignationMapEntity();
                            PrepareInitialView();
                            BindMDApprovalRuleDesignationMapList();

                            MiscUtil.ShowMessage(lblMessage, "Approval Rule Designation Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Approval Rule Designation Map.", true);
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

        protected void odsMDApprovalRuleDesignationMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDApprovalRuleDesignationMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ApprovalRuleDesignationMapID = 0;
            _MDApprovalRuleDesignationMapEntity = new MDApprovalRuleDesignationMapEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #endregion Event
    }
}
