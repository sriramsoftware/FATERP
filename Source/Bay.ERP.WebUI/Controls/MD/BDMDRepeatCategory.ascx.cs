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
    public partial class BDMDRepeatCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _RepeatCategoryID
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

        public BDMDRepeatCategoryEntity _BDMDRepeatCategoryEntity
        {
            get
            {
                BDMDRepeatCategoryEntity entity = new BDMDRepeatCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDMDRepeatCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDMDRepeatCategoryEntity CurrentBDMDRepeatCategoryEntity
        {
            get
            {
                if (_RepeatCategoryID > 0)
                {
                    if (_BDMDRepeatCategoryEntity.RepeatCategoryID != _RepeatCategoryID)
                    {
                        _BDMDRepeatCategoryEntity = FCCBDMDRepeatCategory.GetFacadeCreate().GetByID(_RepeatCategoryID);
                    }
                }

                return _BDMDRepeatCategoryEntity;
            }
            set
            {
                _BDMDRepeatCategoryEntity = value;
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
            BDMDRepeatCategoryEntity bDMDRepeatCategoryEntity = CurrentBDMDRepeatCategoryEntity;


            if (!bDMDRepeatCategoryEntity.IsNew)
            {
                txtName.Text = bDMDRepeatCategoryEntity.Name.ToString();
                txtRemarks.Text = bDMDRepeatCategoryEntity.Remarks.ToString();
                chkIsRemoved.Checked = bDMDRepeatCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDMDRepeatCategoryList();
        }

        private void BindBDMDRepeatCategoryList()
        {
            lvBDMDRepeatCategory.DataBind();
        }

        private BDMDRepeatCategoryEntity BuildBDMDRepeatCategoryEntity()
        {
            BDMDRepeatCategoryEntity bDMDRepeatCategoryEntity = CurrentBDMDRepeatCategoryEntity;

            bDMDRepeatCategoryEntity.Name = txtName.Text.Trim();
            bDMDRepeatCategoryEntity.Remarks = txtRemarks.Text.Trim();
            bDMDRepeatCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return bDMDRepeatCategoryEntity;
        }

        private void SaveBDMDRepeatCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDMDRepeatCategoryEntity bDMDRepeatCategoryEntity = BuildBDMDRepeatCategoryEntity();

                    Int64 result = -1;

                    if (bDMDRepeatCategoryEntity.IsNew)
                    {
                        result = FCCBDMDRepeatCategory.GetFacadeCreate().Add(bDMDRepeatCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDMDRepeatCategoryEntity.FLD_NAME_RepeatCategoryID, bDMDRepeatCategoryEntity.RepeatCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCBDMDRepeatCategory.GetFacadeCreate().Update(bDMDRepeatCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _RepeatCategoryID = 0;
                        _BDMDRepeatCategoryEntity = new BDMDRepeatCategoryEntity();
                        PrepareInitialView();
                        BindBDMDRepeatCategoryList();

                        if (bDMDRepeatCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Repeat Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Repeat Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDMDRepeatCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Repeat Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Repeat Category Information.", false);
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

        protected void lvBDMDRepeatCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 RepeatCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out RepeatCategoryID);

            if (RepeatCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _RepeatCategoryID = RepeatCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDMDRepeatCategoryEntity.FLD_NAME_RepeatCategoryID, RepeatCategoryID.ToString(), SQLMatchType.Equal);

                        BDMDRepeatCategoryEntity bDMDRepeatCategoryEntity = new BDMDRepeatCategoryEntity();


                        result = FCCBDMDRepeatCategory.GetFacadeCreate().Delete(bDMDRepeatCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _RepeatCategoryID = 0;
                            _BDMDRepeatCategoryEntity = new BDMDRepeatCategoryEntity();
                            PrepareInitialView();
                            BindBDMDRepeatCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Repeat Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Repeat Category.", true);
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

        protected void odsBDMDRepeatCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDMDRepeatCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _RepeatCategoryID = 0;
            _BDMDRepeatCategoryEntity = new BDMDRepeatCategoryEntity();
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
