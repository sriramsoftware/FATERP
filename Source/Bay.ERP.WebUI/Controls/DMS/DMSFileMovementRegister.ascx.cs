// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




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
    public partial class DMSFileMovementRegisterControl : BaseControl
    {       
        #region Properties

        public Int64 _FileMovementRegisterID
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

        public DMSFileMovementRegisterEntity _DMSFileMovementRegisterEntity
        {
            get
            {
                DMSFileMovementRegisterEntity entity = new DMSFileMovementRegisterEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (DMSFileMovementRegisterEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private DMSFileMovementRegisterEntity CurrentDMSFileMovementRegisterEntity
        {
            get
            {
                if (_FileMovementRegisterID > 0)
                {
                    if (_DMSFileMovementRegisterEntity.FileMovementRegisterID != _FileMovementRegisterID)
                    {
                        _DMSFileMovementRegisterEntity = FCCDMSFileMovementRegister.GetFacadeCreate().GetByID(_FileMovementRegisterID);
                    }
                }

                return _DMSFileMovementRegisterEntity;
            }
            set
            {
                _DMSFileMovementRegisterEntity = value;
            }
        }

        #endregion

        #region Methods


        private void BindDropDownFileByDepartment()
        {
            if (ddlDepartmentID != null && ddlDepartmentID.SelectedValue != "0" &&ddlDepartmentID.Items.Count>0)
            {
                MiscUtil.PopulateDMSFileTrackingByDepartmentID(ddlFileTrackingID, false, Int64.Parse(ddlDepartmentID.SelectedValue.ToString()));
            }
        }

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDDepartmentDistinct(ddlDepartmentID, false);
            MiscUtil.PopulateHREmployee(ddlGivenToEmployeeID, false);
            BindDropDownFileByDepartment();

        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtMovementDateTime.Text = String.Empty;
            txtFileMovementPlace.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            DMSFileMovementRegisterEntity dMSFileMovementRegisterEntity = CurrentDMSFileMovementRegisterEntity;


            if (!dMSFileMovementRegisterEntity.IsNew)
            {
                String fe=SqlExpressionBuilder.PrepareFilterExpression(DMSFileTrackingEntity.FLD_NAME_FileTrackingID,dMSFileMovementRegisterEntity.FileTrackingID.ToString(),SQLMatchType.Equal);
                IList<DMSFileTrackingEntity> dMSFileTrackingList = FCCDMSFileTracking.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (dMSFileTrackingList != null && dMSFileTrackingList.Count > 0)
                {
                    if (ddlDepartmentID.Items.Count > 0)
                    {
                        ddlDepartmentID.SelectedValue = dMSFileTrackingList[0].DepartmentID.ToString();
                    }
                }

                BindDropDownFileByDepartment();

                if (ddlFileTrackingID.Items.Count > 0 && dMSFileMovementRegisterEntity.FileTrackingID != null)
                {
                    ddlFileTrackingID.SelectedValue = dMSFileMovementRegisterEntity.FileTrackingID.ToString();
                }

                if (ddlGivenToEmployeeID.Items.Count > 0 && dMSFileMovementRegisterEntity.GivenToEmployeeID != null)
                {
                    ddlGivenToEmployeeID.SelectedValue = dMSFileMovementRegisterEntity.GivenToEmployeeID.ToString();
                }
             
                txtMovementDateTime.Text = dMSFileMovementRegisterEntity.MovementDateTime.ToStringDefault();
                txtFileMovementPlace.Text = dMSFileMovementRegisterEntity.FileMovementPlace.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindDMSFileMovementRegisterList();
        }

        private void BindDMSFileMovementRegisterList()
        {
            lvDMSFileMovementRegister.DataBind();
        }

        private DMSFileMovementRegisterEntity BuildDMSFileMovementRegisterEntity()
        {
            DMSFileMovementRegisterEntity dMSFileMovementRegisterEntity = CurrentDMSFileMovementRegisterEntity;

            if (ddlFileTrackingID.Items.Count > 0)
            {
                if (ddlFileTrackingID.SelectedValue == "0")
                {
                }
                else
                {
                    dMSFileMovementRegisterEntity.FileTrackingID = Int64.Parse(ddlFileTrackingID.SelectedValue);
                }
            }

            if (ddlGivenToEmployeeID.Items.Count > 0)
            {
                if (ddlGivenToEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    dMSFileMovementRegisterEntity.GivenToEmployeeID = Int64.Parse(ddlGivenToEmployeeID.SelectedValue);
                }
            }

            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_MemberID, this.CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
            IList<HREmployeeEntity> lstEmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lstEmployee != null && lstEmployee.Count > 0)
            {
                dMSFileMovementRegisterEntity.GivenByEmployeeID = lstEmployee[0].EmployeeID;
            }

            if (txtMovementDateTime.Text.Trim().IsNotNullOrEmpty())
            {
                dMSFileMovementRegisterEntity.MovementDateTime = MiscUtil.ParseToDateTime(txtMovementDateTime.Text);
            }

            dMSFileMovementRegisterEntity.FileMovementPlace = txtFileMovementPlace.Text.Trim();

            return dMSFileMovementRegisterEntity;
        }

        private void SaveDMSFileMovementRegisterEntity()
        {
            if (IsValid)
            {
                try
                {
                    DMSFileMovementRegisterEntity dMSFileMovementRegisterEntity = BuildDMSFileMovementRegisterEntity();

                    Int64 result = -1;

                    if (dMSFileMovementRegisterEntity.IsNew)
                    {
                        result = FCCDMSFileMovementRegister.GetFacadeCreate().Add(dMSFileMovementRegisterEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(DMSFileMovementRegisterEntity.FLD_NAME_FileMovementRegisterID, dMSFileMovementRegisterEntity.FileMovementRegisterID.ToString(), SQLMatchType.Equal);
                        result = FCCDMSFileMovementRegister.GetFacadeCreate().Update(dMSFileMovementRegisterEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        #region Update File Current Location

                        _FileMovementRegisterID = result;

                        DMSFileMovementRegisterEntity _dMSFileMovementRegisterEntity = CurrentDMSFileMovementRegisterEntity;

                        DMSFileTrackingEntity dMSFileTrackingEntity = FCCDMSFileTracking.GetFacadeCreate().GetByID(_dMSFileMovementRegisterEntity.FileTrackingID);
                        dMSFileTrackingEntity.FileCurrentPlace = _dMSFileMovementRegisterEntity.FileMovementPlace;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSFileTrackingEntity.FLD_NAME_FileTrackingID, _dMSFileMovementRegisterEntity.FileTrackingID.ToString(), SQLMatchType.Equal);
                        result = FCCDMSFileTracking.GetFacadeCreate().Update(dMSFileTrackingEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                        #endregion

                        _FileMovementRegisterID = 0;
                        _DMSFileMovementRegisterEntity = new DMSFileMovementRegisterEntity();
                        PrepareInitialView();
                        BindDMSFileMovementRegisterList();

                        if (dMSFileMovementRegisterEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "File Movement Register Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "File Movement Register Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (dMSFileMovementRegisterEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add File Movement Register Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update File Movement Register Information.", false);
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

        protected void lvDMSFileMovementRegister_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 FileMovementRegisterID;

            Int64.TryParse(e.CommandArgument.ToString(), out FileMovementRegisterID);

            if (FileMovementRegisterID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _FileMovementRegisterID = FileMovementRegisterID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSFileMovementRegisterEntity.FLD_NAME_FileMovementRegisterID, FileMovementRegisterID.ToString(), SQLMatchType.Equal);

                        DMSFileMovementRegisterEntity dMSFileMovementRegisterEntity = new DMSFileMovementRegisterEntity();


                        result = FCCDMSFileMovementRegister.GetFacadeCreate().Delete(dMSFileMovementRegisterEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _FileMovementRegisterID = 0;
                            _DMSFileMovementRegisterEntity = new DMSFileMovementRegisterEntity();
                            PrepareInitialView();
                            BindDMSFileMovementRegisterList();

                            MiscUtil.ShowMessage(lblMessage, "D MSFile Movement Register has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete D MSFile Movement Register.", true);
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

        protected void odsDMSFileMovementRegister_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveDMSFileMovementRegisterEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _FileMovementRegisterID = 0;
            _DMSFileMovementRegisterEntity = new DMSFileMovementRegisterEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDropDownFileByDepartment();
        }

        #endregion

        #endregion Event
    }
}
