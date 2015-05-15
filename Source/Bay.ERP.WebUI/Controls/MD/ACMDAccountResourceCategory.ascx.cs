// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14
//Changes made by Raju Dutta 04-11-13.




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
    public partial class ACMDAccountResourceCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _AccountResourceCategoryID
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

        public ACMDAccountResourceCategoryEntity _ACMDAccountResourceCategoryEntity
        {
            get
            {
                ACMDAccountResourceCategoryEntity entity = new ACMDAccountResourceCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACMDAccountResourceCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACMDAccountResourceCategoryEntity CurrentACMDAccountResourceCategoryEntity
        {
            get
            {
                if (_AccountResourceCategoryID > 0)
                {
                    if (_ACMDAccountResourceCategoryEntity.AccountResourceCategoryID != _AccountResourceCategoryID)
                    {
                        _ACMDAccountResourceCategoryEntity = FCCACMDAccountResourceCategory.GetFacadeCreate().GetByID(_AccountResourceCategoryID);
                    }
                }

                return _ACMDAccountResourceCategoryEntity;
            }
            set
            {
                _ACMDAccountResourceCategoryEntity = value;
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
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACMDAccountResourceCategoryEntity aCMDAccountResourceCategoryEntity = CurrentACMDAccountResourceCategoryEntity;


            if (!aCMDAccountResourceCategoryEntity.IsNew)
            {
                txtName.Text = aCMDAccountResourceCategoryEntity.Name.ToString();
                txtDescription.Text = aCMDAccountResourceCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = aCMDAccountResourceCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACMDAccountResourceCategoryList();
        }

        private void BindACMDAccountResourceCategoryList()
        {
            lvACMDAccountResourceCategory.DataBind();
        }

        private ACMDAccountResourceCategoryEntity BuildACMDAccountResourceCategoryEntity()
        {
            ACMDAccountResourceCategoryEntity aCMDAccountResourceCategoryEntity = CurrentACMDAccountResourceCategoryEntity;

            aCMDAccountResourceCategoryEntity.Name = txtName.Text.Trim();
            aCMDAccountResourceCategoryEntity.Description = txtDescription.Text.Trim();
            aCMDAccountResourceCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return aCMDAccountResourceCategoryEntity;
        }

        private void SaveACMDAccountResourceCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACMDAccountResourceCategoryEntity aCMDAccountResourceCategoryEntity = BuildACMDAccountResourceCategoryEntity();

                    Int64 result = -1;

                    if (aCMDAccountResourceCategoryEntity.IsNew)
                    {
                        result = FCCACMDAccountResourceCategory.GetFacadeCreate().Add(aCMDAccountResourceCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACMDAccountResourceCategoryEntity.FLD_NAME_AccountResourceCategoryID, aCMDAccountResourceCategoryEntity.AccountResourceCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCACMDAccountResourceCategory.GetFacadeCreate().Update(aCMDAccountResourceCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AccountResourceCategoryID = 0;
                        _ACMDAccountResourceCategoryEntity = new ACMDAccountResourceCategoryEntity();
                        PrepareInitialView();
                        BindACMDAccountResourceCategoryList();

                        if (aCMDAccountResourceCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CAccount Resource Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CAccount Resource Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCMDAccountResourceCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CAccount Resource Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CAccount Resource Category Information.", false);
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

        protected void lvACMDAccountResourceCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AccountResourceCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out AccountResourceCategoryID);

            if (AccountResourceCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AccountResourceCategoryID = AccountResourceCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDAccountResourceCategoryEntity.FLD_NAME_AccountResourceCategoryID, AccountResourceCategoryID.ToString(), SQLMatchType.Equal);

                        ACMDAccountResourceCategoryEntity aCMDAccountResourceCategoryEntity = new ACMDAccountResourceCategoryEntity();


                        result = FCCACMDAccountResourceCategory.GetFacadeCreate().Delete(aCMDAccountResourceCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AccountResourceCategoryID = 0;
                            _ACMDAccountResourceCategoryEntity = new ACMDAccountResourceCategoryEntity();
                            PrepareInitialView();
                            BindACMDAccountResourceCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "A CAccount Resource Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CAccount Resource Category.", true);
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

        protected void odsACMDAccountResourceCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACMDAccountResourceCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AccountResourceCategoryID = 0;
            _ACMDAccountResourceCategoryEntity = new ACMDAccountResourceCategoryEntity();
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
