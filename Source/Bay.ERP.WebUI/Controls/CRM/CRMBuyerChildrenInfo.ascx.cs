// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2013, 05:23:07




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
    public partial class CRMBuyerChildrenInfoControl : BaseControl
    {       
        #region Properties

        public Int64 _BuyerChildrenInfoID
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

        public CRMBuyerChildrenInfoEntity _CRMBuyerChildrenInfoEntity
        {
            get
            {
                CRMBuyerChildrenInfoEntity entity = new CRMBuyerChildrenInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMBuyerChildrenInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMBuyerChildrenInfoEntity CurrentCRMBuyerChildrenInfoEntity
        {
            get
            {
                if (_BuyerChildrenInfoID > 0)
                {
                    if (_CRMBuyerChildrenInfoEntity.BuyerChildrenInfoID != _BuyerChildrenInfoID)
                    {
                        _CRMBuyerChildrenInfoEntity = FCCCRMBuyerChildrenInfo.GetFacadeCreate().GetByID(_BuyerChildrenInfoID);
                    }
                }

                return _CRMBuyerChildrenInfoEntity;
            }
            set
            {
                _CRMBuyerChildrenInfoEntity = value;
            }
        }

        public Int64 CRMBuyerBasicInfoID
        {
            get
            {
                Int64 cRMBuyerBasicInfoID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BUYER_BASIC_INFO_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BUYER_BASIC_INFO_ID], out cRMBuyerBasicInfoID);
                }

                return cRMBuyerBasicInfoID;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        { 
            MiscUtil.PopulateMDGender(ddlGenderID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtDOB.Text = String.Empty;
            txtEditionalInstituteName.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity = CurrentCRMBuyerChildrenInfoEntity;


            if (!cRMBuyerChildrenInfoEntity.IsNew)
            {
                txtName.Text = cRMBuyerChildrenInfoEntity.Name.ToString();
                txtDOB.Text = cRMBuyerChildrenInfoEntity.DOB.ToStringDefault();
                if (ddlGenderID.Items.Count > 0 && cRMBuyerChildrenInfoEntity.GenderID != null)
                {
                    ddlGenderID.SelectedValue = cRMBuyerChildrenInfoEntity.GenderID.ToString();
                }

                txtEditionalInstituteName.Text = cRMBuyerChildrenInfoEntity.EditionalInstituteName.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMBuyerChildrenInfoList();
        }

        private void BindCRMBuyerChildrenInfoList()
        {
            lvCRMBuyerChildrenInfo.DataBind();
        }

        private CRMBuyerChildrenInfoEntity BuildCRMBuyerChildrenInfoEntity()
        {
            CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity = CurrentCRMBuyerChildrenInfoEntity;

            cRMBuyerChildrenInfoEntity.BuyerBasicInfoID = CRMBuyerBasicInfoID;
            cRMBuyerChildrenInfoEntity.Name = txtName.Text.Trim();
            if (txtDOB.Text.Trim().IsNotNullOrEmpty())
            {
                cRMBuyerChildrenInfoEntity.DOB = MiscUtil.ParseToDateTime(txtDOB.Text);
            }
            else
            {
                cRMBuyerChildrenInfoEntity.DOB = null;
            }

            if (ddlGenderID.Items.Count > 0)
            {
                if (ddlGenderID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMBuyerChildrenInfoEntity.GenderID = Int64.Parse(ddlGenderID.SelectedValue);
                }
            }

            cRMBuyerChildrenInfoEntity.EditionalInstituteName = txtEditionalInstituteName.Text.Trim();

            return cRMBuyerChildrenInfoEntity;
        }

        private void SaveCRMBuyerChildrenInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity = BuildCRMBuyerChildrenInfoEntity();

                    Int64 result = -1;

                    if (cRMBuyerChildrenInfoEntity.IsNew)
                    {
                        result = FCCCRMBuyerChildrenInfo.GetFacadeCreate().Add(cRMBuyerChildrenInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerChildrenInfoEntity.FLD_NAME_BuyerChildrenInfoID, cRMBuyerChildrenInfoEntity.BuyerChildrenInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMBuyerChildrenInfo.GetFacadeCreate().Update(cRMBuyerChildrenInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BuyerChildrenInfoID = 0;
                        _CRMBuyerChildrenInfoEntity = new CRMBuyerChildrenInfoEntity();
                        PrepareInitialView();
                        BindCRMBuyerChildrenInfoList();

                        if (cRMBuyerChildrenInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Buyer Children Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Buyer Children Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMBuyerChildrenInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Buyer Children Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Buyer Children Info Information.", false);
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

        protected void lvCRMBuyerChildrenInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BuyerChildrenInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out BuyerChildrenInfoID);

            if (BuyerChildrenInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BuyerChildrenInfoID = BuyerChildrenInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerChildrenInfoEntity.FLD_NAME_BuyerChildrenInfoID, BuyerChildrenInfoID.ToString(), SQLMatchType.Equal);

                        CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity = new CRMBuyerChildrenInfoEntity();


                        result = FCCCRMBuyerChildrenInfo.GetFacadeCreate().Delete(cRMBuyerChildrenInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BuyerChildrenInfoID = 0;
                            _CRMBuyerChildrenInfoEntity = new CRMBuyerChildrenInfoEntity();
                            PrepareInitialView();
                            BindCRMBuyerChildrenInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Buyer Children Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Buyer Children Info.", true);
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

        protected void odsCRMBuyerChildrenInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerChildrenInfoEntity.FLD_NAME_BuyerBasicInfoID, CRMBuyerBasicInfoID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMBuyerChildrenInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BuyerChildrenInfoID = 0;
            _CRMBuyerChildrenInfoEntity = new CRMBuyerChildrenInfoEntity();
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
