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
    public partial class HREmployeeEmergencyContactInfoControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeEmergencyContactInfoID
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

        public HREmployeeEmergencyContactInfoEntity _HREmployeeEmergencyContactInfoEntity
        {
            get
            {
                HREmployeeEmergencyContactInfoEntity entity = new HREmployeeEmergencyContactInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeEmergencyContactInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeEmergencyContactInfoEntity CurrentHREmployeeEmergencyContactInfoEntity
        {
            get
            {
                if (_EmployeeEmergencyContactInfoID > 0)
                {
                    if (_HREmployeeEmergencyContactInfoEntity.EmployeeEmergencyContactInfoID != _EmployeeEmergencyContactInfoID)
                    {
                        _HREmployeeEmergencyContactInfoEntity = FCCHREmployeeEmergencyContactInfo.GetFacadeCreate().GetByID(_EmployeeEmergencyContactInfoID);
                    }
                }

                return _HREmployeeEmergencyContactInfoEntity;
            }
            set
            {
                _HREmployeeEmergencyContactInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateEmergencyContactPerson(ddlEmergencyContactPersonID, false, OverviewEmployeeID);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            GetSelectedContactPersonInfo();

            txtFirstName.Text = String.Empty;
            txtMiddleName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtRelationShip.Text = String.Empty;
            txtMobilePhone.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity = CurrentHREmployeeEmergencyContactInfoEntity;


            if (!hREmployeeEmergencyContactInfoEntity.IsNew)
            {
               

                txtFirstName.Text = hREmployeeEmergencyContactInfoEntity.FirstName.ToString();
                txtMiddleName.Text = hREmployeeEmergencyContactInfoEntity.MiddleName.ToString();
                txtLastName.Text = hREmployeeEmergencyContactInfoEntity.LastName.ToString();
                txtRelationShip.Text = hREmployeeEmergencyContactInfoEntity.RelationShip.ToString();
                txtMobilePhone.Text = hREmployeeEmergencyContactInfoEntity.MobilePhoneNumber.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeEmergencyContactInfoList();
        }

        private void BindHREmployeeEmergencyContactInfoList()
        {
            lvHREmployeeEmergencyContactInfo.DataBind();
        }

        private HREmployeeEmergencyContactInfoEntity BuildHREmployeeEmergencyContactInfoEntity()
        {
            HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity = CurrentHREmployeeEmergencyContactInfoEntity;

            hREmployeeEmergencyContactInfoEntity.EmployeeID = OverviewEmployeeID;

            hREmployeeEmergencyContactInfoEntity.FirstName = txtFirstName.Text.Trim();
            hREmployeeEmergencyContactInfoEntity.MiddleName = txtMiddleName.Text.Trim();
            hREmployeeEmergencyContactInfoEntity.LastName = txtLastName.Text.Trim();
            hREmployeeEmergencyContactInfoEntity.RelationShip = txtRelationShip.Text.Trim();
            hREmployeeEmergencyContactInfoEntity.MobilePhoneNumber = txtMobilePhone.Text.Trim();

            return hREmployeeEmergencyContactInfoEntity;
        }

        private void SaveHREmployeeEmergencyContactInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity = BuildHREmployeeEmergencyContactInfoEntity();

                    Int64 result = -1;

                    if (hREmployeeEmergencyContactInfoEntity.IsNew)
                    {
                        result = FCCHREmployeeEmergencyContactInfo.GetFacadeCreate().Add(hREmployeeEmergencyContactInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEmergencyContactInfoEntity.FLD_NAME_EmployeeEmergencyContactInfoID, hREmployeeEmergencyContactInfoEntity.EmployeeEmergencyContactInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeEmergencyContactInfo.GetFacadeCreate().Update(hREmployeeEmergencyContactInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeEmergencyContactInfoID = 0;
                        _HREmployeeEmergencyContactInfoEntity = new HREmployeeEmergencyContactInfoEntity();
                        PrepareInitialView();
                        BindHREmployeeEmergencyContactInfoList();
                        GetSelectedContactPersonInfo();

                        if (hREmployeeEmergencyContactInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Emergency Contact Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Emergency Contact Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeEmergencyContactInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Emergency Contact Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Emergency Contact Info Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void GetSelectedContactPersonInfo()
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeFamilyInfo." + HREmployeeFamilyInfo_DetailedEntity.FLD_NAME_HREmployeeFamilyInfoID, ddlEmergencyContactPersonID.SelectedValue.ToString(), SQLMatchType.Equal);

            IList<HREmployeeFamilyInfo_DetailedEntity> lst = FCCHREmployeeFamilyInfo_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, fe);

            if (lst != null && lst.Count > 0)
            {
                txtFirstName.Text = lst[0].FirstName;
                txtMiddleName.Text = lst[0].MiddleName;
                txtLastName.Text = lst[0].LastName;
                txtRelationShip.Text = lst[0].FamilyRelationTypeName;
                txtMobilePhone.Text = lst[0].Phone;
            }
            else
            {
                txtFirstName.Text = String.Empty;
                txtMiddleName.Text = String.Empty;
                txtLastName.Text = String.Empty;
                txtRelationShip.Text = String.Empty;
                txtMobilePhone.Text = String.Empty;
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
                GetSelectedContactPersonInfo();
            }
        }

        #endregion

        #region List View Event

        protected void lvHREmployeeEmergencyContactInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeEmergencyContactInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeEmergencyContactInfoID);

            if (EmployeeEmergencyContactInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeEmergencyContactInfoID = EmployeeEmergencyContactInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEmergencyContactInfoEntity.FLD_NAME_EmployeeEmergencyContactInfoID, EmployeeEmergencyContactInfoID.ToString(), SQLMatchType.Equal);

                        HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity = new HREmployeeEmergencyContactInfoEntity();


                        result = FCCHREmployeeEmergencyContactInfo.GetFacadeCreate().Delete(hREmployeeEmergencyContactInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeEmergencyContactInfoID = 0;
                            _HREmployeeEmergencyContactInfoEntity = new HREmployeeEmergencyContactInfoEntity();
                            PrepareInitialView();
                            BindHREmployeeEmergencyContactInfoList();
                            GetSelectedContactPersonInfo();

                            MiscUtil.ShowMessage(lblMessage, "Employee Emergency Contact Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Emergency Contact Info.", true);
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

        protected void odsHREmployeeEmergencyContactInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEmergencyContactInfoEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeEmergencyContactInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeEmergencyContactInfoID = 0;
            _HREmployeeEmergencyContactInfoEntity = new HREmployeeEmergencyContactInfoEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Drop Down Event

        protected void ddlEmergencyContactPersonID_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSelectedContactPersonInfo();
        }

        #endregion

        #endregion Event
    }
}
