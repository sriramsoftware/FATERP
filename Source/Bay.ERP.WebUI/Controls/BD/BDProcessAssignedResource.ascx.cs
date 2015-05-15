// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class BDProcessAssignedResourceControl : BaseControl
    {

        #region Extra

        class CustomerComparer : IEqualityComparer<CRMContactList_CustomEntity>
        {
            public bool Equals(CRMContactList_CustomEntity x, CRMContactList_CustomEntity y)
            {
                return (x.ResourceID.Equals(y.ResourceID) && x.ResourceCategoryID.Equals(y.ResourceCategoryID));
            }

            public int GetHashCode(CRMContactList_CustomEntity obj)
            {
                return obj.ResourceID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _ProcessAssignedResourceID
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

        public BDProcessAssignedResourceEntity _BDProcessAssignedResourceEntity
        {
            get
            {
                BDProcessAssignedResourceEntity entity = new BDProcessAssignedResourceEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProcessAssignedResourceEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProcessAssignedResourceEntity CurrentBDProcessAssignedResourceEntity
        {
            get
            {
                if (_ProcessAssignedResourceID > 0)
                {
                    if (_BDProcessAssignedResourceEntity.ProcessAssignedResourceID != _ProcessAssignedResourceID)
                    {
                        _BDProcessAssignedResourceEntity = FCCBDProcessAssignedResource.GetFacadeCreate().GetByID(_ProcessAssignedResourceID);
                    }
                }

                return _BDProcessAssignedResourceEntity;
            }
            set
            {
                _BDProcessAssignedResourceEntity = value;
            }
        }

        public Int64 _ProcessAssignedResourceMapID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ProcessAssignedResourceMapID"] != null)
                {
                    Int64.TryParse(ViewState["ProcessAssignedResourceMapID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ProcessAssignedResourceMapID"] = value;
            }
        }

        public BDProcessAssignedResourceMapEntity _BDProcessAssignedResourceMapEntity
        {
            get
            {
                BDProcessAssignedResourceMapEntity entity = new BDProcessAssignedResourceMapEntity();

                if (ViewState["BDProcessAssignedResourceMapEntity"] != null)
                {
                    entity = (BDProcessAssignedResourceMapEntity)ViewState["BDProcessAssignedResourceMapEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["BDProcessAssignedResourceMapEntity"] = value;
            }
        }

        private BDProcessAssignedResourceMapEntity CurrentBDProcessAssignedResourceMapEntity
        {
            get
            {
                if (_ProcessAssignedResourceID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ProcessAssignedResourceID, _ProcessAssignedResourceID.ToString(), SQLMatchType.Equal);
                    IList<BDProcessAssignedResourceMapEntity> lst = FCCBDProcessAssignedResourceMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (lst != null && lst.Count > 0)
                    {
                        _BDProcessAssignedResourceMapEntity = lst[0];
                    }
                    else
                    {
                        _BDProcessAssignedResourceMapEntity = new BDProcessAssignedResourceMapEntity();
                    }
                }

                return _BDProcessAssignedResourceMapEntity;
            }
            set
            {
                _BDProcessAssignedResourceMapEntity = value;
            }
        }

        public IList<CRMContactList_CustomEntity> IssueCRMContactList_CustomEntityList
        {
            get
            {
                return (IList<CRMContactList_CustomEntity>)ViewState["IssueCRMContactList_CustomEntityList"];
            }
            set
            {
                ViewState["IssueCRMContactList_CustomEntityList"] = value;
            }
        }

     

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDMDProcessCategory(ddlProcessCategoryID, false);
            MiscUtil.PopulateBDMDProcessAssignedResourceApprovalStatus(ddlProcessAssignedResourceApprovalStatusID, false);
            MiscUtil.PopulateMDResourceCategory(ddlResourceCategoryID, false);

            if (ddlResourceCategoryID.Items.Count > 0 && ddlResourceCategoryID != null)
            {
                ListItem item = ddlResourceCategoryID.Items.FindByValue(MasterDataConstants.ResourceCategory.TOOL.ToString());
                ddlResourceCategoryID.Items.Remove(item);
            }

            MiscUtil.PopulateStartWithAPPanel(ddlAPPanelID, false, MasterDataConstants.APPanelStartWith.CRM);
        }

        private void PrepareValidator()
        {
        }

        private void BuildResourceByResourceCategory()
        {
            if (ddlResourceCategoryID.Items.Count > 0 && ddlResourceCategoryID != null)
            {
                ViewState["SearchString"] = SqlExpressionBuilder.PrepareFilterExpression(CRMContactList_CustomEntity.FLD_NAME_ResourceCategoryID, ddlResourceCategoryID.SelectedValue.ToString(), SQLMatchType.Equal);

                BindCRMContactList();

                //switch (Int64.Parse(ddlResourceCategoryID.SelectedValue))
                //{
                //    case MasterDataConstants.ResourceCategory.VENDOR:
                //        ViewState["SearchString"] = SqlExpressionBuilder.PrepareFilterExpression(CRMContactList_CustomEntity.FLD_NAME_ResourceCategoryID, ddlResourceCategoryID.SelectedValue.ToString(), SQLMatchType.Equal);
                //        BindPRMSupplierList();
                //        break;
                //    case MasterDataConstants.ResourceCategory.CONSULTANT:
                        
                //        BindPRMSupplierList();
                //        break;
                //    case MasterDataConstants.ResourceCategory.CONTRACTOR:
                        
                //        BindPRMSupplierList();
                //        break;
                //    case MasterDataConstants.ResourceCategory.EMPLOYEE:
                        
                //        BindHREmployeeList();
                //        break;
                //    case MasterDataConstants.ResourceCategory.LANDOWNER:
                //        break;
                //}
            }
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            if (ddlProcessCategoryID != null && ddlProcessCategoryID.Items.Count > 0)
            {
                txtTitle.Text = ddlProcessCategoryID.SelectedItem.ToString();
            }
            else
            {
                txtTitle.Text = "Title Here";
            }
            txtPurposes.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtStartDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;

            IssueCRMContactList_CustomEntityList = new List<CRMContactList_CustomEntity>();

            BuildResourceByResourceCategory();
        }

        private void PrepareEditView()
        {
            BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity = CurrentBDProcessAssignedResourceEntity;


            if (!bDProcessAssignedResourceEntity.IsNew)
            {
                if (ddlProcessCategoryID.Items.Count > 0 && bDProcessAssignedResourceEntity.ProcessCategoryID != null)
                {
                    ddlProcessCategoryID.SelectedValue = bDProcessAssignedResourceEntity.ProcessCategoryID.ToString();
                }

                txtTitle.Text = bDProcessAssignedResourceEntity.Title.ToString();
                txtPurposes.Text = bDProcessAssignedResourceEntity.Purposes.ToString();
                txtRemarks.Text = bDProcessAssignedResourceEntity.Remarks.ToString();
                txtStartDate.Text = bDProcessAssignedResourceEntity.StartDate.ToStringDefault();

                if (ddlProcessAssignedResourceApprovalStatusID.Items.Count > 0 && bDProcessAssignedResourceEntity.ProcessAssignedResourceApprovalStatusID != null)
                {
                    ddlProcessAssignedResourceApprovalStatusID.SelectedValue = bDProcessAssignedResourceEntity.ProcessAssignedResourceApprovalStatusID.ToString();
                }

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
                btnSubmitForApproval.Visible = true;
            }
        }

        private void BindBDProcessAssignedResourceMapList()
        {
            lvBDProcessAssignedResourceMap.DataBind();
        }

        private void BindCRMContactList()
        {
            lvCRMContactList.DataBind();
        }

        private void BindList()
        {
            BindCRMContactList();
        }

        private BDProcessAssignedResourceEntity BuildBDProcessAssignedResourceEntity()
        {
            BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity = CurrentBDProcessAssignedResourceEntity;

            if (ddlProcessCategoryID.Items.Count > 0)
            {
                if (ddlProcessCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProcessAssignedResourceEntity.ProcessCategoryID = Int64.Parse(ddlProcessCategoryID.SelectedValue);
                }
            }

            bDProcessAssignedResourceEntity.Title = txtTitle.Text.Trim();
            bDProcessAssignedResourceEntity.Purposes = txtPurposes.Text.Trim();
            bDProcessAssignedResourceEntity.Remarks = txtRemarks.Text.Trim();
            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                bDProcessAssignedResourceEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }
            else
            {
                bDProcessAssignedResourceEntity.StartDate = null;
            }

            bDProcessAssignedResourceEntity.CreateDate = System.DateTime.Now;
            bDProcessAssignedResourceEntity.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            if (ddlProcessAssignedResourceApprovalStatusID.Items.Count > 0)
            {
                if (ddlProcessAssignedResourceApprovalStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProcessAssignedResourceEntity.ProcessAssignedResourceApprovalStatusID = Int64.Parse(ddlProcessAssignedResourceApprovalStatusID.SelectedValue);
                }
            }


            return bDProcessAssignedResourceEntity;
        }

        private void SaveBDProcessAssignedResourceEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity = BuildBDProcessAssignedResourceEntity();

                    Int64 result = -1;

                    if (bDProcessAssignedResourceEntity.IsNew)
                    {
                        result = FCCBDProcessAssignedResource.GetFacadeCreate().Add(bDProcessAssignedResourceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceEntity.FLD_NAME_ProcessAssignedResourceID, bDProcessAssignedResourceEntity.ProcessAssignedResourceID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProcessAssignedResource.GetFacadeCreate().Update(bDProcessAssignedResourceEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity = CurrentBDProcessAssignedResourceMapEntity;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ProcessAssignedResourceID, result.ToString(), SQLMatchType.Equal);
                        IList<BDProcessAssignedResourceMapEntity> mappedItemsFromDB = FCCBDProcessAssignedResourceMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                        IList<CRMContactList_CustomEntity> tempAddList = new List<CRMContactList_CustomEntity>();

                        if (mappedItemsFromDB != null && mappedItemsFromDB.Count > 0)
                        {
                            foreach (BDProcessAssignedResourceMapEntity ent in mappedItemsFromDB)
                            {
                                CRMContactList_CustomEntity cRMContactList_CustomEntity = new CRMContactList_CustomEntity();
                                cRMContactList_CustomEntity.ResourceID = ent.ReferenceID;
                                cRMContactList_CustomEntity.ResourceCategoryID = ent.ResourceCategoryID.ToString();
                                cRMContactList_CustomEntity.ResourceName = ent.ResourceName;
                                cRMContactList_CustomEntity.ResourceDesignation = ent.ResourceDesignation;
                                cRMContactList_CustomEntity.ResourceEmail = ent.ResourceEmail;
                                cRMContactList_CustomEntity.AddressLine1 = ent.AddressLine1;
                                cRMContactList_CustomEntity.AddressLine2 = ent.AddressLine2;
                                cRMContactList_CustomEntity.ResourceMobileNo = ent.ResourceMobileNo;
                                Int64 resourceTypeID = 0;
                                Int64.TryParse(ent.ResourceTypeID.ToString(), out resourceTypeID);
                                cRMContactList_CustomEntity.ResourceTypeID = resourceTypeID;
                                cRMContactList_CustomEntity.ResourceCompany = ent.ResourceCompany;
                                tempAddList.Add(cRMContactList_CustomEntity);
                            }
                        }

                        IList<CRMContactList_CustomEntity> finalAddList = IssueCRMContactList_CustomEntityList.Except(tempAddList, new CustomerComparer()).ToList();
                        IList<CRMContactList_CustomEntity> finalDeleteList = tempAddList.Except(IssueCRMContactList_CustomEntityList, new CustomerComparer()).ToList();

                        foreach (CRMContactList_CustomEntity ent in finalAddList)
                        {

                            bDProcessAssignedResourceMapEntity.ProcessAssignedResourceID = result;
                            bDProcessAssignedResourceMapEntity.ResourceCategoryID = Int64.Parse(ent.ResourceCategoryID.ToString());
                            bDProcessAssignedResourceMapEntity.ReferenceID = ent.ResourceID;
                            bDProcessAssignedResourceMapEntity.ResourceName = ent.ResourceName;
                            bDProcessAssignedResourceMapEntity.ResourceDesignation = ent.ResourceDesignation;
                            bDProcessAssignedResourceMapEntity.ResourceEmail = ent.ResourceEmail;
                            bDProcessAssignedResourceMapEntity.ResourceMobileNo = ent.ResourceMobileNo;
                            bDProcessAssignedResourceMapEntity.AddressLine1 = ent.AddressLine1;
                            bDProcessAssignedResourceMapEntity.AddressLine2 = ent.AddressLine2;
                            Int64 resourceTypeID = 0;
                            Int64.TryParse(ent.ResourceTypeID.ToString(), out resourceTypeID);
                            bDProcessAssignedResourceMapEntity.ResourceTypeID = resourceTypeID;
                            bDProcessAssignedResourceMapEntity.ResourceCompany = ent.ResourceCompany;
                            bDProcessAssignedResourceMapEntity.Remarks = txtRemarks.Text.Trim();

                            FCCBDProcessAssignedResourceMap.GetFacadeCreate().Add(bDProcessAssignedResourceMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }

                        foreach (CRMContactList_CustomEntity ent in finalDeleteList)
                        {
                            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ReferenceID, ent.ResourceID.ToString(), SQLMatchType.Equal);
                            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ResourceCategoryID,ent.ResourceCategoryID, SQLMatchType.Equal);

                            String fe_delete = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                            FCCBDProcessAssignedResourceMap.GetFacadeCreate().Delete(bDProcessAssignedResourceMapEntity, fe_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        }

                        if (!bDProcessAssignedResourceEntity.IsNew)
                        {
                            //_ProcessAssignedResourceID = 0;
                            //_BDProcessAssignedResourceEntity = new BDProcessAssignedResourceEntity();
                        }

                        _ProcessAssignedResourceID = result;
                        PrepareEditView();
                        BindBDProcessAssignedResourceMapList();

                        if (bDProcessAssignedResourceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Process Assigned Resource Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Process Assigned Resource Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProcessAssignedResourceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Process Assigned Resource Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Process Assigned Resource Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void BindResourceEmployeeInfoNew()
        {
            try
            {
                IList<ListViewDataItem> list = lvCRMContactList.Items;

                if (list != null && list.Count > 0)
                {

                    foreach (ListViewDataItem lvdi in list)
                    {
                        CheckBox chkSelectResourceLV = (CheckBox)lvdi.FindControl("chkSelectResourceLV");

                        if (chkSelectResourceLV.Checked == true)
                        {
                            Int64 resourceIDLV, resourceCategoryIDLV;
                            Int64? resourceTypeID;
                            String resourceName, resourceDesignation, resourceCompany, resourceMobileNo, resourceEmail,addressLine1,addressLine2;
                            DateTime? resourceDOB;


                            Label lblResourceIDLV = (Label)lvdi.FindControl("lblResourceIDLV");
                            Label lblResourceCategoryIDLV = (Label)lvdi.FindControl("lblResourceCategoryIDLV");
                            Label lblResourceNameLV = (Label)lvdi.FindControl("lblResourceNameLV");
                            Label lblResourceDesignationLV = (Label)lvdi.FindControl("lblResourceDesignationLV");
                            Label lblResourceCompanyLV = (Label)lvdi.FindControl("lblResourceCompanyLV");
                            Label lblResourceMobileNoLV = (Label)lvdi.FindControl("lblResourceMobileNoLV");
                            Label lblResourceEmailLV = (Label)lvdi.FindControl("lblResourceEmailLV");
                            Label lblAddressLine1 = (Label)lvdi.FindControl("lblAddressLine1");
                            Label lblAddressLine2 = (Label)lvdi.FindControl("lblAddressLine2");
                            Label lblResourceTypeIDLV = (Label)lvdi.FindControl("lblResourceTypeIDLV");
                            Label lblResourceDOBLV = (Label)lvdi.FindControl("lblResourceDOBLV");

                            Int64.TryParse(lblResourceIDLV.Text, out resourceIDLV);
                            Int64.TryParse(lblResourceCategoryIDLV.Text, out resourceCategoryIDLV);

                            resourceName = lblResourceNameLV.Text.Trim();
                            resourceDesignation = lblResourceDesignationLV.Text.Trim();
                            resourceCompany = lblResourceCompanyLV.Text.Trim();
                            resourceMobileNo = lblResourceMobileNoLV.Text.Trim();
                            resourceEmail = lblResourceEmailLV.Text.Trim();
                            if (!lblResourceTypeIDLV.Text.Trim().IsNullOrEmpty())
                            {
                                resourceTypeID = Int64.Parse(lblResourceTypeIDLV.Text.Trim());
                            }
                            else
                            {
                                resourceTypeID = null;
                            }

                            if (lblResourceDOBLV.Text.Trim().IsNotNullOrEmpty())
                            {
                                resourceDOB = MiscUtil.ParseToDateTime(lblResourceDOBLV.Text);
                            }
                            else
                            {
                                resourceDOB = null;
                            }

                            if (lblAddressLine1.Text.Trim().IsNotNullOrEmpty())
                            {
                                addressLine1 = lblAddressLine1.Text.Trim();
                            }
                            else
                            {
                                addressLine1 = null;
                            }

                            if (lblAddressLine2.Text.Trim().IsNotNullOrEmpty())
                            {
                                addressLine2 = lblAddressLine2.Text.Trim();
                            }
                            else
                            {
                                addressLine2 = null;
                            }


                            CRMContactList_CustomEntity cRMContactList_CustomEntity = new CRMContactList_CustomEntity();

                            cRMContactList_CustomEntity.ResourceID = resourceIDLV;
                            cRMContactList_CustomEntity.ResourceCategoryID = resourceCategoryIDLV.ToString();
                            cRMContactList_CustomEntity.ResourceName=resourceName;
                            cRMContactList_CustomEntity.ResourceCompany=resourceCompany;
                            cRMContactList_CustomEntity.ResourceDesignation=resourceDesignation;
                            cRMContactList_CustomEntity.ResourceEmail=resourceEmail;
                            cRMContactList_CustomEntity.AddressLine1 = addressLine1;
                            cRMContactList_CustomEntity.AddressLine2 = addressLine2;
                            cRMContactList_CustomEntity.ResourceDOB=resourceDOB;
                            cRMContactList_CustomEntity.ResourceTypeID =(Int64)resourceTypeID;
                            //Check Existing Item

                            var employeeList = (from s in IssueCRMContactList_CustomEntityList
                                                where s.ResourceID == resourceIDLV && s.ResourceCategoryID == resourceCategoryIDLV.ToString()
                                                select s);
                            if (employeeList == null || employeeList.Count() <= 0)
                            {
                                IssueCRMContactList_CustomEntityList.Add(cRMContactList_CustomEntity);
                            }

                        }

                        else if (chkSelectResourceLV.Checked == false)
                        {

                            Int64 resourceIDLV, resourceCategoryIDLV;

                            Label lblResourceIDLV = (Label)lvdi.FindControl("lblResourceIDLV");
                            Label lblResourceCategoryIDLV = (Label)lvdi.FindControl("lblResourceCategoryIDLV");
                          
                            Int64.TryParse(lblResourceIDLV.Text, out resourceIDLV);
                            Int64.TryParse(lblResourceCategoryIDLV.Text, out resourceCategoryIDLV);

                         

                            var item = from s in IssueCRMContactList_CustomEntityList
                                       where s.ResourceID == resourceIDLV && s.ResourceCategoryID == resourceCategoryIDLV.ToString()
                                       select s;

                            if (item != null && item.Count() > 0)
                            {
                                //Check Deleted Employee.
                                CRMContactList_CustomEntity di = (from d in IssueCRMContactList_CustomEntityList
                                                                  where d.ResourceID == resourceIDLV && d.ResourceCategoryID == rfvResourceCategoryID.ToString()
                                                                    select d).First();
                                //Delete Here.
                                if (di != null)
                                {
                                    IssueCRMContactList_CustomEntityList.Remove(di);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProcessAssignedResourceEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProcessAssignedResourceID = 0;
            _BDProcessAssignedResourceEntity = new BDProcessAssignedResourceEntity();
            PrepareInitialView();
        }

        protected void btnAddToList_Click(object sender, EventArgs e)
        {
            BindResourceEmployeeInfoNew();
            SaveBDProcessAssignedResourceEntity();
        }

        protected void btnSubmitForApproval_Click(object sender, EventArgs e)
        {
            #region Save Initally

            SaveBDProcessAssignedResourceEntity();

            #endregion

            #region Approval Process

            if (ddlAPPanelID != null && ddlAPPanelID.SelectedValue != "0")
            {

                Boolean apResult = APRobot.CreateApprovalProcessForNewContactList(_ProcessAssignedResourceID, Int64.Parse(ddlAPPanelID.SelectedValue.ToString()));

                if (apResult == true)
                {
                    MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                    _ProcessAssignedResourceID = 0;
                    IssueCRMContactList_CustomEntityList = new List<CRMContactList_CustomEntity>();
                    _BDProcessAssignedResourceEntity = new BDProcessAssignedResourceEntity();
                    PrepareInitialView();
                    BindBDProcessAssignedResourceMapList();
                    btnSubmitForApproval.Visible = false;
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                }

                //EnableDisableApprovalProcessCheck();
            }

            #endregion
        }

        #endregion

        #region ObjectDataSource Event Resource

        protected void odsCRMContactList_Custom_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

            if (e.ExecutingSelectCount == false)
            {
                BindResourceEmployeeInfoNew();
            }

            String fe = String.Empty;

            if (ViewState["SearchString"] != null)
            {
                fe = (String)ViewState["SearchString"];
            }

            if (chbxFilter.Checked)
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("ResourceCategoryID", ddlResourceCategoryID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("ResourceName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);

                //if (txtSearchText.Text.Trim().IsNotNullOrEmpty())
                //{
                //    // Activity Log
                //    //  base.LogActivity("Searching Requisition With " + txtSearchText.Text.Trim().ToString(), true);
                //}
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region List View Event Assigned Resources

        protected void lvBDProcessAssignedResourceMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProcessAssignedResourceMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProcessAssignedResourceMapID);

            if (ProcessAssignedResourceMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProcessAssignedResourceMapID = ProcessAssignedResourceMapID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ProcessAssignedResourceMapID, ProcessAssignedResourceMapID.ToString(), SQLMatchType.Equal);

                        BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity = new BDProcessAssignedResourceMapEntity();


                        result = FCCBDProcessAssignedResourceMap.GetFacadeCreate().Delete(bDProcessAssignedResourceMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProcessAssignedResourceMapID = 0;
                            _BDProcessAssignedResourceMapEntity = new BDProcessAssignedResourceMapEntity();
                            PrepareInitialView();
                            BindBDProcessAssignedResourceMapList();

                            MiscUtil.ShowMessage(lblMessage, "Process Assigned Resource Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Process Assigned Resource Map.", true);
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

        #region ObjectDataSource Event Assigned Resources

        protected void odsBDProcessAssignedResourceMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceEntity.FLD_NAME_ProcessAssignedResourceID, "0", SQLMatchType.Equal); ;

            if (_ProcessAssignedResourceID > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceEntity.FLD_NAME_ProcessAssignedResourceID, _ProcessAssignedResourceID.ToString(), SQLMatchType.Equal);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region List View Event Resource

        protected void lvCRMContactList_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CheckBox chkSelectResourceLV = (CheckBox)e.Item.FindControl("chkSelectResourceLV");

                Int64 resourceIDLV, resourceCategoryIDLV;

                Label lblResourceIDLV = (Label)e.Item.FindControl("lblResourceIDLV");
                Label lblResourceCategoryIDLV = (Label)e.Item.FindControl("lblResourceCategoryIDLV");

                Int64.TryParse(lblResourceIDLV.Text, out resourceIDLV);
                Int64.TryParse(lblResourceCategoryIDLV.Text, out resourceCategoryIDLV);

                var employeeList = (from s in IssueCRMContactList_CustomEntityList
                                    where s.ResourceID == resourceIDLV && s.ResourceCategoryID == resourceCategoryIDLV.ToString()
                                    select s).ToList();
              

                if (employeeList != null && employeeList.Count() > 0)
                {
                    chkSelectResourceLV.Checked = true;
                }
                else
                {
                    chkSelectResourceLV.Checked = false;
                }
            }
        }

        #endregion List View Event

        #region Dropdown Event

        protected void ddlResourceCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildResourceByResourceCategory();
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
