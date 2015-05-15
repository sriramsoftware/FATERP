// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




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
    public partial class CMNProcessCategoryControl : BaseControl
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

        public CMNProcessCategoryEntity _CMNProcessCategoryEntity
        {
            get
            {
                CMNProcessCategoryEntity entity = new CMNProcessCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNProcessCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNProcessCategoryEntity CurrentCMNProcessCategoryEntity
        {
            get
            {
                if (_ProcessCategoryID > 0)
                {
                    if (_CMNProcessCategoryEntity.ProcessCategoryID != _ProcessCategoryID)
                    {
                        _CMNProcessCategoryEntity = FCCCMNProcessCategory.GetFacadeCreate().GetByID(_ProcessCategoryID);
                    }
                }

                return _CMNProcessCategoryEntity;
            }
            set
            {
                _CMNProcessCategoryEntity = value;
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
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMNProcessCategoryEntity cMNProcessCategoryEntity = CurrentCMNProcessCategoryEntity;


            if (!cMNProcessCategoryEntity.IsNew)
            {
                txtName.Text = cMNProcessCategoryEntity.Name.ToString();
                txtRemarks.Text = cMNProcessCategoryEntity.Remarks.ToString();
                chkIsRemoved.Checked = cMNProcessCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNProcessCategoryList();
        }

        private void BindCMNProcessCategoryList()
        {
            lvCMNProcessCategory.DataBind();
        }

        private CMNProcessCategoryEntity BuildCMNProcessCategoryEntity()
        {
            CMNProcessCategoryEntity cMNProcessCategoryEntity = CurrentCMNProcessCategoryEntity;

            cMNProcessCategoryEntity.Name = txtName.Text.Trim();
            cMNProcessCategoryEntity.Remarks = txtRemarks.Text.Trim();
            cMNProcessCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return cMNProcessCategoryEntity;
        }

        private void SaveCMNProcessCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNProcessCategoryEntity cMNProcessCategoryEntity = BuildCMNProcessCategoryEntity();

                    Int64 result = -1;

                    if (cMNProcessCategoryEntity.IsNew)
                    {
                        result = FCCCMNProcessCategory.GetFacadeCreate().Add(cMNProcessCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNProcessCategoryEntity.FLD_NAME_ProcessCategoryID, cMNProcessCategoryEntity.ProcessCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNProcessCategory.GetFacadeCreate().Update(cMNProcessCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProcessCategoryID = 0;
                        _CMNProcessCategoryEntity = new CMNProcessCategoryEntity();
                        PrepareInitialView();
                        BindCMNProcessCategoryList();

                        if (cMNProcessCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNProcess Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNProcess Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNProcessCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MNProcess Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MNProcess Category Information.", false);
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

        protected void lvCMNProcessCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProcessCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProcessCategoryID);

            if (ProcessCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProcessCategoryID = ProcessCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNProcessCategoryEntity.FLD_NAME_ProcessCategoryID, ProcessCategoryID.ToString(), SQLMatchType.Equal);

                        CMNProcessCategoryEntity cMNProcessCategoryEntity = new CMNProcessCategoryEntity();


                        result = FCCCMNProcessCategory.GetFacadeCreate().Delete(cMNProcessCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProcessCategoryID = 0;
                            _CMNProcessCategoryEntity = new CMNProcessCategoryEntity();
                            PrepareInitialView();
                            BindCMNProcessCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "C MNProcess Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MNProcess Category.", true);
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

        protected void odsCMNProcessCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNProcessCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProcessCategoryID = 0;
            _CMNProcessCategoryEntity = new CMNProcessCategoryEntity();
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
