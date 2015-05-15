// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




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
    public partial class CMMDBillFloorDetailCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _BillFloorDetailCategoryID
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

        public CMMDBillFloorDetailCategoryEntity _CMMDBillFloorDetailCategoryEntity
        {
            get
            {
                CMMDBillFloorDetailCategoryEntity entity = new CMMDBillFloorDetailCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMMDBillFloorDetailCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMMDBillFloorDetailCategoryEntity CurrentCMMDBillFloorDetailCategoryEntity
        {
            get
            {
                if (_BillFloorDetailCategoryID > 0)
                {
                    if (_CMMDBillFloorDetailCategoryEntity.BillFloorDetailCategoryID != _BillFloorDetailCategoryID)
                    {
                        _CMMDBillFloorDetailCategoryEntity = FCCCMMDBillFloorDetailCategory.GetFacadeCreate().GetByID(_BillFloorDetailCategoryID);
                    }
                }

                return _CMMDBillFloorDetailCategoryEntity;
            }
            set
            {
                _CMMDBillFloorDetailCategoryEntity = value;
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
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMMDBillFloorDetailCategoryEntity cMMDBillFloorDetailCategoryEntity = CurrentCMMDBillFloorDetailCategoryEntity;


            if (!cMMDBillFloorDetailCategoryEntity.IsNew)
            {
                txtName.Text = cMMDBillFloorDetailCategoryEntity.Name.ToString();
                chkIsRemoved.Checked = cMMDBillFloorDetailCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMMDBillFloorDetailCategoryList();
        }

        private void BindCMMDBillFloorDetailCategoryList()
        {
            lvCMMDBillFloorDetailCategory.DataBind();
        }

        private CMMDBillFloorDetailCategoryEntity BuildCMMDBillFloorDetailCategoryEntity()
        {
            CMMDBillFloorDetailCategoryEntity cMMDBillFloorDetailCategoryEntity = CurrentCMMDBillFloorDetailCategoryEntity;

            cMMDBillFloorDetailCategoryEntity.Name = txtName.Text.Trim();
            cMMDBillFloorDetailCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return cMMDBillFloorDetailCategoryEntity;
        }

        private void SaveCMMDBillFloorDetailCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMMDBillFloorDetailCategoryEntity cMMDBillFloorDetailCategoryEntity = BuildCMMDBillFloorDetailCategoryEntity();

                    Int64 result = -1;

                    if (cMMDBillFloorDetailCategoryEntity.IsNew)
                    {
                        result = FCCCMMDBillFloorDetailCategory.GetFacadeCreate().Add(cMMDBillFloorDetailCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMMDBillFloorDetailCategoryEntity.FLD_NAME_BillFloorDetailCategoryID, cMMDBillFloorDetailCategoryEntity.BillFloorDetailCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCCMMDBillFloorDetailCategory.GetFacadeCreate().Update(cMMDBillFloorDetailCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BillFloorDetailCategoryID = 0;
                        _CMMDBillFloorDetailCategoryEntity = new CMMDBillFloorDetailCategoryEntity();
                        PrepareInitialView();
                        BindCMMDBillFloorDetailCategoryList();

                        if (cMMDBillFloorDetailCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MBill Floor Detail Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MBill Floor Detail Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMMDBillFloorDetailCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MBill Floor Detail Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MBill Floor Detail Category Information.", false);
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

        protected void lvCMMDBillFloorDetailCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BillFloorDetailCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out BillFloorDetailCategoryID);

            if (BillFloorDetailCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BillFloorDetailCategoryID = BillFloorDetailCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMMDBillFloorDetailCategoryEntity.FLD_NAME_BillFloorDetailCategoryID, BillFloorDetailCategoryID.ToString(), SQLMatchType.Equal);

                        CMMDBillFloorDetailCategoryEntity cMMDBillFloorDetailCategoryEntity = new CMMDBillFloorDetailCategoryEntity();


                        result = FCCCMMDBillFloorDetailCategory.GetFacadeCreate().Delete(cMMDBillFloorDetailCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BillFloorDetailCategoryID = 0;
                            _CMMDBillFloorDetailCategoryEntity = new CMMDBillFloorDetailCategoryEntity();
                            PrepareInitialView();
                            BindCMMDBillFloorDetailCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "C MBill Floor Detail Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MBill Floor Detail Category.", true);
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

        protected void odsCMMDBillFloorDetailCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMMDBillFloorDetailCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BillFloorDetailCategoryID = 0;
            _CMMDBillFloorDetailCategoryEntity = new CMMDBillFloorDetailCategoryEntity();
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
