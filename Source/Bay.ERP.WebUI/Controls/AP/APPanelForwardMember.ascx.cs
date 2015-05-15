// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




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
    public partial class APPanelForwardMemberControl : BaseControl
    {       
        #region Properties

        public Int64 _APPanelForwardMemberID
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

        public APPanelForwardMemberEntity _APPanelForwardMemberEntity
        {
            get
            {
                APPanelForwardMemberEntity entity = new APPanelForwardMemberEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (APPanelForwardMemberEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private APPanelForwardMemberEntity CurrentAPPanelForwardMemberEntity
        {
            get
            {
                if (_APPanelForwardMemberID > 0)
                {
                    if (_APPanelForwardMemberEntity.APPanelForwardMemberID != _APPanelForwardMemberID)
                    {
                        _APPanelForwardMemberEntity = FCCAPPanelForwardMember.GetFacadeCreate().GetByID(_APPanelForwardMemberID);
                    }
                }

                return _APPanelForwardMemberEntity;
            }
            set
            {
                _APPanelForwardMemberEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateAPPanel(ddlAPPanelID, false);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
            MiscUtil.PopulateMDDepartment(ddlDepartmentID, false);
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
            APPanelForwardMemberEntity aPPanelForwardMemberEntity = CurrentAPPanelForwardMemberEntity;


            if (!aPPanelForwardMemberEntity.IsNew)
            {
                if (ddlAPPanelID.Items.Count > 0 && aPPanelForwardMemberEntity.APPanelID != null)
                {
                    ddlAPPanelID.SelectedValue = aPPanelForwardMemberEntity.APPanelID.ToString();
                }

                if (ddlEmployeeID.Items.Count > 0 && aPPanelForwardMemberEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = aPPanelForwardMemberEntity.EmployeeID.ToString();
                }

                if (ddlDepartmentID.Items.Count > 0 && aPPanelForwardMemberEntity.DepartmentID != null)
                {
                    ddlDepartmentID.SelectedValue = aPPanelForwardMemberEntity.DepartmentID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindAPPanelForwardMemberList();
        }

        private void BindAPPanelForwardMemberList()
        {
            lvAPPanelForwardMember.DataBind();
        }

        private APPanelForwardMemberEntity BuildAPPanelForwardMemberEntity()
        {
            APPanelForwardMemberEntity aPPanelForwardMemberEntity = CurrentAPPanelForwardMemberEntity;

            if (ddlAPPanelID.Items.Count > 0)
            {
                if (ddlAPPanelID.SelectedValue == "0")
                {
                }
                else
                {
                    aPPanelForwardMemberEntity.APPanelID = Int64.Parse(ddlAPPanelID.SelectedValue);
                }
            }

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    aPPanelForwardMemberEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            if (ddlDepartmentID.Items.Count > 0)
            {
                if (ddlDepartmentID.SelectedValue == "0")
                {
                }
                else
                {
                    aPPanelForwardMemberEntity.DepartmentID = Int64.Parse(ddlDepartmentID.SelectedValue);
                }
            }


            return aPPanelForwardMemberEntity;
        }

        private void SaveAPPanelForwardMemberEntity()
        {
            if (IsValid)
            {
                try
                {
                    APPanelForwardMemberEntity aPPanelForwardMemberEntity = BuildAPPanelForwardMemberEntity();

                    Int64 result = -1;

                    if (aPPanelForwardMemberEntity.IsNew)
                    {
                        result = FCCAPPanelForwardMember.GetFacadeCreate().Add(aPPanelForwardMemberEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(APPanelForwardMemberEntity.FLD_NAME_APPanelForwardMemberID, aPPanelForwardMemberEntity.APPanelForwardMemberID.ToString(), SQLMatchType.Equal);
                        result = FCCAPPanelForwardMember.GetFacadeCreate().Update(aPPanelForwardMemberEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _APPanelForwardMemberID = 0;
                        _APPanelForwardMemberEntity = new APPanelForwardMemberEntity();
                        PrepareInitialView();
                        BindAPPanelForwardMemberList();

                        if (aPPanelForwardMemberEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PPanel Forward Member Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PPanel Forward Member Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aPPanelForwardMemberEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A PPanel Forward Member Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A PPanel Forward Member Information.", false);
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

        protected void lvAPPanelForwardMember_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 APPanelForwardMemberID;

            Int64.TryParse(e.CommandArgument.ToString(), out APPanelForwardMemberID);

            if (APPanelForwardMemberID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _APPanelForwardMemberID = APPanelForwardMemberID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(APPanelForwardMemberEntity.FLD_NAME_APPanelForwardMemberID, APPanelForwardMemberID.ToString(), SQLMatchType.Equal);

                        APPanelForwardMemberEntity aPPanelForwardMemberEntity = new APPanelForwardMemberEntity();


                        result = FCCAPPanelForwardMember.GetFacadeCreate().Delete(aPPanelForwardMemberEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _APPanelForwardMemberID = 0;
                            _APPanelForwardMemberEntity = new APPanelForwardMemberEntity();
                            PrepareInitialView();
                            BindAPPanelForwardMemberList();

                            MiscUtil.ShowMessage(lblMessage, "A PPanel Forward Member has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A PPanel Forward Member.", true);
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

        protected void odsAPPanelForwardMember_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            Int64 aPPanelID = 0;
            Int64.TryParse(ddlAPPanelID.SelectedValue, out aPPanelID);

            String fe = SqlExpressionBuilder.PrepareFilterExpression("APPanelForwardMember." + APPanelMember_CustomEntity.FLD_NAME_APPanelID, aPPanelID.ToString(), SQLMatchType.Equal);
            
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveAPPanelForwardMemberEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _APPanelForwardMemberID = 0;
            _APPanelForwardMemberEntity = new APPanelForwardMemberEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        protected void ddlAPPanelID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindList();
        }


        #endregion Event
    }
}
