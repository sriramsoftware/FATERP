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
    public partial class CMNFavoriteControl : BaseControl
    {       
        #region Properties

        public Int64 _FavoriteID
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

        public CMNFavoriteEntity _CMNFavoriteEntity
        {
            get
            {
                CMNFavoriteEntity entity = new CMNFavoriteEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNFavoriteEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNFavoriteEntity CurrentCMNFavoriteEntity
        {
            get
            {
                if (_FavoriteID > 0)
                {
                    if (_CMNFavoriteEntity.FavoriteID != _FavoriteID)
                    {
                        _CMNFavoriteEntity = FCCCMNFavorite.GetFacadeCreate().GetByID(_FavoriteID);
                    }
                }

                return _CMNFavoriteEntity;
            }
            set
            {
                _CMNFavoriteEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMNProcessCategory(ddlProcessCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtReferenceID.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMNFavoriteEntity cMNFavoriteEntity = CurrentCMNFavoriteEntity;


            if (!cMNFavoriteEntity.IsNew)
            {
                if (ddlProcessCategoryID.Items.Count > 0 && cMNFavoriteEntity.ProcessCategoryID != null)
                {
                    ddlProcessCategoryID.SelectedValue = cMNFavoriteEntity.ProcessCategoryID.ToString();
                }

                txtReferenceID.Text = cMNFavoriteEntity.ReferenceID.ToString();
                txtRemarks.Text = cMNFavoriteEntity.Remarks.ToString();

                chkIsRemoved.Checked = cMNFavoriteEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNFavoriteList();
        }

        private void BindCMNFavoriteList()
        {
            lvCMNFavorite.DataBind();
        }

        private CMNFavoriteEntity BuildCMNFavoriteEntity()
        {
            CMNFavoriteEntity cMNFavoriteEntity = CurrentCMNFavoriteEntity;

            if (ddlProcessCategoryID.Items.Count > 0)
            {
                if (ddlProcessCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNFavoriteEntity.ProcessCategoryID = Int64.Parse(ddlProcessCategoryID.SelectedValue);
                }
            }

            if (!txtReferenceID.Text.Trim().IsNullOrEmpty())
            {
                cMNFavoriteEntity.ReferenceID = Int64.Parse(txtReferenceID.Text.Trim());
            }

            cMNFavoriteEntity.Remarks = txtRemarks.Text.Trim();
            cMNFavoriteEntity.IsRemoved = chkIsRemoved.Checked;


            return cMNFavoriteEntity;
        }

        private void SaveCMNFavoriteEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNFavoriteEntity cMNFavoriteEntity = BuildCMNFavoriteEntity();

                    Int64 result = -1;

                    if (cMNFavoriteEntity.IsNew)
                    {
                        result = FCCCMNFavorite.GetFacadeCreate().Add(cMNFavoriteEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNFavoriteEntity.FLD_NAME_FavoriteID, cMNFavoriteEntity.FavoriteID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNFavorite.GetFacadeCreate().Update(cMNFavoriteEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _FavoriteID = 0;
                        _CMNFavoriteEntity = new CMNFavoriteEntity();
                        PrepareInitialView();
                        BindCMNFavoriteList();

                        if (cMNFavoriteEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNFavorite Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNFavorite Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNFavoriteEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MNFavorite Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MNFavorite Information.", false);
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

        protected void lvCMNFavorite_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 FavoriteID;

            Int64.TryParse(e.CommandArgument.ToString(), out FavoriteID);

            if (FavoriteID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _FavoriteID = FavoriteID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNFavoriteEntity.FLD_NAME_FavoriteID, FavoriteID.ToString(), SQLMatchType.Equal);

                        CMNFavoriteEntity cMNFavoriteEntity = new CMNFavoriteEntity();


                        result = FCCCMNFavorite.GetFacadeCreate().Delete(cMNFavoriteEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _FavoriteID = 0;
                            _CMNFavoriteEntity = new CMNFavoriteEntity();
                            PrepareInitialView();
                            BindCMNFavoriteList();

                            MiscUtil.ShowMessage(lblMessage, "C MNFavorite has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MNFavorite.", true);
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

        protected void odsCMNFavorite_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNFavoriteEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _FavoriteID = 0;
            _CMNFavoriteEntity = new CMNFavoriteEntity();
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
