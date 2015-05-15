// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public partial class CMContractorControl : BaseControl
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

        public Int64 _ContractorID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["vContractorID"] != null)
                {
                    Int64.TryParse(ViewState["vContractorID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["vContractorID"] = value;
            }
        }

        public CMContractorEntity _CMContractorEntity
        {
            get
            {
                CMContractorEntity entity = new CMContractorEntity();

                if (ViewState["CurrentContractorEntity"] != null)
                {
                    entity = (CMContractorEntity)ViewState["CurrentContractorEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentContractorEntity"] = value;
            }
        }

        private CMContractorEntity CurrentCMContractorEntity
        {
            get
            {
                if (_ContractorID > 0)
                {
                    if (_CMContractorEntity.ContractorID != _ContractorID)
                    {
                        _CMContractorEntity = FCCCMContractor.GetFacadeCreate().GetByID(_ContractorID);
                    }
                }

                return _CMContractorEntity;
            }
            set
            {
                _CMContractorEntity = value;
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

            txtFirstName.Text = String.Empty;
            txtMiddleName.Text = String.Empty;
            txtLastName.Text = String.Empty;

            txtNameOfWork.Text = String.Empty;
            txtDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtName.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMContractorEntity cMContractorEntity = CurrentCMContractorEntity;
            HRMemberEntity hRMemberEntity = CurrentHRMemberEntity;

            if (!hRMemberEntity.IsNew)
            {
                txtFirstName.Text = hRMemberEntity.FirstName.ToString();
                txtMiddleName.Text = hRMemberEntity.MiddleName.ToString();
                txtLastName.Text = hRMemberEntity.LastName.ToString();
            }

            if (!cMContractorEntity.IsNew)
            {
                txtNameOfWork.Text = cMContractorEntity.NameOfWork.ToString();
                txtDate.Text = cMContractorEntity.Date.ToStringDefault();
                txtName.Text = cMContractorEntity.Name.ToString();                

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMContractorList();
        }

        private void BindCMContractorList()
        {
            lvCMContractor.DataBind();
        }

        private HRMemberEntity BuildHRMemberEntity()
        {
            HRMemberEntity hRMemberEntity = CurrentHRMemberEntity;

            hRMemberEntity.FirstName = txtFirstName.Text.Trim();
            hRMemberEntity.MiddleName = txtMiddleName.Text.Trim();
            hRMemberEntity.LastName = txtLastName.Text.Trim();

            if (hRMemberEntity.IsNew)
            {
                hRMemberEntity.MemberTypeID = MasterDataConstants.MemberType.CONTRACTOR;
            }

            return hRMemberEntity;
        }

        private CMContractorEntity BuildCMContractorEntity()
        {
            CMContractorEntity cMContractorEntity = CurrentCMContractorEntity;

            cMContractorEntity.NameOfWork = txtNameOfWork.Text.Trim();
            if (txtDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMContractorEntity.Date = MiscUtil.ParseToDateTime(txtDate.Text);
            }
            cMContractorEntity.Name = txtName.Text.Trim();
            
            if (cMContractorEntity.IsNew)
            {
                cMContractorEntity.PreparedBy = this.CurrentMember.MemberID;
                cMContractorEntity.IsRemoved = false;
            }


            return cMContractorEntity;
        }

        private void SaveCMContractorEntity()
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

                        CMContractorEntity cMContractorEntity = BuildCMContractorEntity();

                        Int64 resultC = -1;

                        if (cMContractorEntity.IsNew)
                        {
                            cMContractorEntity.MemberID = result;

                            resultC = FCCCMContractor.GetFacadeCreate().Add(cMContractorEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMContractorEntity.FLD_NAME_ContractorID, cMContractorEntity.ContractorID.ToString(), SQLMatchType.Equal);
                            resultC = FCCCMContractor.GetFacadeCreate().Update(cMContractorEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        }



                        if (resultC > 0)
                        {
                            _ContractorID = 0;
                            _CMContractorEntity = new CMContractorEntity();
                            PrepareInitialView();
                            BindCMContractorList();

                            if (cMContractorEntity.IsNew)
                            {
                                ResourceEntity resourceEntity = new ResourceEntity();

                                resourceEntity.ReferenceID = resultC; // means new contractor id
                                resourceEntity.ResourceCategoryID = MasterDataConstants.ResourceCategory.CONTRACTOR;

                                FCCResource.GetFacadeCreate().Add(resourceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            }

                            if (cMContractorEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Contractor Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Contractor Information has been updated successfully.", false);
                            }
                        }
                        else
                        {
                            if (cMContractorEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Contractor Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Contractor Information.", false);
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

        protected void lvCMContractor_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CMContractor_DetailedEntity ent = (CMContractor_DetailedEntity)dataItem.DataItem;

                HyperLink hypContractor = (HyperLink)e.Item.FindControl("hypContractor");

                hypContractor.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMContractorEditor.aspx", string.Empty, UrlConstants.OVERVIEW_CONTRACTOR_ID, ent.ContractorID.ToString()).ToString();
                hypContractor.Target = "_blank";
            }
        }

        protected void lvCMContractor_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ContractorID;

            Int64.TryParse(e.CommandArgument.ToString(), out ContractorID);

            if (ContractorID > 0)
            {   


                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ContractorID = ContractorID;
                    _MemberID = CurrentCMContractorEntity.MemberID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        CMContractorEntity tempContractor = FCCCMContractor.GetFacadeCreate().GetByID(ContractorID);

                        #region Resource Delete

                        Int64 resultOne = -1;

                        String fe1_re = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ReferenceID, ContractorID.ToString(), SQLMatchType.Equal);
                        String fe2_re = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceCategoryID, MasterDataConstants.ResourceCategory.CONTRACTOR.ToString(), SQLMatchType.Equal);
                        String fe_re = SqlExpressionBuilder.PrepareFilterExpression(fe1_re, SQLJoinType.AND, fe2_re);

                        IList<ResourceEntity> resourceList = FCCResource.GetFacadeCreate().GetIL(null, null, String.Empty, fe_re, DatabaseOperationType.LoadWithFilterExpression);

                        foreach(ResourceEntity ent in resourceList)
                        {
                            String fe_re_delete = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceID, ent.ResourceID.ToString(), SQLMatchType.Equal);

                            resultOne = FCCResource.GetFacadeCreate().Delete(ent, fe_re_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        }

                        #endregion

                        #region Contractor Delete

                        Int64 resultTwo = -1;

                        if (resultOne == 0)
                        {
                            String fe_con_delete = SqlExpressionBuilder.PrepareFilterExpression(CMContractorEntity.FLD_NAME_ContractorID, ContractorID.ToString(), SQLMatchType.Equal);

                            CMContractorEntity cMContractorEntity = new CMContractorEntity();

                            resultTwo = FCCCMContractor.GetFacadeCreate().Delete(cMContractorEntity, fe_con_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        }
                        
                        #endregion
                        
                        #region Member Delete

                        Int64 resultThree = -1;

                        if (resultTwo == 0)
                        {
                            String fe_mem_delete = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, tempContractor.MemberID.ToString(), SQLMatchType.Equal);

                            HRMemberEntity hRMemberEntity = new HRMemberEntity();

                            resultThree = FCCHRMember.GetFacadeCreate().Delete(hRMemberEntity, fe_mem_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        }

                        #endregion

                        if (resultOne == 0 && resultTwo == 0 && resultThree == 0)
                        {
                            _ContractorID = 0;
                            _CMContractorEntity = new CMContractorEntity();
                            _MemberID = 0;
                            _HRMemberEntity = new HRMemberEntity();

                            PrepareInitialView();
                            BindCMContractorList();

                            MiscUtil.ShowMessage(lblMessage, "Contractor has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Contractor.", true);
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

        protected void odsCMContractor_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMContractorEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MemberID = 0;
            _HRMemberEntity = new HRMemberEntity();

            _ContractorID = 0;
            _CMContractorEntity = new CMContractorEntity();

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
