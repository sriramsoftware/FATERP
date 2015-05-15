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
    public partial class HRAdditonalInformationControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _AdditonalInformationID
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

        public HRAdditonalInformationEntity _HRAdditonalInformationEntity
        {
            get
            {
                HRAdditonalInformationEntity entity = new HRAdditonalInformationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HRAdditonalInformationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HRAdditonalInformationEntity CurrentHRAdditonalInformationEntity
        {
            get
            {
                if (_AdditonalInformationID > 0)
                {
                    if (_HRAdditonalInformationEntity.AdditonalInformationID != _AdditonalInformationID)
                    {
                        _HRAdditonalInformationEntity = FCCHRAdditonalInformation.GetFacadeCreate().GetByID(_AdditonalInformationID);
                    }
                }

                return _HRAdditonalInformationEntity;
            }
            set
            {
                _HRAdditonalInformationEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {  
            MiscUtil.PopulateMDEmployeeAdditionalInformationCategory(ddlEmployeeAdditionalInformationCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtValue.Text = String.Empty;
            txtExtraStringColumn.Text = String.Empty;
            txtExtraField1.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HRAdditonalInformationEntity hRAdditonalInformationEntity = CurrentHRAdditonalInformationEntity;


            if (!hRAdditonalInformationEntity.IsNew)
            {
                if (ddlEmployeeAdditionalInformationCategoryID.Items.Count > 0 && hRAdditonalInformationEntity.EmployeeAdditionalInformationCategoryID != null)
                {
                    ddlEmployeeAdditionalInformationCategoryID.SelectedValue = hRAdditonalInformationEntity.EmployeeAdditionalInformationCategoryID.ToString();
                }

                txtValue.Text = hRAdditonalInformationEntity.Value.ToString();
                txtExtraStringColumn.Text = hRAdditonalInformationEntity.ExtraStringColumn.ToString();
                txtExtraField1.Text = hRAdditonalInformationEntity.ExtraField1.ToString();
                txtRemarks.Text = hRAdditonalInformationEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHRAdditonalInformationList();
        }

        private void BindHRAdditonalInformationList()
        {
            lvHRAdditonalInformation.DataBind();
        }

        private HRAdditonalInformationEntity BuildHRAdditonalInformationEntity()
        {
            HRAdditonalInformationEntity hRAdditonalInformationEntity = CurrentHRAdditonalInformationEntity;

            hRAdditonalInformationEntity.EmployeeID = OverviewEmployeeID;

            if (ddlEmployeeAdditionalInformationCategoryID.Items.Count > 0)
            {
                if (ddlEmployeeAdditionalInformationCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hRAdditonalInformationEntity.EmployeeAdditionalInformationCategoryID = Int64.Parse(ddlEmployeeAdditionalInformationCategoryID.SelectedValue);
                }
            }

            if (!txtValue.Text.Trim().IsNullOrEmpty())
            {
                hRAdditonalInformationEntity.Value = Decimal.Parse(txtValue.Text.Trim());
            }

            hRAdditonalInformationEntity.ExtraStringColumn = txtExtraStringColumn.Text.Trim();
            hRAdditonalInformationEntity.ExtraField1 = txtExtraField1.Text.Trim();
            hRAdditonalInformationEntity.Remarks = txtRemarks.Text.Trim();

            return hRAdditonalInformationEntity;
        }

        private void SaveHRAdditonalInformationEntity()
        {
            if (IsValid)
            {
                try
                {
                    HRAdditonalInformationEntity hRAdditonalInformationEntity = BuildHRAdditonalInformationEntity();

                    Int64 result = -1;

                    if (hRAdditonalInformationEntity.IsNew)
                    {
                        result = FCCHRAdditonalInformation.GetFacadeCreate().Add(hRAdditonalInformationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRAdditonalInformationEntity.FLD_NAME_AdditonalInformationID, hRAdditonalInformationEntity.AdditonalInformationID.ToString(), SQLMatchType.Equal);
                        result = FCCHRAdditonalInformation.GetFacadeCreate().Update(hRAdditonalInformationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AdditonalInformationID = 0;
                        _HRAdditonalInformationEntity = new HRAdditonalInformationEntity();
                        PrepareInitialView();
                        BindHRAdditonalInformationList();

                        if (hRAdditonalInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Additonal Information Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Additonal Information Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hRAdditonalInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Additonal Information Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Additonal Information Information.", false);
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

        protected void lvHRAdditonalInformation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AdditonalInformationID;

            Int64.TryParse(e.CommandArgument.ToString(), out AdditonalInformationID);

            if (AdditonalInformationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AdditonalInformationID = AdditonalInformationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRAdditonalInformationEntity.FLD_NAME_AdditonalInformationID, AdditonalInformationID.ToString(), SQLMatchType.Equal);

                        HRAdditonalInformationEntity hRAdditonalInformationEntity = new HRAdditonalInformationEntity();


                        result = FCCHRAdditonalInformation.GetFacadeCreate().Delete(hRAdditonalInformationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AdditonalInformationID = 0;
                            _HRAdditonalInformationEntity = new HRAdditonalInformationEntity();
                            PrepareInitialView();
                            BindHRAdditonalInformationList();

                            MiscUtil.ShowMessage(lblMessage, "Additonal Information has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Additonal Information.", true);
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

        protected void odsHRAdditonalInformation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HRAdditonalInformationEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHRAdditonalInformationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AdditonalInformationID = 0;
            _HRAdditonalInformationEntity = new HRAdditonalInformationEntity();
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
