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
    public partial class CMContractorLicenceControl : ContractorBaseControl
    {       
        #region Properties

        public Int64 _ContractorLicenceID
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

        public CMContractorLicenceEntity _CMContractorLicenceEntity
        {
            get
            {
                CMContractorLicenceEntity entity = new CMContractorLicenceEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMContractorLicenceEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMContractorLicenceEntity CurrentCMContractorLicenceEntity
        {
            get
            {
                if (_ContractorLicenceID > 0)
                {
                    if (_CMContractorLicenceEntity.ContractorLicenceID != _ContractorLicenceID)
                    {
                        _CMContractorLicenceEntity = FCCCMContractorLicence.GetFacadeCreate().GetByID(_ContractorLicenceID);
                    }
                }

                return _CMContractorLicenceEntity;
            }
            set
            {
                _CMContractorLicenceEntity = value;
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

            txtLicenceNo.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMContractorLicenceEntity cMContractorLicenceEntity = CurrentCMContractorLicenceEntity;


            if (!cMContractorLicenceEntity.IsNew)
            {
               

                txtLicenceNo.Text = cMContractorLicenceEntity.LicenceNo.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMContractorLicenceList();
        }

        private void BindCMContractorLicenceList()
        {
            lvCMContractorLicence.DataBind();
        }

        private CMContractorLicenceEntity BuildCMContractorLicenceEntity()
        {
            CMContractorLicenceEntity cMContractorLicenceEntity = CurrentCMContractorLicenceEntity;

            cMContractorLicenceEntity.ContractorID = this.OverviewContractorID;
            cMContractorLicenceEntity.LicenceNo = txtLicenceNo.Text.Trim();

            return cMContractorLicenceEntity;
        }

        private void SaveCMContractorLicenceEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMContractorLicenceEntity cMContractorLicenceEntity = BuildCMContractorLicenceEntity();

                    Int64 result = -1;

                    if (cMContractorLicenceEntity.IsNew)
                    {
                        result = FCCCMContractorLicence.GetFacadeCreate().Add(cMContractorLicenceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMContractorLicenceEntity.FLD_NAME_ContractorLicenceID, cMContractorLicenceEntity.ContractorLicenceID.ToString(), SQLMatchType.Equal);
                        result = FCCCMContractorLicence.GetFacadeCreate().Update(cMContractorLicenceEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ContractorLicenceID = 0;
                        _CMContractorLicenceEntity = new CMContractorLicenceEntity();
                        PrepareInitialView();
                        BindCMContractorLicenceList();

                        if (cMContractorLicenceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Licence Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Licence Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMContractorLicenceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Contractor Licence Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Contractor Licence Information.", false);
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

        protected void lvCMContractorLicence_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ContractorLicenceID;

            Int64.TryParse(e.CommandArgument.ToString(), out ContractorLicenceID);

            if (ContractorLicenceID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ContractorLicenceID = ContractorLicenceID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMContractorLicenceEntity.FLD_NAME_ContractorLicenceID, ContractorLicenceID.ToString(), SQLMatchType.Equal);

                        CMContractorLicenceEntity cMContractorLicenceEntity = new CMContractorLicenceEntity();


                        result = FCCCMContractorLicence.GetFacadeCreate().Delete(cMContractorLicenceEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ContractorLicenceID = 0;
                            _CMContractorLicenceEntity = new CMContractorLicenceEntity();
                            PrepareInitialView();
                            BindCMContractorLicenceList();

                            MiscUtil.ShowMessage(lblMessage, "Contractor Licence has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Contractor Licence.", true);
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

        protected void odsCMContractorLicence_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMContractorLicenceEntity.FLD_NAME_ContractorID, this.OverviewContractorID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMContractorLicenceEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ContractorLicenceID = 0;
            _CMContractorLicenceEntity = new CMContractorLicenceEntity();
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
