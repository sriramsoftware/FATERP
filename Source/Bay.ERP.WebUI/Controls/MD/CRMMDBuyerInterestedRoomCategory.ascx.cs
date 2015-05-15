// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public partial class CRMMDBuyerInterestedRoomCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _BuyerInterestedRoomCategoryID
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

        public CRMMDBuyerInterestedRoomCategoryEntity _CRMMDBuyerInterestedRoomCategoryEntity
        {
            get
            {
                CRMMDBuyerInterestedRoomCategoryEntity entity = new CRMMDBuyerInterestedRoomCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDBuyerInterestedRoomCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDBuyerInterestedRoomCategoryEntity CurrentCRMMDBuyerInterestedRoomCategoryEntity
        {
            get
            {
                if (_BuyerInterestedRoomCategoryID > 0)
                {
                    if (_CRMMDBuyerInterestedRoomCategoryEntity.BuyerInterestedRoomCategoryID != _BuyerInterestedRoomCategoryID)
                    {
                        _CRMMDBuyerInterestedRoomCategoryEntity = FCCCRMMDBuyerInterestedRoomCategory.GetFacadeCreate().GetByID(_BuyerInterestedRoomCategoryID);
                    }
                }

                return _CRMMDBuyerInterestedRoomCategoryEntity;
            }
            set
            {
                _CRMMDBuyerInterestedRoomCategoryEntity = value;
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
            CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity = CurrentCRMMDBuyerInterestedRoomCategoryEntity;


            if (!cRMMDBuyerInterestedRoomCategoryEntity.IsNew)
            {
                txtName.Text = cRMMDBuyerInterestedRoomCategoryEntity.Name.ToString();
                txtDescription.Text = cRMMDBuyerInterestedRoomCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDBuyerInterestedRoomCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDBuyerInterestedRoomCategoryList();
        }

        private void BindCRMMDBuyerInterestedRoomCategoryList()
        {
            lvCRMMDBuyerInterestedRoomCategory.DataBind();
        }

        private CRMMDBuyerInterestedRoomCategoryEntity BuildCRMMDBuyerInterestedRoomCategoryEntity()
        {
            CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity = CurrentCRMMDBuyerInterestedRoomCategoryEntity;

            cRMMDBuyerInterestedRoomCategoryEntity.Name = txtName.Text.Trim();
            cRMMDBuyerInterestedRoomCategoryEntity.Description = txtDescription.Text.Trim();
            cRMMDBuyerInterestedRoomCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDBuyerInterestedRoomCategoryEntity;
        }

        private void SaveCRMMDBuyerInterestedRoomCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity = BuildCRMMDBuyerInterestedRoomCategoryEntity();

                    Int64 result = -1;

                    if (cRMMDBuyerInterestedRoomCategoryEntity.IsNew)
                    {
                        result = FCCCRMMDBuyerInterestedRoomCategory.GetFacadeCreate().Add(cRMMDBuyerInterestedRoomCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDBuyerInterestedRoomCategoryEntity.FLD_NAME_BuyerInterestedRoomCategoryID, cRMMDBuyerInterestedRoomCategoryEntity.BuyerInterestedRoomCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDBuyerInterestedRoomCategory.GetFacadeCreate().Update(cRMMDBuyerInterestedRoomCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BuyerInterestedRoomCategoryID = 0;
                        _CRMMDBuyerInterestedRoomCategoryEntity = new CRMMDBuyerInterestedRoomCategoryEntity();
                        PrepareInitialView();
                        BindCRMMDBuyerInterestedRoomCategoryList();

                        if (cRMMDBuyerInterestedRoomCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMBuyer Interested Room Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMBuyer Interested Room Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDBuyerInterestedRoomCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMBuyer Interested Room Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMBuyer Interested Room Category Information.", false);
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

        protected void lvCRMMDBuyerInterestedRoomCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BuyerInterestedRoomCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out BuyerInterestedRoomCategoryID);

            if (BuyerInterestedRoomCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BuyerInterestedRoomCategoryID = BuyerInterestedRoomCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDBuyerInterestedRoomCategoryEntity.FLD_NAME_BuyerInterestedRoomCategoryID, BuyerInterestedRoomCategoryID.ToString(), SQLMatchType.Equal);

                        CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity = new CRMMDBuyerInterestedRoomCategoryEntity();


                        result = FCCCRMMDBuyerInterestedRoomCategory.GetFacadeCreate().Delete(cRMMDBuyerInterestedRoomCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BuyerInterestedRoomCategoryID = 0;
                            _CRMMDBuyerInterestedRoomCategoryEntity = new CRMMDBuyerInterestedRoomCategoryEntity();
                            PrepareInitialView();
                            BindCRMMDBuyerInterestedRoomCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "C RMBuyer Interested Room Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMBuyer Interested Room Category.", true);
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

        protected void odsCRMMDBuyerInterestedRoomCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDBuyerInterestedRoomCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BuyerInterestedRoomCategoryID = 0;
            _CRMMDBuyerInterestedRoomCategoryEntity = new CRMMDBuyerInterestedRoomCategoryEntity();
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
