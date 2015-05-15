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
    public partial class CRMLandOwnerControl : BaseControl
    {       
        #region Properties

        public Int64 _LandOwnerID
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

        public CRMLandOwnerEntity _CRMLandOwnerEntity
        {
            get
            {
                CRMLandOwnerEntity entity = new CRMLandOwnerEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMLandOwnerEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMLandOwnerEntity CurrentCRMLandOwnerEntity
        {
            get
            {
                if (_LandOwnerID > 0)
                {
                    if (_CRMLandOwnerEntity.LandOwnerID != _LandOwnerID)
                    {
                        _CRMLandOwnerEntity = FCCCRMLandOwner.GetFacadeCreate().GetByID(_LandOwnerID);
                    }
                }

                return _CRMLandOwnerEntity;
            }
            set
            {
                _CRMLandOwnerEntity = value;
            }
        }

        public Int64 CRMLandBasicInfoID
        {
            get
            {
                Int64 cRMLandBasicInfoID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID], out cRMLandBasicInfoID);
                }

                return cRMLandBasicInfoID;
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

            txtOwnerName.Text = String.Empty;
            txtOwnPercentage.Text = String.Empty;
            txtMobileNo.Text = String.Empty;
            txtLandPhone.Text = String.Empty;
            txtPresentAddress.Text = String.Empty;
            txtFatherName.Text = String.Empty;
            txtMotherName.Text = String.Empty;
            txtSpouseName.Text = String.Empty;
            txtDateOfBirth.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtBusinessDetails.Text = String.Empty;

            btnSubmit.Text = "Add More Owner";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMLandOwnerEntity cRMLandOwnerEntity = CurrentCRMLandOwnerEntity;


            if (!cRMLandOwnerEntity.IsNew)
            {
                txtOwnerName.Text = cRMLandOwnerEntity.OwnerName.ToString();
                txtOwnPercentage.Text = cRMLandOwnerEntity.OwnPercentage.ToString();
                txtMobileNo.Text = cRMLandOwnerEntity.MobileNo.ToString();
                txtLandPhone.Text = cRMLandOwnerEntity.LandPhone.ToString();
                txtPresentAddress.Text = cRMLandOwnerEntity.PresentAddress.ToString();
                txtFatherName.Text = cRMLandOwnerEntity.FatherName.ToString();
                txtMotherName.Text = cRMLandOwnerEntity.MotherName.ToString();
                txtSpouseName.Text = cRMLandOwnerEntity.SpouseName.ToString();
                txtDateOfBirth.Text = cRMLandOwnerEntity.DateOfBirth.ToStringDefault();
                txtEmail.Text = cRMLandOwnerEntity.Email.ToString();
                txtBusinessDetails.Text = cRMLandOwnerEntity.BusinessDetails.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMLandOwnerList();
        }

        private void BindCRMLandOwnerList()
        {
            lvCRMLandOwner.DataBind();
        }

        private CRMLandOwnerEntity BuildCRMLandOwnerEntity()
        {
            CRMLandOwnerEntity cRMLandOwnerEntity = CurrentCRMLandOwnerEntity;

            cRMLandOwnerEntity.LandBasicInfoID = CRMLandBasicInfoID;
            cRMLandOwnerEntity.OwnerName = txtOwnerName.Text.Trim(); String ImageUrlpath;

            if (fuImageUrl.HasFile == true && cRMLandOwnerEntity.ImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(cRMLandOwnerEntity.ImageUrl)))
                {
                    File.Delete(Server.MapPath(cRMLandOwnerEntity.ImageUrl));
                }
                ImageUrlpath = FileUploadConstants.CRM.LandOwner + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(ImageUrlpath));
                cRMLandOwnerEntity.ImageUrl = ImageUrlpath;
            }

            if (cRMLandOwnerEntity.ImageUrl.IsNotNullOrEmpty() && fuImageUrl.HasFile == false)
            {
                cRMLandOwnerEntity.ImageUrl = cRMLandOwnerEntity.ImageUrl;
            }

            if (fuImageUrl.HasFile == false && cRMLandOwnerEntity.ImageUrl.IsNullOrEmpty())
            {
                cRMLandOwnerEntity.ImageUrl = null;
            }

            if (fuImageUrl.HasFile == true && cRMLandOwnerEntity.ImageUrl.IsNullOrEmpty())
            {
                ImageUrlpath = FileUploadConstants.CRM.LandOwner+ Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(ImageUrlpath));
                cRMLandOwnerEntity.ImageUrl = ImageUrlpath;
            }
            if (!txtOwnPercentage.Text.Trim().IsNullOrEmpty())
            {
                cRMLandOwnerEntity.OwnPercentage = Decimal.Parse(txtOwnPercentage.Text.Trim());
            }
            else
            {
                cRMLandOwnerEntity.OwnPercentage = null;
            }

            cRMLandOwnerEntity.MobileNo = txtMobileNo.Text.Trim();
            cRMLandOwnerEntity.LandPhone = txtLandPhone.Text.Trim();
            cRMLandOwnerEntity.PresentAddress = txtPresentAddress.Text.Trim();
            cRMLandOwnerEntity.FatherName = txtFatherName.Text.Trim();
            cRMLandOwnerEntity.MotherName = txtMotherName.Text.Trim();
            cRMLandOwnerEntity.SpouseName = txtSpouseName.Text.Trim();
            if (txtDateOfBirth.Text.Trim().IsNotNullOrEmpty())
            {
                cRMLandOwnerEntity.DateOfBirth = MiscUtil.ParseToDateTime(txtDateOfBirth.Text);
            }
            else
            {
                cRMLandOwnerEntity.DateOfBirth = null;
            }

            cRMLandOwnerEntity.Email = txtEmail.Text.Trim();
            cRMLandOwnerEntity.BusinessDetails = txtBusinessDetails.Text.Trim();

            return cRMLandOwnerEntity;
        }

        private void SaveCRMLandOwnerEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMLandOwnerEntity cRMLandOwnerEntity = BuildCRMLandOwnerEntity();

                    Int64 result = -1;

                    if (cRMLandOwnerEntity.IsNew)
                    {
                        result = FCCCRMLandOwner.GetFacadeCreate().Add(cRMLandOwnerEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMLandOwnerEntity.FLD_NAME_LandOwnerID, cRMLandOwnerEntity.LandOwnerID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMLandOwner.GetFacadeCreate().Update(cRMLandOwnerEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _LandOwnerID = 0;
                        _CRMLandOwnerEntity = new CRMLandOwnerEntity();
                        PrepareInitialView();
                        BindCRMLandOwnerList();

                        if (cRMLandOwnerEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Landowner Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Landowner Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMLandOwnerEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Landowner Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Landowner Information.", false);
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

        protected void lvCRMLandOwner_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 LandOwnerID;

            Int64.TryParse(e.CommandArgument.ToString(), out LandOwnerID);

            if (LandOwnerID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _LandOwnerID = LandOwnerID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMLandOwnerEntity.FLD_NAME_LandOwnerID, LandOwnerID.ToString(), SQLMatchType.Equal);

                        CRMLandOwnerEntity cRMLandOwnerEntity = new CRMLandOwnerEntity();


                        result = FCCCRMLandOwner.GetFacadeCreate().Delete(cRMLandOwnerEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _LandOwnerID = 0;
                            _CRMLandOwnerEntity = new CRMLandOwnerEntity();
                            PrepareInitialView();
                            BindCRMLandOwnerList();

                            MiscUtil.ShowMessage(lblMessage, "C RMLandowner has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMLandowner.", true);
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

        protected void odsCRMLandOwner_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMLandOwnerEntity.FLD_NAME_LandBasicInfoID, CRMLandBasicInfoID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMLandOwnerEntity();
        }

        protected void btnCommunicate_Click(object sender, EventArgs e)
        {
            String navUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMCommunication.aspx", string.Empty, "do", "Land", UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID, CRMLandBasicInfoID.ToString()).ToString();
            Response.Redirect(navUrl);
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _LandOwnerID = 0;
            _CRMLandOwnerEntity = new CRMLandOwnerEntity();
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
