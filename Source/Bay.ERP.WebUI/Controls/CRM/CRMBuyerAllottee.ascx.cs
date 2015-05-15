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
using System.IO;

namespace Bay.ERP.Web.UI
{
    public partial class CRMBuyerAllotteeControl : BaseControl
    {       
        #region Properties

        public Int64 _BuyerAllotteeID
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

        public CRMBuyerAllotteeEntity _CRMBuyerAllotteeEntity
        {
            get
            {
                CRMBuyerAllotteeEntity entity = new CRMBuyerAllotteeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMBuyerAllotteeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMBuyerAllotteeEntity CurrentCRMBuyerAllotteeEntity
        {
            get
            {
                if (_BuyerAllotteeID > 0)
                {
                    if (_CRMBuyerAllotteeEntity.BuyerAllotteeID != _BuyerAllotteeID)
                    {
                        _CRMBuyerAllotteeEntity = FCCCRMBuyerAllottee.GetFacadeCreate().GetByID(_BuyerAllotteeID);
                    }
                }

                return _CRMBuyerAllotteeEntity;
            }
            set
            {
                _CRMBuyerAllotteeEntity = value;
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
           
        }

        private void PrepareValidator()
        {
            revLandPhone.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtLandPhone.MaxLength = ValidationConstants.FieldLength.Phone;
            revLandPhone.ErrorMessage = ValidationConstants.ErrorMessage.Phone;

            revEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;

        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtOwnerFullName.Text = String.Empty;
            txtOwnPercentage.Text = String.Empty;
            txtMobileNo.Text = String.Empty;
            txtLandPhone.Text = String.Empty;
            txtPresentAddress.Text = String.Empty;
            txtFatherName.Text = String.Empty;
            txtMotherName.Text = String.Empty;
            txtSpouseName.Text = String.Empty;
            txtTINNumber.Text = String.Empty;
            txtDateOfBirth.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtBusinessDetails.Text = String.Empty;

            btnSubmit.Text = "Add Buyer";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMBuyerAllotteeEntity cRMBuyerAllotteeEntity = CurrentCRMBuyerAllotteeEntity;


            if (!cRMBuyerAllotteeEntity.IsNew)
            {
                txtOwnerFullName.Text = cRMBuyerAllotteeEntity.OwnerFullName.ToString();
                txtOwnPercentage.Text = cRMBuyerAllotteeEntity.OwnPercentage.ToString();
                txtMobileNo.Text = cRMBuyerAllotteeEntity.MobileNo.ToString();
                txtLandPhone.Text = cRMBuyerAllotteeEntity.LandPhone.ToString();
                txtPresentAddress.Text = cRMBuyerAllotteeEntity.PresentAddress.ToString();
                txtFatherName.Text = cRMBuyerAllotteeEntity.FatherName.ToString();
                txtMotherName.Text = cRMBuyerAllotteeEntity.MotherName.ToString();
                txtSpouseName.Text = cRMBuyerAllotteeEntity.SpouseName.ToString();
                txtTINNumber.Text = cRMBuyerAllotteeEntity.TINNumber.ToString();
                txtDateOfBirth.Text = cRMBuyerAllotteeEntity.DateOfBirth.ToStringDefault();
                txtEmail.Text = cRMBuyerAllotteeEntity.Email.ToString();
                txtBusinessDetails.Text = cRMBuyerAllotteeEntity.BusinessDetails.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMBuyerAllotteeList();
        }

        private void BindCRMBuyerAllotteeList()
        {
            lvCRMBuyerAllottee.DataBind();
        }

        private CRMBuyerAllotteeEntity BuildCRMBuyerAllotteeEntity()
        {
            CRMBuyerAllotteeEntity cRMBuyerAllotteeEntity = CurrentCRMBuyerAllotteeEntity;
            cRMBuyerAllotteeEntity.BuyerBasicInfoID = CRMBuyerBasicInfoID;
           
            cRMBuyerAllotteeEntity.OwnerFullName = txtOwnerFullName.Text.Trim();

            String ImageUrlpath;

            if (fuImageUrl.HasFile == true && cRMBuyerAllotteeEntity.ImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(cRMBuyerAllotteeEntity.ImageUrl)))
                {
                    File.Delete(Server.MapPath(cRMBuyerAllotteeEntity.ImageUrl));
                }
                ImageUrlpath = FileUploadConstants.CRM.Buyer + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(ImageUrlpath));
                cRMBuyerAllotteeEntity.ImageUrl = ImageUrlpath;
            }

            if (cRMBuyerAllotteeEntity.ImageUrl.IsNotNullOrEmpty() && fuImageUrl.HasFile == false)
            {
                cRMBuyerAllotteeEntity.ImageUrl = cRMBuyerAllotteeEntity.ImageUrl;
            }

            if (fuImageUrl.HasFile == false && cRMBuyerAllotteeEntity.ImageUrl.IsNullOrEmpty())
            {
                cRMBuyerAllotteeEntity.ImageUrl = null;
            }

            if (fuImageUrl.HasFile == true && cRMBuyerAllotteeEntity.ImageUrl.IsNullOrEmpty())
            {
                ImageUrlpath = FileUploadConstants.CRM.Buyer + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(ImageUrlpath));
                cRMBuyerAllotteeEntity.ImageUrl = ImageUrlpath;
            }

            if (!txtOwnPercentage.Text.Trim().IsNullOrEmpty())
            {
                cRMBuyerAllotteeEntity.OwnPercentage = Decimal.Parse(txtOwnPercentage.Text.Trim());
            }
            else
            {
                cRMBuyerAllotteeEntity.OwnPercentage = null;
            }

            cRMBuyerAllotteeEntity.MobileNo = txtMobileNo.Text.Trim();
            cRMBuyerAllotteeEntity.LandPhone = txtLandPhone.Text.Trim();
            cRMBuyerAllotteeEntity.PresentAddress = txtPresentAddress.Text.Trim();
            cRMBuyerAllotteeEntity.FatherName = txtFatherName.Text.Trim();
            cRMBuyerAllotteeEntity.MotherName = txtMotherName.Text.Trim();
            cRMBuyerAllotteeEntity.SpouseName = txtSpouseName.Text.Trim();
            cRMBuyerAllotteeEntity.TINNumber = txtTINNumber.Text.Trim();
            if (txtDateOfBirth.Text.Trim().IsNotNullOrEmpty())
            {
                cRMBuyerAllotteeEntity.DateOfBirth = MiscUtil.ParseToDateTime(txtDateOfBirth.Text);
            }
            else
            {
                cRMBuyerAllotteeEntity.DateOfBirth = null;
            }

            cRMBuyerAllotteeEntity.Email = txtEmail.Text.Trim();
            cRMBuyerAllotteeEntity.BusinessDetails = txtBusinessDetails.Text.Trim();

            return cRMBuyerAllotteeEntity;
        }

        private void SaveCRMBuyerAllotteeEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMBuyerAllotteeEntity cRMBuyerAllotteeEntity = BuildCRMBuyerAllotteeEntity();

                    Int64 result = -1;

                    if (cRMBuyerAllotteeEntity.IsNew)
                    {
                        result = FCCCRMBuyerAllottee.GetFacadeCreate().Add(cRMBuyerAllotteeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerAllotteeEntity.FLD_NAME_BuyerAllotteeID, cRMBuyerAllotteeEntity.BuyerAllotteeID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMBuyerAllottee.GetFacadeCreate().Update(cRMBuyerAllotteeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BuyerAllotteeID = 0;
                        _CRMBuyerAllotteeEntity = new CRMBuyerAllotteeEntity();
                        PrepareInitialView();
                        BindCRMBuyerAllotteeList();

                        if (cRMBuyerAllotteeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Buyer Allottee Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Buyer Allottee Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMBuyerAllotteeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Buyer Allottee Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Buyer Allottee Information.", false);
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

        protected void lvCRMBuyerAllottee_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BuyerAllotteeID;

            Int64.TryParse(e.CommandArgument.ToString(), out BuyerAllotteeID);

            if (BuyerAllotteeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BuyerAllotteeID = BuyerAllotteeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerAllotteeEntity.FLD_NAME_BuyerAllotteeID, BuyerAllotteeID.ToString(), SQLMatchType.Equal);

                        CRMBuyerAllotteeEntity cRMBuyerAllotteeEntity = new CRMBuyerAllotteeEntity();


                        result = FCCCRMBuyerAllottee.GetFacadeCreate().Delete(cRMBuyerAllotteeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BuyerAllotteeID = 0;
                            _CRMBuyerAllotteeEntity = new CRMBuyerAllotteeEntity();
                            PrepareInitialView();
                            BindCRMBuyerAllotteeList();

                            MiscUtil.ShowMessage(lblMessage, "C RMBuyer Allottee has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMBuyer Allottee.", true);
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

        protected void odsCRMBuyerAllottee_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerAllotteeEntity.FLD_NAME_BuyerBasicInfoID, CRMBuyerBasicInfoID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMBuyerAllotteeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BuyerAllotteeID = 0;
            _CRMBuyerAllotteeEntity = new CRMBuyerAllotteeEntity();
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
