// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




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
    public partial class CRMMDAgreementVariableControl : BaseControl
    {       
        #region Properties

        public Int64 _AgreementVariableID
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

        public CRMMDAgreementVariableEntity _CRMMDAgreementVariableEntity
        {
            get
            {
                CRMMDAgreementVariableEntity entity = new CRMMDAgreementVariableEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDAgreementVariableEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDAgreementVariableEntity CurrentCRMMDAgreementVariableEntity
        {
            get
            {
                if (_AgreementVariableID > 0)
                {
                    if (_CRMMDAgreementVariableEntity.AgreementVariableID != _AgreementVariableID)
                    {
                        _CRMMDAgreementVariableEntity = FCCCRMMDAgreementVariable.GetFacadeCreate().GetByID(_AgreementVariableID);
                    }
                }

                return _CRMMDAgreementVariableEntity;
            }
            set
            {
                _CRMMDAgreementVariableEntity = value;
            }
        }

        public Int64 CurrentemployeeID
        {
            get
            {
                Int64 _employeeID = 0;

                if (ViewState["currentEmployeeID"] != null)
                {
                    Int64.TryParse(ViewState["currentEmployeeID"].ToString(), out _employeeID);
                }

                if (ViewState["currentEmployeeID"] == null)
                {
                    ViewState["currentEmployeeID"] = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                    _employeeID = (Int64)ViewState["currentEmployeeID"];
                }

                return _employeeID;
            }
            set
            {
                ViewState["currentEmployeeID"] = value;
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

            txtName.Text = String.Empty;
            txtValue.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMMDAgreementVariableEntity cRMMDAgreementVariableEntity = CurrentCRMMDAgreementVariableEntity;


            if (!cRMMDAgreementVariableEntity.IsNew)
            {
                txtName.Text = cRMMDAgreementVariableEntity.Name.ToString();
                txtValue.Text= cRMMDAgreementVariableEntity.Value.ToString();
                txtRemarks.Text = cRMMDAgreementVariableEntity.Remarks.ToString();
                chkIsRemoved.Checked = cRMMDAgreementVariableEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDAgreementVariableList();
        }

        private void BindCRMMDAgreementVariableList()
        {
            lvCRMMDAgreementVariable.DataBind();
        }

        private CRMMDAgreementVariableEntity BuildCRMMDAgreementVariableEntity()
        {
            CRMMDAgreementVariableEntity cRMMDAgreementVariableEntity = CurrentCRMMDAgreementVariableEntity;

            txtName.Text = MiscUtil.DocumentVariableParsing(txtName.Text.ToString());

            cRMMDAgreementVariableEntity.Name = txtName.Text.Trim();
            cRMMDAgreementVariableEntity.Value = txtValue.Text.Trim();
            cRMMDAgreementVariableEntity.Remarks = txtRemarks.Text.Trim();
            cRMMDAgreementVariableEntity.CreatedByEmployeeID = CurrentemployeeID;
            cRMMDAgreementVariableEntity.CreateDate = System.DateTime.Now;
            cRMMDAgreementVariableEntity.IP = MiscUtil.GetLocalIP();
            cRMMDAgreementVariableEntity.IsRemoved = chkIsRemoved.Checked;

            return cRMMDAgreementVariableEntity;
        }

        private void SaveCRMMDAgreementVariableEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDAgreementVariableEntity cRMMDAgreementVariableEntity = BuildCRMMDAgreementVariableEntity();

                    Int64 result = -1;

                    if (cRMMDAgreementVariableEntity.IsNew)
                    {
                        result = FCCCRMMDAgreementVariable.GetFacadeCreate().Add(cRMMDAgreementVariableEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAgreementVariableEntity.FLD_NAME_AgreementVariableID, cRMMDAgreementVariableEntity.AgreementVariableID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDAgreementVariable.GetFacadeCreate().Update(cRMMDAgreementVariableEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AgreementVariableID = 0;
                        _CRMMDAgreementVariableEntity = new CRMMDAgreementVariableEntity();
                        PrepareInitialView();
                        BindCRMMDAgreementVariableList();

                        if (cRMMDAgreementVariableEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Variable Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Variable Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDAgreementVariableEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Agreement Variable Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Agreement Variable Information.", false);
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

        protected void lvCRMMDAgreementVariable_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AgreementVariableID;

            Int64.TryParse(e.CommandArgument.ToString(), out AgreementVariableID);

            if (AgreementVariableID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AgreementVariableID = AgreementVariableID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAgreementVariableEntity.FLD_NAME_AgreementVariableID, AgreementVariableID.ToString(), SQLMatchType.Equal);

                        CRMMDAgreementVariableEntity cRMMDAgreementVariableEntity = new CRMMDAgreementVariableEntity();


                        result = FCCCRMMDAgreementVariable.GetFacadeCreate().Delete(cRMMDAgreementVariableEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AgreementVariableID = 0;
                            _CRMMDAgreementVariableEntity = new CRMMDAgreementVariableEntity();
                            PrepareInitialView();
                            BindCRMMDAgreementVariableList();

                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Variable has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMAgreement Variable.", true);
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

        protected void odsCRMMDAgreementVariable_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_Name, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_Value, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDAgreementVariableEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AgreementVariableID = 0;
            _CRMMDAgreementVariableEntity = new CRMMDAgreementVariableEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
