// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Apr-2013, 05:21:43




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
    public partial class CRMAgreementVariableMapControl : BaseControl
    {       
        #region Properties

        public Int64 _AgreementVariableMapID
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

        public CRMAgreementVariableMapEntity _CRMAgreementVariableMapEntity
        {
            get
            {
                CRMAgreementVariableMapEntity entity = new CRMAgreementVariableMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMAgreementVariableMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMAgreementVariableMapEntity CurrentCRMAgreementVariableMapEntity
        {
            get
            {
                if (_AgreementVariableMapID > 0)
                {
                    if (_CRMAgreementVariableMapEntity.AgreementVariableMapID != _AgreementVariableMapID)
                    {
                        _CRMAgreementVariableMapEntity = FCCCRMAgreementVariableMap.GetFacadeCreate().GetByID(_AgreementVariableMapID);
                    }
                }

                return _CRMAgreementVariableMapEntity;
            }
            set
            {
                _CRMAgreementVariableMapEntity = value;
            }
        }

        public Int64 OverviewAgreementID
        {
            get
            {
                Int64 cRMAgreementID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_AGREEMENT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_AGREEMENT_ID], out cRMAgreementID);
                }

                return cRMAgreementID;
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

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity = CurrentCRMAgreementVariableMapEntity;

            if (!cRMAgreementVariableMapEntity.IsNew)
            { 
                txtName.Text = cRMAgreementVariableMapEntity.Name.ToString();
                txtValue.Text = cRMAgreementVariableMapEntity.Value.ToString();
                txtRemarks.Text = cRMAgreementVariableMapEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMAgreementVariableMapList();
        }

        private void BindCRMAgreementVariableMapList()
        {
            lvCRMAgreementVariableMap.DataBind();
        }

        private CRMAgreementVariableMapEntity BuildCRMAgreementVariableMapEntity()
        {
            CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity = CurrentCRMAgreementVariableMapEntity;
            cRMAgreementVariableMapEntity.AgreementID = OverviewAgreementID;
            txtName.Text = MiscUtil.DocumentVariableParsing(txtName.Text.ToString());
            cRMAgreementVariableMapEntity.Name = txtName.Text.Trim();
            cRMAgreementVariableMapEntity.Value = txtValue.Text.Trim();
            cRMAgreementVariableMapEntity.Remarks = txtRemarks.Text.Trim();
            cRMAgreementVariableMapEntity.CreatedByEmployeeID = CurrentemployeeID;
            cRMAgreementVariableMapEntity.CreateDate = System.DateTime.Now;
            cRMAgreementVariableMapEntity.IP = MiscUtil.GetLocalIP();

            return cRMAgreementVariableMapEntity;
        }

        private void SaveCRMAgreementVariableMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity = BuildCRMAgreementVariableMapEntity();

                    Int64 result = -1;

                    if (cRMAgreementVariableMapEntity.IsNew)
                    {
                        result = FCCCRMAgreementVariableMap.GetFacadeCreate().Add(cRMAgreementVariableMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_AgreementVariableMapID, cRMAgreementVariableMapEntity.AgreementVariableMapID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMAgreementVariableMap.GetFacadeCreate().Update(cRMAgreementVariableMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AgreementVariableMapID = 0;
                        _CRMAgreementVariableMapEntity = new CRMAgreementVariableMapEntity();
                        PrepareInitialView();
                        BindCRMAgreementVariableMapList();

                        if (cRMAgreementVariableMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Variable Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Variable Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMAgreementVariableMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Agreement Variable Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Agreement Variable Map Information.", false);
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

        protected void lvCRMAgreementVariableMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AgreementVariableMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out AgreementVariableMapID);

            if (AgreementVariableMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AgreementVariableMapID = AgreementVariableMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_AgreementVariableMapID, AgreementVariableMapID.ToString(), SQLMatchType.Equal);

                        CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity = new CRMAgreementVariableMapEntity();


                        result = FCCCRMAgreementVariableMap.GetFacadeCreate().Delete(cRMAgreementVariableMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AgreementVariableMapID = 0;
                            _CRMAgreementVariableMapEntity = new CRMAgreementVariableMapEntity();
                            PrepareInitialView();
                            BindCRMAgreementVariableMapList();

                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Variable Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMAgreement Variable Map.", true);
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

        protected void odsCRMAgreementVariableMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_AgreementID, OverviewAgreementID.ToString(), SQLMatchType.Equal);

            if (chbxFilter.Checked)
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_Name, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_Value, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMAgreementVariableMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AgreementVariableMapID = 0;
            _CRMAgreementVariableMapEntity = new CRMAgreementVariableMapEntity();
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
