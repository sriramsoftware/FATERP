// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Jun-2013, 05:04:04




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
    public partial class ACResourceBankAccountMapControl : BaseControl
    {       
        #region Properties

        public Int64 accountResourceCategory { get; set; }
        public Int64 referenceID { get; set; }

        public Int64 _ResourceBankAccountMapID
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

        public ACResourceBankAccountMapEntity _ACResourceBankAccountMapEntity
        {
            get
            {
                ACResourceBankAccountMapEntity entity = new ACResourceBankAccountMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACResourceBankAccountMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACResourceBankAccountMapEntity CurrentACResourceBankAccountMapEntity
        {
            get
            {
                if (_ResourceBankAccountMapID > 0)
                {
                    if (_ACResourceBankAccountMapEntity.ResourceBankAccountMapID != _ResourceBankAccountMapID)
                    {
                        _ACResourceBankAccountMapEntity = FCCACResourceBankAccountMap.GetFacadeCreate().GetByID(_ResourceBankAccountMapID);
                    }
                }

                return _ACResourceBankAccountMapEntity;
            }
            set
            {
                _ACResourceBankAccountMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            //MiscUtil.PopulateACMDAccountResourceCategory(ddlAccountResourceCategoryID, false);
        }

        //private Int64 PrepareResourceCategory()
        //{
        //    Int64 resourceCategoryID=0;

        //    switch (accountResourceCategory)
        //    {
        //        case MasterDataConstants.ACMDAccountResourceCategory.VENDOR:
        //        case MasterDataConstants.ACMDAccountResourceCategory.CONSULTANT:
        //        case MasterDataConstants.ACMDAccountResourceCategory.CONTRACTOR:
        //            if(referenceID>0)
        //            {
        //                PRMSupplierEntity prmSupplierEntity=FCCPRMSupplier.GetFacadeCreate().GetByID(referenceID);

        //                if(prmSupplierEntity!=null && prmSupplierEntity.SupplierID>0)
        //                {
        //                    switch(prmSupplierEntity.SupplierTypeID)
        //                    {
        //                        case MasterDataConstants.MDSupplierType.LOCAL:
        //                            case MasterDataConstants.MDSupplierType.IMPORTER:
        //                            case MasterDataConstants.MDSupplierType.LOCAL_AND_IMPORTER:
        //                                resourceCategoryID=MasterDataConstants.ACMDAccountResourceCategory.VENDOR;
        //                                break;
        //                        case MasterDataConstants.MDSupplierType.CONTRACTOR:
        //                                resourceCategoryID = MasterDataConstants.ACMDAccountResourceCategory.CONTRACTOR;
        //                                break;
        //                        case MasterDataConstants.MDSupplierType.CONSULTANT:
        //                                resourceCategoryID = MasterDataConstants.ACMDAccountResourceCategory.CONSULTANT;
        //                                break;

        //                    }
        //                }
        //            }
        //            break;

        //        case MasterDataConstants.ACMDAccountResourceCategory.EMPLOYEE:
        //            //need to implement
        //            break;
        //    }

        //    return resourceCategoryID;
        //}

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtBankAccountName.Text = String.Empty;
            txtBankAccountNumber.Text = String.Empty;
            chkIsDefaultCurrencyAccount.Checked = false;
            txtBankName.Text = String.Empty;
            txtBankAddress.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity = CurrentACResourceBankAccountMapEntity;


            if (!aCResourceBankAccountMapEntity.IsNew)
            {   
                //if (ddlAccountResourceCategoryID.Items.Count > 0 && aCResourceBankAccountMapEntity.AccountResourceCategoryID != null)
                //{
                //    ddlAccountResourceCategoryID.SelectedValue = aCResourceBankAccountMapEntity.AccountResourceCategoryID.ToString();
                //}
                txtBankAccountName.Text = aCResourceBankAccountMapEntity.BankAccountName.ToString();
                txtBankAccountNumber.Text = aCResourceBankAccountMapEntity.BankAccountNumber.ToString();
                chkIsDefaultCurrencyAccount.Checked = aCResourceBankAccountMapEntity.IsDefaultCurrencyAccount;
                txtBankName.Text = aCResourceBankAccountMapEntity.BankName.ToString();
                txtBankAddress.Text = aCResourceBankAccountMapEntity.BankAddress.ToString();
                txtRemarks.Text = aCResourceBankAccountMapEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACResourceBankAccountMapList();
        }

        private void BindACResourceBankAccountMapList()
        {
            lvACResourceBankAccountMap.DataBind();
        }

        private ACResourceBankAccountMapEntity BuildACResourceBankAccountMapEntity()
        {
            ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity = CurrentACResourceBankAccountMapEntity;

            if (accountResourceCategory > 0)
            {
                aCResourceBankAccountMapEntity.AccountResourceCategoryID = accountResourceCategory;
            }

            //if (ddlAccountResourceCategoryID.Items.Count > 0)
            //{
            //    if (ddlAccountResourceCategoryID.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        aCResourceBankAccountMapEntity.AccountResourceCategoryID = Int64.Parse(ddlAccountResourceCategoryID.SelectedValue);
            //    }
            //}

            if(referenceID>0)
            {
                aCResourceBankAccountMapEntity.ReferenceID = referenceID;
            }

            aCResourceBankAccountMapEntity.BankAccountName = txtBankAccountName.Text.Trim();
            aCResourceBankAccountMapEntity.BankAccountNumber = txtBankAccountNumber.Text.Trim();

            //String fe=SqlExpressionBuilder.PrepareFilterExpression(ACResour

            aCResourceBankAccountMapEntity.IsDefaultCurrencyAccount = chkIsDefaultCurrencyAccount.Checked;

            aCResourceBankAccountMapEntity.BankName = txtBankName.Text.Trim();
            aCResourceBankAccountMapEntity.BankAddress = txtBankAddress.Text.Trim();
            aCResourceBankAccountMapEntity.Remarks = txtRemarks.Text.Trim();

            return aCResourceBankAccountMapEntity;
        }

        private void SaveACResourceBankAccountMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity = BuildACResourceBankAccountMapEntity();

                    Int64 result = -1;

                    if (aCResourceBankAccountMapEntity.IsNew)
                    {
                        result = FCCACResourceBankAccountMap.GetFacadeCreate().Add(aCResourceBankAccountMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACResourceBankAccountMapEntity.FLD_NAME_ResourceBankAccountMapID, aCResourceBankAccountMapEntity.ResourceBankAccountMapID.ToString(), SQLMatchType.Equal);
                        result = FCCACResourceBankAccountMap.GetFacadeCreate().Update(aCResourceBankAccountMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ResourceBankAccountMapID = 0;
                        _ACResourceBankAccountMapEntity = new ACResourceBankAccountMapEntity();
                        PrepareInitialView();
                        BindACResourceBankAccountMapList();

                        if (aCResourceBankAccountMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Resource Bank Account Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Resource Bank Account Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCResourceBankAccountMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Resource Bank Account Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Resource Bank Account Map Information.", false);
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

        protected void lvACResourceBankAccountMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ResourceBankAccountMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out ResourceBankAccountMapID);

            if (ResourceBankAccountMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ResourceBankAccountMapID = ResourceBankAccountMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACResourceBankAccountMapEntity.FLD_NAME_ResourceBankAccountMapID, ResourceBankAccountMapID.ToString(), SQLMatchType.Equal);

                        ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity = new ACResourceBankAccountMapEntity();


                        result = FCCACResourceBankAccountMap.GetFacadeCreate().Delete(aCResourceBankAccountMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ResourceBankAccountMapID = 0;
                            _ACResourceBankAccountMapEntity = new ACResourceBankAccountMapEntity();
                            PrepareInitialView();
                            BindACResourceBankAccountMapList();

                            MiscUtil.ShowMessage(lblMessage, "A CResource Bank Account Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CResource Bank Account Map.", true);
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

        protected void odsACResourceBankAccountMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (accountResourceCategory > 0 && referenceID > 0)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(ACResourceBankAccountMapEntity.FLD_NAME_AccountResourceCategoryID, accountResourceCategory.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(ACResourceBankAccountMapEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACResourceBankAccountMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ResourceBankAccountMapID = 0;
            _ACResourceBankAccountMapEntity = new ACResourceBankAccountMapEntity();
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
