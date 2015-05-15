// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public partial class CMContractorMajorProjectExecutedControl : ContractorBaseControl
    {       
        #region Properties

        public Int64 _ContractorMajorProjectExecutedID
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

        public CMContractorMajorProjectExecutedEntity _CMContractorMajorProjectExecutedEntity
        {
            get
            {
                CMContractorMajorProjectExecutedEntity entity = new CMContractorMajorProjectExecutedEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMContractorMajorProjectExecutedEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMContractorMajorProjectExecutedEntity CurrentCMContractorMajorProjectExecutedEntity
        {
            get
            {
                if (_ContractorMajorProjectExecutedID > 0)
                {
                    if (_CMContractorMajorProjectExecutedEntity.ContractorMajorProjectExecutedID != _ContractorMajorProjectExecutedID)
                    {
                        _CMContractorMajorProjectExecutedEntity = FCCCMContractorMajorProjectExecuted.GetFacadeCreate().GetByID(_ContractorMajorProjectExecutedID);
                    }
                }

                return _CMContractorMajorProjectExecutedEntity;
            }
            set
            {
                _CMContractorMajorProjectExecutedEntity = value;
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

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMContractorMajorProjectExecutedEntity cMContractorMajorProjectExecutedEntity = CurrentCMContractorMajorProjectExecutedEntity;


            if (!cMContractorMajorProjectExecutedEntity.IsNew)
            {
                txtName.Text = cMContractorMajorProjectExecutedEntity.Name.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMContractorMajorProjectExecutedList();
        }

        private void BindCMContractorMajorProjectExecutedList()
        {
            lvCMContractorMajorProjectExecuted.DataBind();
        }

        private CMContractorMajorProjectExecutedEntity BuildCMContractorMajorProjectExecutedEntity()
        {
            CMContractorMajorProjectExecutedEntity cMContractorMajorProjectExecutedEntity = CurrentCMContractorMajorProjectExecutedEntity;

            cMContractorMajorProjectExecutedEntity.ContractorID = this.OverviewContractorID;

            cMContractorMajorProjectExecutedEntity.Name = txtName.Text.Trim();

            return cMContractorMajorProjectExecutedEntity;
        }

        private void SaveCMContractorMajorProjectExecutedEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMContractorMajorProjectExecutedEntity cMContractorMajorProjectExecutedEntity = BuildCMContractorMajorProjectExecutedEntity();

                    Int64 result = -1;

                    if (cMContractorMajorProjectExecutedEntity.IsNew)
                    {
                        result = FCCCMContractorMajorProjectExecuted.GetFacadeCreate().Add(cMContractorMajorProjectExecutedEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMContractorMajorProjectExecutedEntity.FLD_NAME_ContractorMajorProjectExecutedID, cMContractorMajorProjectExecutedEntity.ContractorMajorProjectExecutedID.ToString(), SQLMatchType.Equal);
                        result = FCCCMContractorMajorProjectExecuted.GetFacadeCreate().Update(cMContractorMajorProjectExecutedEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ContractorMajorProjectExecutedID = 0;
                        _CMContractorMajorProjectExecutedEntity = new CMContractorMajorProjectExecutedEntity();
                        PrepareInitialView();
                        BindCMContractorMajorProjectExecutedList();

                        if (cMContractorMajorProjectExecutedEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Major Project Executed Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Major Project Executed Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMContractorMajorProjectExecutedEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Contractor Major Project Executed Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Contractor Major Project Executed Information.", false);
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

        protected void lvCMContractorMajorProjectExecuted_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ContractorMajorProjectExecutedID;

            Int64.TryParse(e.CommandArgument.ToString(), out ContractorMajorProjectExecutedID);

            if (ContractorMajorProjectExecutedID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ContractorMajorProjectExecutedID = ContractorMajorProjectExecutedID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMContractorMajorProjectExecutedEntity.FLD_NAME_ContractorMajorProjectExecutedID, ContractorMajorProjectExecutedID.ToString(), SQLMatchType.Equal);

                        CMContractorMajorProjectExecutedEntity cMContractorMajorProjectExecutedEntity = new CMContractorMajorProjectExecutedEntity();


                        result = FCCCMContractorMajorProjectExecuted.GetFacadeCreate().Delete(cMContractorMajorProjectExecutedEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ContractorMajorProjectExecutedID = 0;
                            _CMContractorMajorProjectExecutedEntity = new CMContractorMajorProjectExecutedEntity();
                            PrepareInitialView();
                            BindCMContractorMajorProjectExecutedList();

                            MiscUtil.ShowMessage(lblMessage, "Contractor Major Project Executed has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Contractor Major Project Executed.", true);
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

        protected void odsCMContractorMajorProjectExecuted_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMContractorMajorProjectExecutedEntity.FLD_NAME_ContractorID, this.OverviewContractorID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMContractorMajorProjectExecutedEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ContractorMajorProjectExecutedID = 0;
            _CMContractorMajorProjectExecutedEntity = new CMContractorMajorProjectExecutedEntity();
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
