// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




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
    public partial class CMConsultantControl : BaseControl
    {       
        #region Properties

        public Int64 _MemberID
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

        public HRMemberEntity _HRMemberEntity
        {
            get
            {
                HRMemberEntity entity = new HRMemberEntity();

                if (ViewState["CurrentMemberEntity"] != null)
                {
                    entity = (HRMemberEntity)ViewState["CurrentMemberEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentMemberEntity"] = value;
            }
        }

        private HRMemberEntity CurrentHRMemberEntity
        {
            get
            {
                if (_MemberID > 0)
                {
                    if (_HRMemberEntity.MemberID != _MemberID)
                    {
                        _HRMemberEntity = FCCHRMember.GetFacadeCreate().GetByID(_MemberID);
                    }
                }

                return _HRMemberEntity;
            }
            set
            {
                _HRMemberEntity = value;
            }
        }

        public Int64 _ConsultantID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["vConsultantID"] != null)
                {
                    Int64.TryParse(ViewState["vConsultantID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["vConsultantID"] = value;
            }
        }

        public CMConsultantEntity _CMConsultantEntity
        {
            get
            {
                CMConsultantEntity entity = new CMConsultantEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMConsultantEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMConsultantEntity CurrentCMConsultantEntity
        {
            get
            {
                if (_ConsultantID > 0)
                {
                    if (_CMConsultantEntity.ConsultantID != _ConsultantID)
                    {
                        _CMConsultantEntity = FCCCMConsultant.GetFacadeCreate().GetByID(_ConsultantID);
                    }
                }

                return _CMConsultantEntity;
            }
            set
            {
                _CMConsultantEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            
        }

        private void PrepareValidator()
        {
            revEmailAddress1.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmailAddress1.MaxLength = ValidationConstants.FieldLength.Email;
            revEmailAddress1.ErrorMessage = ValidationConstants.ErrorMessage.Email;


            revEmailAddress2.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmailAddress2.MaxLength = ValidationConstants.FieldLength.Email;
            revEmailAddress2.ErrorMessage = ValidationConstants.ErrorMessage.Email;

            revPhone.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtPhone.MaxLength = ValidationConstants.FieldLength.Phone;
            revPhone.ErrorMessage = ValidationConstants.ErrorMessage.Phone;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            
            txtFirstName.Text = String.Empty;
            txtMiddleName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtName.Text = String.Empty;
            txtCurrentPosition.Text = String.Empty;
            txtInstitueName.Text = String.Empty;
            txtEmailAddress1.Text = String.Empty;
            txtEmailAddress2.Text = String.Empty;
            txtContactNo1.Text = String.Empty;
            txtContactNo2.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMConsultantEntity cMConsultantEntity = CurrentCMConsultantEntity;
            HRMemberEntity hRMemberEntity = CurrentHRMemberEntity;

            if (!hRMemberEntity.IsNew)
            {
                txtFirstName.Text = hRMemberEntity.FirstName.ToString();
                txtMiddleName.Text = hRMemberEntity.MiddleName.ToString();
                txtLastName.Text = hRMemberEntity.LastName.ToString();
            }

            if (!cMConsultantEntity.IsNew)
            {
                txtName.Text = cMConsultantEntity.Name.ToString();
                txtCurrentPosition.Text = cMConsultantEntity.CurrentPosition.ToString();
                txtInstitueName.Text = cMConsultantEntity.InstitueName.ToString();
                txtEmailAddress1.Text = cMConsultantEntity.EmailAddress1.ToString();
                txtEmailAddress2.Text = cMConsultantEntity.EmailAddress2.ToString();
                txtContactNo1.Text = cMConsultantEntity.ContactNo1.ToString();
                txtContactNo2.Text = cMConsultantEntity.ContactNo2.ToString();
                txtPhone.Text = cMConsultantEntity.Phone.ToString();
                txtRemarks.Text = cMConsultantEntity.Remarks.ToString();
                chkIsRemoved.Checked = cMConsultantEntity.IsRemoved;
                
                btnSubmit.Text = "Update";
                btnAddNew.Visible = false;
            }
        }

        private void BindList()
        {
            BindCMConsultantList();
        }

        private void BindCMConsultantList()
        {
            lvCMConsultant.DataBind();
        }

        private HRMemberEntity BuildHRMemberEntity()
        {
            HRMemberEntity hRMemberEntity = CurrentHRMemberEntity;

            hRMemberEntity.FirstName = txtFirstName.Text.Trim();
            hRMemberEntity.MiddleName = txtMiddleName.Text.Trim();
            hRMemberEntity.LastName = txtLastName.Text.Trim();

            if (hRMemberEntity.IsNew)
            {
                hRMemberEntity.MemberTypeID = MasterDataConstants.MemberType.CONSULATANT;
            }

            return hRMemberEntity;
        }

        private CMConsultantEntity BuildCMConsultantEntity()
        {
            CMConsultantEntity cMConsultantEntity = CurrentCMConsultantEntity;

            cMConsultantEntity.OutsourceCategoryID = MasterDataConstants.MDOutsourceCategory.ARTIST;
            cMConsultantEntity.Name = txtFirstName.Text.Trim() + " " + txtMiddleName.Text.Trim()+" "+txtLastName.Text.Trim();
            cMConsultantEntity.CurrentPosition = txtCurrentPosition.Text.Trim();
            cMConsultantEntity.InstitueName = txtInstitueName.Text.Trim();
            cMConsultantEntity.EmailAddress1 = txtEmailAddress1.Text.Trim();
            cMConsultantEntity.EmailAddress2 = txtEmailAddress2.Text.Trim();
            cMConsultantEntity.ContactNo1 = txtContactNo1.Text.Trim();
            cMConsultantEntity.ContactNo2 = txtContactNo2.Text.Trim();
            cMConsultantEntity.Phone = txtPhone.Text.Trim();
            cMConsultantEntity.Remarks = txtRemarks.Text.Trim();
            cMConsultantEntity.IsRemoved = chkIsRemoved.Checked;

            #region Image Url

            String ImageUrlpath;

            if (fuImageUrl.HasFile == true && cMConsultantEntity.ImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(cMConsultantEntity.ImageUrl)))
                {
                    File.Delete(Server.MapPath(cMConsultantEntity.ImageUrl));
                }
                ImageUrlpath = FileUploadConstants.CONSULTANT.CONSULTANT_IMAGE + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(ImageUrlpath));
                cMConsultantEntity.ImageUrl = ImageUrlpath;
            }

            if (cMConsultantEntity.ImageUrl.IsNotNullOrEmpty() && fuImageUrl.HasFile == false)
            {
                cMConsultantEntity.ImageUrl = cMConsultantEntity.ImageUrl;
            }

            if (fuImageUrl.HasFile == false && cMConsultantEntity.ImageUrl.IsNullOrEmpty())
            {
                cMConsultantEntity.ImageUrl = null;
            }

            if (fuImageUrl.HasFile == true && cMConsultantEntity.ImageUrl.IsNullOrEmpty())
            {
                ImageUrlpath = FileUploadConstants.CONSULTANT.CONSULTANT_IMAGE + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(ImageUrlpath));
                cMConsultantEntity.ImageUrl = ImageUrlpath;
            }

            #endregion

            return cMConsultantEntity;
        }

        private void SaveCMConsultantEntity()
        {
            if (IsValid)
            {
                try
                {
                    #region Member

                    HRMemberEntity hRMemberEntity = BuildHRMemberEntity();

                    Int64 result = -1;

                    if (hRMemberEntity.IsNew)
                    {
                        result = FCCHRMember.GetFacadeCreate().Add(hRMemberEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, hRMemberEntity.MemberID.ToString(), SQLMatchType.Equal);
                        result = FCCHRMember.GetFacadeCreate().Update(hRMemberEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    #endregion

                    if (result > 0)
                    {
                        _MemberID = 0;
                        _HRMemberEntity = new HRMemberEntity();
                    }

                    if (result > 0)
                    {
                        CMConsultantEntity cMConsultantEntity = BuildCMConsultantEntity();

                        Int64 resultC = -1;

                        if (cMConsultantEntity.IsNew)
                        {
                            cMConsultantEntity.MemberID = result;
                            resultC = FCCCMConsultant.GetFacadeCreate().Add(cMConsultantEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantEntity.FLD_NAME_ConsultantID, cMConsultantEntity.ConsultantID.ToString(), SQLMatchType.Equal);
                            resultC = FCCCMConsultant.GetFacadeCreate().Update(cMConsultantEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        }

                        if (resultC > 0)
                        {
                            _ConsultantID = 0;
                            _CMConsultantEntity = new CMConsultantEntity();
                            PrepareInitialView();
                            BindCMConsultantList();

                            if (cMConsultantEntity.IsNew)
                            {
                                ResourceEntity resourceEntity = new ResourceEntity();

                                resourceEntity.ReferenceID = resultC; // means new contractor id
                                resourceEntity.ResourceCategoryID = MasterDataConstants.ResourceCategory.CONSULTANT;

                                FCCResource.GetFacadeCreate().Add(resourceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            }

                            if (cMConsultantEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Consultant Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Consultant Information has been updated successfully.", false);
                            }
                        }
                        else
                        {
                            if (cMConsultantEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Consultant Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Consultant Information.", false);
                            }
                        }
                    }
                    else
                    {
                        if (hRMemberEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Member Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Member Information.", false);
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

        protected void lvCMConsultant_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CMConsultantEntity ent = (CMConsultantEntity)dataItem.DataItem;

                HyperLink hypConsultant = (HyperLink)e.Item.FindControl("hypConsultant");

                hypConsultant.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMConsultantEditor.aspx", string.Empty, UrlConstants.OVERVIEW_CONSULTANT_ID, ent.ConsultantID.ToString()).ToString();
                hypConsultant.Target = "_blank";
            }
        }

        protected void lvCMConsultant_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ConsultantID;

            Int64.TryParse(e.CommandArgument.ToString(), out ConsultantID);

            if (ConsultantID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ConsultantID = ConsultantID;
                    _MemberID = CurrentCMConsultantEntity.MemberID.Value;
                    

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        CMConsultantEntity tempConsultant = FCCCMConsultant.GetFacadeCreate().GetByID(ConsultantID);

                        #region Resource Delete

                        Int64 resultOne = -1;

                        String fe1_re = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ReferenceID, ConsultantID.ToString(), SQLMatchType.Equal);
                        String fe2_re = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceCategoryID, MasterDataConstants.ResourceCategory.CONSULTANT.ToString(), SQLMatchType.Equal);
                        String fe_re = SqlExpressionBuilder.PrepareFilterExpression(fe1_re, SQLJoinType.AND, fe2_re);

                        IList<ResourceEntity> resourceList = FCCResource.GetFacadeCreate().GetIL(null, null, String.Empty, fe_re, DatabaseOperationType.LoadWithFilterExpression);

                        foreach (ResourceEntity ent in resourceList)
                        {
                            String fe_re_delete = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceID, ent.ResourceID.ToString(), SQLMatchType.Equal);

                            resultOne = FCCResource.GetFacadeCreate().Delete(ent, fe_re_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        }

                        #endregion

                        #region Consultant Delete

                        Int64 resultTwo = -1;

                        if (resultOne == 0)
                        {
                            String fe_con_delete = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantEntity.FLD_NAME_ConsultantID, ConsultantID.ToString(), SQLMatchType.Equal);

                            CMConsultantEntity cMConsultantEntity = new CMConsultantEntity();

                            resultTwo = FCCCMConsultant.GetFacadeCreate().Delete(cMConsultantEntity, fe_con_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        }

                        #endregion

                        #region Member Delete

                        Int64 resultThree = -1;

                        if (resultTwo == 0)
                        {
                            String fe_mem_delete = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, tempConsultant.MemberID.ToString(), SQLMatchType.Equal);

                            HRMemberEntity hRMemberEntity = new HRMemberEntity();

                            resultThree = FCCHRMember.GetFacadeCreate().Delete(hRMemberEntity, fe_mem_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        }

                        #endregion

                        if (resultOne == 0 && resultTwo == 0 && resultThree == 0)
                        {
                            _ConsultantID = 0;
                            _CMConsultantEntity = new CMConsultantEntity();
                            _MemberID = 0;
                            _HRMemberEntity = new HRMemberEntity();

                            PrepareInitialView();
                            BindCMConsultantList();

                            MiscUtil.ShowMessage(lblMessage, "Consultant has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Consultant.", true);
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

        protected void odsCMConsultant_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMConsultantEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MemberID = 0;
            _HRMemberEntity = new HRMemberEntity();

            _ConsultantID = 0;
            _CMConsultantEntity = new CMConsultantEntity();

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
