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
    public partial class CRMMDAgreementTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _AgreementTypeID
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

        public CRMMDAgreementTypeEntity _CRMMDAgreementTypeEntity
        {
            get
            {
                CRMMDAgreementTypeEntity entity = new CRMMDAgreementTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDAgreementTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDAgreementTypeEntity CurrentCRMMDAgreementTypeEntity
        {
            get
            {
                if (_AgreementTypeID > 0)
                {
                    if (_CRMMDAgreementTypeEntity.AgreementTypeID != _AgreementTypeID)
                    {
                        _CRMMDAgreementTypeEntity = FCCCRMMDAgreementType.GetFacadeCreate().GetByID(_AgreementTypeID);
                    }
                }

                return _CRMMDAgreementTypeEntity;
            }
            set
            {
                _CRMMDAgreementTypeEntity = value;
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
            CRMMDAgreementTypeEntity cRMMDAgreementTypeEntity = CurrentCRMMDAgreementTypeEntity;


            if (!cRMMDAgreementTypeEntity.IsNew)
            {
                txtName.Text = cRMMDAgreementTypeEntity.Name.ToString();
                txtDescription.Text = cRMMDAgreementTypeEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDAgreementTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDAgreementTypeList();
        }

        private void BindCRMMDAgreementTypeList()
        {
            lvCRMMDAgreementType.DataBind();
        }

        private CRMMDAgreementTypeEntity BuildCRMMDAgreementTypeEntity()
        {
            CRMMDAgreementTypeEntity cRMMDAgreementTypeEntity = CurrentCRMMDAgreementTypeEntity;

            cRMMDAgreementTypeEntity.Name = txtName.Text.Trim();
            cRMMDAgreementTypeEntity.Description = txtDescription.Text.Trim();
            cRMMDAgreementTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDAgreementTypeEntity;
        }

        private void SaveCRMMDAgreementTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDAgreementTypeEntity cRMMDAgreementTypeEntity = BuildCRMMDAgreementTypeEntity();

                    Int64 result = -1;

                    if (cRMMDAgreementTypeEntity.IsNew)
                    {
                        result = FCCCRMMDAgreementType.GetFacadeCreate().Add(cRMMDAgreementTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAgreementTypeEntity.FLD_NAME_AgreementTypeID, cRMMDAgreementTypeEntity.AgreementTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDAgreementType.GetFacadeCreate().Update(cRMMDAgreementTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AgreementTypeID = 0;
                        _CRMMDAgreementTypeEntity = new CRMMDAgreementTypeEntity();
                        PrepareInitialView();
                        BindCRMMDAgreementTypeList();

                        if (cRMMDAgreementTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDAgreementTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMAgreement Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMAgreement Type Information.", false);
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

        protected void lvCRMMDAgreementType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AgreementTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out AgreementTypeID);

            if (AgreementTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AgreementTypeID = AgreementTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAgreementTypeEntity.FLD_NAME_AgreementTypeID, AgreementTypeID.ToString(), SQLMatchType.Equal);

                        CRMMDAgreementTypeEntity cRMMDAgreementTypeEntity = new CRMMDAgreementTypeEntity();


                        result = FCCCRMMDAgreementType.GetFacadeCreate().Delete(cRMMDAgreementTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AgreementTypeID = 0;
                            _CRMMDAgreementTypeEntity = new CRMMDAgreementTypeEntity();
                            PrepareInitialView();
                            BindCRMMDAgreementTypeList();

                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMAgreement Type.", true);
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

        protected void odsCRMMDAgreementType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDAgreementTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AgreementTypeID = 0;
            _CRMMDAgreementTypeEntity = new CRMMDAgreementTypeEntity();
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
