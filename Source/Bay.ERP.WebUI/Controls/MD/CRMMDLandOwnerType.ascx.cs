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
    public partial class CRMMDLandOwnerTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _LandOwnerTypeID
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

        public CRMMDLandOwnerTypeEntity _CRMMDLandOwnerTypeEntity
        {
            get
            {
                CRMMDLandOwnerTypeEntity entity = new CRMMDLandOwnerTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDLandOwnerTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDLandOwnerTypeEntity CurrentCRMMDLandOwnerTypeEntity
        {
            get
            {
                if (_LandOwnerTypeID > 0)
                {
                    if (_CRMMDLandOwnerTypeEntity.LandOwnerTypeID != _LandOwnerTypeID)
                    {
                        _CRMMDLandOwnerTypeEntity = FCCCRMMDLandOwnerType.GetFacadeCreate().GetByID(_LandOwnerTypeID);
                    }
                }

                return _CRMMDLandOwnerTypeEntity;
            }
            set
            {
                _CRMMDLandOwnerTypeEntity = value;
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
            CRMMDLandOwnerTypeEntity cRMMDLandOwnerTypeEntity = CurrentCRMMDLandOwnerTypeEntity;


            if (!cRMMDLandOwnerTypeEntity.IsNew)
            {
                txtName.Text = cRMMDLandOwnerTypeEntity.Name.ToString();
                txtDescription.Text = cRMMDLandOwnerTypeEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDLandOwnerTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDLandOwnerTypeList();
        }

        private void BindCRMMDLandOwnerTypeList()
        {
            lvCRMMDLandOwnerType.DataBind();
        }

        private CRMMDLandOwnerTypeEntity BuildCRMMDLandOwnerTypeEntity()
        {
            CRMMDLandOwnerTypeEntity cRMMDLandOwnerTypeEntity = CurrentCRMMDLandOwnerTypeEntity;

            cRMMDLandOwnerTypeEntity.Name = txtName.Text.Trim();
            cRMMDLandOwnerTypeEntity.Description = txtDescription.Text.Trim();
            cRMMDLandOwnerTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDLandOwnerTypeEntity;
        }

        private void SaveCRMMDLandOwnerTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDLandOwnerTypeEntity cRMMDLandOwnerTypeEntity = BuildCRMMDLandOwnerTypeEntity();

                    Int64 result = -1;

                    if (cRMMDLandOwnerTypeEntity.IsNew)
                    {
                        result = FCCCRMMDLandOwnerType.GetFacadeCreate().Add(cRMMDLandOwnerTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDLandOwnerTypeEntity.FLD_NAME_LandOwnerTypeID, cRMMDLandOwnerTypeEntity.LandOwnerTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDLandOwnerType.GetFacadeCreate().Update(cRMMDLandOwnerTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _LandOwnerTypeID = 0;
                        _CRMMDLandOwnerTypeEntity = new CRMMDLandOwnerTypeEntity();
                        PrepareInitialView();
                        BindCRMMDLandOwnerTypeList();

                        if (cRMMDLandOwnerTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMLandowner Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMLandowner Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDLandOwnerTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMLandowner Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMLandowner Type Information.", false);
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

        protected void lvCRMMDLandOwnerType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 LandOwnerTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out LandOwnerTypeID);

            if (LandOwnerTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _LandOwnerTypeID = LandOwnerTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDLandOwnerTypeEntity.FLD_NAME_LandOwnerTypeID, LandOwnerTypeID.ToString(), SQLMatchType.Equal);

                        CRMMDLandOwnerTypeEntity cRMMDLandOwnerTypeEntity = new CRMMDLandOwnerTypeEntity();


                        result = FCCCRMMDLandOwnerType.GetFacadeCreate().Delete(cRMMDLandOwnerTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _LandOwnerTypeID = 0;
                            _CRMMDLandOwnerTypeEntity = new CRMMDLandOwnerTypeEntity();
                            PrepareInitialView();
                            BindCRMMDLandOwnerTypeList();

                            MiscUtil.ShowMessage(lblMessage, "C RMLandowner Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMLandowner Type.", true);
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

        protected void odsCRMMDLandOwnerType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDLandOwnerTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _LandOwnerTypeID = 0;
            _CRMMDLandOwnerTypeEntity = new CRMMDLandOwnerTypeEntity();
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
