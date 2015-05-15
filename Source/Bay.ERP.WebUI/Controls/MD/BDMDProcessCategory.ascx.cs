// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




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
    public partial class BDMDProcessCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _ProcessCategoryID
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

        public BDMDProcessCategoryEntity _BDMDProcessCategoryEntity
        {
            get
            {
                BDMDProcessCategoryEntity entity = new BDMDProcessCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDMDProcessCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDMDProcessCategoryEntity CurrentBDMDProcessCategoryEntity
        {
            get
            {
                if (_ProcessCategoryID > 0)
                {
                    if (_BDMDProcessCategoryEntity.ProcessCategoryID != _ProcessCategoryID)
                    {
                        _BDMDProcessCategoryEntity = FCCBDMDProcessCategory.GetFacadeCreate().GetByID(_ProcessCategoryID);
                    }
                }

                return _BDMDProcessCategoryEntity;
            }
            set
            {
                _BDMDProcessCategoryEntity = value;
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
            BDMDProcessCategoryEntity bDMDProcessCategoryEntity = CurrentBDMDProcessCategoryEntity;


            if (!bDMDProcessCategoryEntity.IsNew)
            {
                txtName.Text = bDMDProcessCategoryEntity.Name.ToString();
                txtDescription.Text = bDMDProcessCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = bDMDProcessCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDMDProcessCategoryList();
        }

        private void BindBDMDProcessCategoryList()
        {
            lvBDMDProcessCategory.DataBind();
        }

        private BDMDProcessCategoryEntity BuildBDMDProcessCategoryEntity()
        {
            BDMDProcessCategoryEntity bDMDProcessCategoryEntity = CurrentBDMDProcessCategoryEntity;

            bDMDProcessCategoryEntity.Name = txtName.Text.Trim();
            bDMDProcessCategoryEntity.Description = txtDescription.Text.Trim();
            bDMDProcessCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return bDMDProcessCategoryEntity;
        }

        private void SaveBDMDProcessCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDMDProcessCategoryEntity bDMDProcessCategoryEntity = BuildBDMDProcessCategoryEntity();

                    Int64 result = -1;

                    if (bDMDProcessCategoryEntity.IsNew)
                    {
                        result = FCCBDMDProcessCategory.GetFacadeCreate().Add(bDMDProcessCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDMDProcessCategoryEntity.FLD_NAME_ProcessCategoryID, bDMDProcessCategoryEntity.ProcessCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCBDMDProcessCategory.GetFacadeCreate().Update(bDMDProcessCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProcessCategoryID = 0;
                        _BDMDProcessCategoryEntity = new BDMDProcessCategoryEntity();
                        PrepareInitialView();
                        BindBDMDProcessCategoryList();

                        if (bDMDProcessCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Process Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Process Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDMDProcessCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Process Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Process Category Information.", false);
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

        protected void lvBDMDProcessCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProcessCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProcessCategoryID);

            if (ProcessCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProcessCategoryID = ProcessCategoryID;

                    PrepareEditView();
                }

                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDMDProcessCategoryEntity.FLD_NAME_ProcessCategoryID, ProcessCategoryID.ToString(), SQLMatchType.Equal);

                        BDMDProcessCategoryEntity bDMDProcessCategoryEntity = new BDMDProcessCategoryEntity();

                        result = FCCBDMDProcessCategory.GetFacadeCreate().Delete(bDMDProcessCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProcessCategoryID = 0;
                            _BDMDProcessCategoryEntity = new BDMDProcessCategoryEntity();
                            PrepareInitialView();
                            BindBDMDProcessCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Process Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Process Category.", true);
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

        protected void odsBDMDProcessCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDMDProcessCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProcessCategoryID = 0;
            _BDMDProcessCategoryEntity = new BDMDProcessCategoryEntity();
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
