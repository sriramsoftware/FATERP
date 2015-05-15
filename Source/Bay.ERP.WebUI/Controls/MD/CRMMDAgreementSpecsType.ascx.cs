// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




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
    public partial class CRMMDAgreementSpecsTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _AgreementSpecsTypeID
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

        public CRMMDAgreementSpecsTypeEntity _CRMMDAgreementSpecsTypeEntity
        {
            get
            {
                CRMMDAgreementSpecsTypeEntity entity = new CRMMDAgreementSpecsTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDAgreementSpecsTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDAgreementSpecsTypeEntity CurrentCRMMDAgreementSpecsTypeEntity
        {
            get
            {
                if (_AgreementSpecsTypeID > 0)
                {
                    if (_CRMMDAgreementSpecsTypeEntity.AgreementSpecsTypeID != _AgreementSpecsTypeID)
                    {
                        _CRMMDAgreementSpecsTypeEntity = FCCCRMMDAgreementSpecsType.GetFacadeCreate().GetByID(_AgreementSpecsTypeID);
                    }
                }

                return _CRMMDAgreementSpecsTypeEntity;
            }
            set
            {
                _CRMMDAgreementSpecsTypeEntity = value;
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
            CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity = CurrentCRMMDAgreementSpecsTypeEntity;


            if (!cRMMDAgreementSpecsTypeEntity.IsNew)
            {
                txtName.Text = cRMMDAgreementSpecsTypeEntity.Name.ToString();
                txtDescription.Text = cRMMDAgreementSpecsTypeEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDAgreementSpecsTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDAgreementSpecsTypeList();
        }

        private void BindCRMMDAgreementSpecsTypeList()
        {
            lvCRMMDAgreementSpecsType.DataBind();
        }

        private CRMMDAgreementSpecsTypeEntity BuildCRMMDAgreementSpecsTypeEntity()
        {
            CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity = CurrentCRMMDAgreementSpecsTypeEntity;

            cRMMDAgreementSpecsTypeEntity.Name = txtName.Text.Trim();
            cRMMDAgreementSpecsTypeEntity.Description = txtDescription.Text.Trim();
            cRMMDAgreementSpecsTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDAgreementSpecsTypeEntity;
        }

        private void SaveCRMMDAgreementSpecsTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity = BuildCRMMDAgreementSpecsTypeEntity();

                    Int64 result = -1;

                    if (cRMMDAgreementSpecsTypeEntity.IsNew)
                    {
                        result = FCCCRMMDAgreementSpecsType.GetFacadeCreate().Add(cRMMDAgreementSpecsTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAgreementSpecsTypeEntity.FLD_NAME_AgreementSpecsTypeID, cRMMDAgreementSpecsTypeEntity.AgreementSpecsTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDAgreementSpecsType.GetFacadeCreate().Update(cRMMDAgreementSpecsTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AgreementSpecsTypeID = 0;
                        _CRMMDAgreementSpecsTypeEntity = new CRMMDAgreementSpecsTypeEntity();
                        PrepareInitialView();
                        BindCRMMDAgreementSpecsTypeList();

                        if (cRMMDAgreementSpecsTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Specs Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Specs Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDAgreementSpecsTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMAgreement Specs Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMAgreement Specs Type Information.", false);
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

        protected void lvCRMMDAgreementSpecsType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AgreementSpecsTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out AgreementSpecsTypeID);

            if (AgreementSpecsTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AgreementSpecsTypeID = AgreementSpecsTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAgreementSpecsTypeEntity.FLD_NAME_AgreementSpecsTypeID, AgreementSpecsTypeID.ToString(), SQLMatchType.Equal);

                        CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity = new CRMMDAgreementSpecsTypeEntity();


                        result = FCCCRMMDAgreementSpecsType.GetFacadeCreate().Delete(cRMMDAgreementSpecsTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AgreementSpecsTypeID = 0;
                            _CRMMDAgreementSpecsTypeEntity = new CRMMDAgreementSpecsTypeEntity();
                            PrepareInitialView();
                            BindCRMMDAgreementSpecsTypeList();

                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Specs Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMAgreement Specs Type.", true);
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

        protected void odsCRMMDAgreementSpecsType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDAgreementSpecsTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AgreementSpecsTypeID = 0;
            _CRMMDAgreementSpecsTypeEntity = new CRMMDAgreementSpecsTypeEntity();
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
