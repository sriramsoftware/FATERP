// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




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
    public partial class CMFinancialStrengthMajorWorkControl : ContractorBaseControl
    {       
        #region Properties

        public Int64 _FinancialStrengthMajorWorkID
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

        public CMFinancialStrengthMajorWorkEntity _CMFinancialStrengthMajorWorkEntity
        {
            get
            {
                CMFinancialStrengthMajorWorkEntity entity = new CMFinancialStrengthMajorWorkEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMFinancialStrengthMajorWorkEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMFinancialStrengthMajorWorkEntity CurrentCMFinancialStrengthMajorWorkEntity
        {
            get
            {
                if (_FinancialStrengthMajorWorkID > 0)
                {
                    if (_CMFinancialStrengthMajorWorkEntity.FinancialStrengthMajorWorkID != _FinancialStrengthMajorWorkID)
                    {
                        _CMFinancialStrengthMajorWorkEntity = FCCCMFinancialStrengthMajorWork.GetFacadeCreate().GetByID(_FinancialStrengthMajorWorkID);
                    }
                }

                return _CMFinancialStrengthMajorWorkEntity;
            }
            set
            {
                _CMFinancialStrengthMajorWorkEntity = value;
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
            CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity = CurrentCMFinancialStrengthMajorWorkEntity;


            if (!cMFinancialStrengthMajorWorkEntity.IsNew)
            {
                

                txtName.Text = cMFinancialStrengthMajorWorkEntity.Name.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMFinancialStrengthMajorWorkList();
        }

        private void BindCMFinancialStrengthMajorWorkList()
        {
            lvCMFinancialStrengthMajorWork.DataBind();
        }

        private CMFinancialStrengthMajorWorkEntity BuildCMFinancialStrengthMajorWorkEntity()
        {
            CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity = CurrentCMFinancialStrengthMajorWorkEntity;

            cMFinancialStrengthMajorWorkEntity.ContractorID = this.OverviewContractorID;

            cMFinancialStrengthMajorWorkEntity.Name = txtName.Text.Trim();

            return cMFinancialStrengthMajorWorkEntity;
        }

        private void SaveCMFinancialStrengthMajorWorkEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity = BuildCMFinancialStrengthMajorWorkEntity();

                    Int64 result = -1;

                    if (cMFinancialStrengthMajorWorkEntity.IsNew)
                    {
                        result = FCCCMFinancialStrengthMajorWork.GetFacadeCreate().Add(cMFinancialStrengthMajorWorkEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMFinancialStrengthMajorWorkEntity.FLD_NAME_FinancialStrengthMajorWorkID, cMFinancialStrengthMajorWorkEntity.FinancialStrengthMajorWorkID.ToString(), SQLMatchType.Equal);
                        result = FCCCMFinancialStrengthMajorWork.GetFacadeCreate().Update(cMFinancialStrengthMajorWorkEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _FinancialStrengthMajorWorkID = 0;
                        _CMFinancialStrengthMajorWorkEntity = new CMFinancialStrengthMajorWorkEntity();
                        PrepareInitialView();
                        BindCMFinancialStrengthMajorWorkList();

                        if (cMFinancialStrengthMajorWorkEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Financial Strength Major Work Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Financial Strength Major Work Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMFinancialStrengthMajorWorkEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Financial Strength Major Work Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Financial Strength Major Work Information.", false);
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

        protected void lvCMFinancialStrengthMajorWork_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 FinancialStrengthMajorWorkID;

            Int64.TryParse(e.CommandArgument.ToString(), out FinancialStrengthMajorWorkID);

            if (FinancialStrengthMajorWorkID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _FinancialStrengthMajorWorkID = FinancialStrengthMajorWorkID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMFinancialStrengthMajorWorkEntity.FLD_NAME_FinancialStrengthMajorWorkID, FinancialStrengthMajorWorkID.ToString(), SQLMatchType.Equal);

                        CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity = new CMFinancialStrengthMajorWorkEntity();


                        result = FCCCMFinancialStrengthMajorWork.GetFacadeCreate().Delete(cMFinancialStrengthMajorWorkEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _FinancialStrengthMajorWorkID = 0;
                            _CMFinancialStrengthMajorWorkEntity = new CMFinancialStrengthMajorWorkEntity();
                            PrepareInitialView();
                            BindCMFinancialStrengthMajorWorkList();

                            MiscUtil.ShowMessage(lblMessage, "Financial Strength Major Work has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Financial Strength Major Work.", true);
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

        protected void odsCMFinancialStrengthMajorWork_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMFinancialStrengthMajorWorkEntity.FLD_NAME_ContractorID, this.OverviewContractorID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMFinancialStrengthMajorWorkEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _FinancialStrengthMajorWorkID = 0;
            _CMFinancialStrengthMajorWorkEntity = new CMFinancialStrengthMajorWorkEntity();
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
