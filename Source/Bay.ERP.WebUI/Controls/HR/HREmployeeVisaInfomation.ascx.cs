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
    public partial class HREmployeeVisaInfomationControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeVisaInfomationID
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

        public HREmployeeVisaInfomationEntity _HREmployeeVisaInfomationEntity
        {
            get
            {
                HREmployeeVisaInfomationEntity entity = new HREmployeeVisaInfomationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeVisaInfomationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeVisaInfomationEntity CurrentHREmployeeVisaInfomationEntity
        {
            get
            {
                if (_EmployeeVisaInfomationID > 0)
                {
                    if (_HREmployeeVisaInfomationEntity.EmployeeVisaInfomationID != _EmployeeVisaInfomationID)
                    {
                        _HREmployeeVisaInfomationEntity = FCCHREmployeeVisaInfomation.GetFacadeCreate().GetByID(_EmployeeVisaInfomationID);
                    }
                }

                return _HREmployeeVisaInfomationEntity;
            }
            set
            {
                _HREmployeeVisaInfomationEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {  
            MiscUtil.PopulateMDVisaStatus(ddlVisaStatusID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtVisaTransferInfo.Text = String.Empty;
            txtProfessionInVisa.Text = String.Empty;
            txtVisaNumber.Text = String.Empty;
            txtVisaIssuedDate.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity = CurrentHREmployeeVisaInfomationEntity;


            if (!hREmployeeVisaInfomationEntity.IsNew)
            {
                if (ddlVisaStatusID.Items.Count > 0 && hREmployeeVisaInfomationEntity.VisaStatusID != null)
                {
                    ddlVisaStatusID.SelectedValue = hREmployeeVisaInfomationEntity.VisaStatusID.ToString();
                }

                txtVisaTransferInfo.Text = hREmployeeVisaInfomationEntity.VisaTransferInfo.ToString();
                txtProfessionInVisa.Text = hREmployeeVisaInfomationEntity.ProfessionInVisa.ToString();
                txtVisaNumber.Text = hREmployeeVisaInfomationEntity.VisaNumber.ToString();
                txtVisaIssuedDate.Text = hREmployeeVisaInfomationEntity.VisaIssuedDate.ToStringDefault();
                txtRemarks.Text = hREmployeeVisaInfomationEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeVisaInfomationList();
        }

        private void BindHREmployeeVisaInfomationList()
        {
            lvHREmployeeVisaInfomation.DataBind();
        }

        private HREmployeeVisaInfomationEntity BuildHREmployeeVisaInfomationEntity()
        {
            HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity = CurrentHREmployeeVisaInfomationEntity;


            hREmployeeVisaInfomationEntity.EmployeeID = OverviewEmployeeID;
            {
                if (ddlVisaStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeVisaInfomationEntity.VisaStatusID = Int64.Parse(ddlVisaStatusID.SelectedValue);
                }
            }

            hREmployeeVisaInfomationEntity.VisaTransferInfo = txtVisaTransferInfo.Text.Trim();
            hREmployeeVisaInfomationEntity.ProfessionInVisa = txtProfessionInVisa.Text.Trim();
            hREmployeeVisaInfomationEntity.VisaNumber = txtVisaNumber.Text.Trim();
            if (txtVisaIssuedDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeVisaInfomationEntity.VisaIssuedDate = MiscUtil.ParseToDateTime(txtVisaIssuedDate.Text);
            }
            else
            {
                hREmployeeVisaInfomationEntity.VisaIssuedDate = null;
            }

            hREmployeeVisaInfomationEntity.Remarks = txtRemarks.Text.Trim();

            return hREmployeeVisaInfomationEntity;
        }

        private void SaveHREmployeeVisaInfomationEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity = BuildHREmployeeVisaInfomationEntity();

                    Int64 result = -1;

                    if (hREmployeeVisaInfomationEntity.IsNew)
                    {
                        result = FCCHREmployeeVisaInfomation.GetFacadeCreate().Add(hREmployeeVisaInfomationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeVisaInfomationEntity.FLD_NAME_EmployeeVisaInfomationID, hREmployeeVisaInfomationEntity.EmployeeVisaInfomationID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeVisaInfomation.GetFacadeCreate().Update(hREmployeeVisaInfomationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeVisaInfomationID = 0;
                        _HREmployeeVisaInfomationEntity = new HREmployeeVisaInfomationEntity();
                        PrepareInitialView();
                        BindHREmployeeVisaInfomationList();

                        if (hREmployeeVisaInfomationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Visa Infomation Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Visa Infomation Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeVisaInfomationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Visa Infomation Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Visa Infomation Information.", false);
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

        protected void lvHREmployeeVisaInfomation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeVisaInfomationID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeVisaInfomationID);

            if (EmployeeVisaInfomationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeVisaInfomationID = EmployeeVisaInfomationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeVisaInfomationEntity.FLD_NAME_EmployeeVisaInfomationID, EmployeeVisaInfomationID.ToString(), SQLMatchType.Equal);

                        HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity = new HREmployeeVisaInfomationEntity();


                        result = FCCHREmployeeVisaInfomation.GetFacadeCreate().Delete(hREmployeeVisaInfomationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeVisaInfomationID = 0;
                            _HREmployeeVisaInfomationEntity = new HREmployeeVisaInfomationEntity();
                            PrepareInitialView();
                            BindHREmployeeVisaInfomationList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Visa Infomation has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Visa Infomation.", true);
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

        protected void odsHREmployeeVisaInfomation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeVisaInfomationEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeVisaInfomationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeVisaInfomationID = 0;
            _HREmployeeVisaInfomationEntity = new HREmployeeVisaInfomationEntity();
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
