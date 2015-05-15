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
    public partial class ACAccountResourceAccountMapControl : BaseControl
    {       
        #region Properties

        public Int64 accountResourceCategory { get; set; }
        public Int64 referenceID { get; set; }

        public Int64 _ResourceAccountMapID
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

        public ACAccountResourceAccountMapEntity _ACAccountResourceAccountMapEntity
        {
            get
            {
                ACAccountResourceAccountMapEntity entity = new ACAccountResourceAccountMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACAccountResourceAccountMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACAccountResourceAccountMapEntity CurrentACAccountResourceAccountMapEntity
        {
            get
            {
                if (_ResourceAccountMapID > 0)
                {
                    if (_ACAccountResourceAccountMapEntity.ResourceAccountMapID != _ResourceAccountMapID)
                    {
                        _ACAccountResourceAccountMapEntity = FCCACAccountResourceAccountMap.GetFacadeCreate().GetByID(_ResourceAccountMapID);
                    }
                }

                return _ACAccountResourceAccountMapEntity;
            }
            set
            {
                _ACAccountResourceAccountMapEntity = value;
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

            txtRemarks.Text = String.Empty;
            hdEmpID.Value = "0";
            txtItemName.Text = String.Empty;
            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity = CurrentACAccountResourceAccountMapEntity;


            if (!aCAccountResourceAccountMapEntity.IsNew)
            {
                if (aCAccountResourceAccountMapEntity.AccountID > 0)
                {
                    //txtItemName.Text = aCAccountResourceAccountMapEntity..ToString();
                    hdEmpID.Value = aCAccountResourceAccountMapEntity.AccountID.ToString();
                }

                txtRemarks.Text = aCAccountResourceAccountMapEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACAccountResourceAccountMapList();
        }

        private void BindACAccountResourceAccountMapList()
        {
            lvACAccountResourceAccountMap.DataBind();
        }

        

        private ACAccountResourceAccountMapEntity BuildACAccountResourceAccountMapEntity()
        {
            ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity = CurrentACAccountResourceAccountMapEntity;

            if (hdEmpID.Value != "0")
            {
                aCAccountResourceAccountMapEntity.AccountID = Int64.Parse(hdEmpID.Value);
            }         

            if (accountResourceCategory > 0)
            {
                aCAccountResourceAccountMapEntity.AccountResourceCategoryID = accountResourceCategory;
            }

            if (referenceID>0)
            {
                aCAccountResourceAccountMapEntity.ReferenceID = referenceID;
            }

            if (!txtRemarks.Text.Trim().IsNullOrEmpty())
            {
                aCAccountResourceAccountMapEntity.Remarks = txtRemarks.Text.Trim();
            }
            else
            {
                aCAccountResourceAccountMapEntity.Remarks = null;
            }


            return aCAccountResourceAccountMapEntity;
        }

        private void SaveACAccountResourceAccountMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity = BuildACAccountResourceAccountMapEntity();

                    Int64 result = -1;

                    if (aCAccountResourceAccountMapEntity.IsNew)
                    {
                        result = FCCACAccountResourceAccountMap.GetFacadeCreate().Add(aCAccountResourceAccountMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACAccountResourceAccountMapEntity.FLD_NAME_ResourceAccountMapID, aCAccountResourceAccountMapEntity.ResourceAccountMapID.ToString(), SQLMatchType.Equal);
                        result = FCCACAccountResourceAccountMap.GetFacadeCreate().Update(aCAccountResourceAccountMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ResourceAccountMapID = 0;
                        _ACAccountResourceAccountMapEntity = new ACAccountResourceAccountMapEntity();
                        PrepareInitialView();
                        BindACAccountResourceAccountMapList();

                        if (aCAccountResourceAccountMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Account Resource Account Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Account Resource Account Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCAccountResourceAccountMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Account Resource Account Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Account Resource Account Map Information.", false);
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

        protected void lvACAccountResourceAccountMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ResourceAccountMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out ResourceAccountMapID);

            if (ResourceAccountMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ResourceAccountMapID = ResourceAccountMapID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACAccountResourceAccountMapEntity.FLD_NAME_ResourceAccountMapID, ResourceAccountMapID.ToString(), SQLMatchType.Equal);

                        ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity = new ACAccountResourceAccountMapEntity();


                        result = FCCACAccountResourceAccountMap.GetFacadeCreate().Delete(aCAccountResourceAccountMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ResourceAccountMapID = 0;
                            _ACAccountResourceAccountMapEntity = new ACAccountResourceAccountMapEntity();
                            PrepareInitialView();
                            BindACAccountResourceAccountMapList();

                            MiscUtil.ShowMessage(lblMessage, "A CAccount Resource Account Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CAccount Resource Account Map.", true);
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

        protected void odsACAccountResourceAccountMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (accountResourceCategory > 0 && referenceID > 0)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(ACAccountResourceAccountMapEntity.FLD_NAME_AccountResourceCategoryID, accountResourceCategory.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(ACAccountResourceAccountMapEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACAccountResourceAccountMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ResourceAccountMapID = 0;
            _ACAccountResourceAccountMapEntity = new ACAccountResourceAccountMapEntity();
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
