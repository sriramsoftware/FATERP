// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




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
using System.Web.Security;

namespace Bay.ERP.Web.UI
{
    public partial class MDItemControl : BaseControl
    {

        #region Extra

        class CustomerComparer : IEqualityComparer<PRMItemBrandMapEntity>
        {
            public bool Equals(PRMItemBrandMapEntity x, PRMItemBrandMapEntity y)
            {
                return (x.BrandID.Equals(y.BrandID) && x.ItemID.Equals(y.ItemID));
            }

            public int GetHashCode(PRMItemBrandMapEntity obj)
            {
                return obj.BrandID.GetHashCode();
            }
        }

        class CustomerComparerAnother : IEqualityComparer<PRMItemBrandMapEntity>
        {
            public bool Equals(PRMItemBrandMapEntity x, PRMItemBrandMapEntity y)
            {
                return (x.BrandID.Equals(y.BrandID));
            }

            public int GetHashCode(PRMItemBrandMapEntity obj)
            {
                return obj.BrandID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        #region Item

        public Int64 _ItemID
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

        public MDItemEntity _MDItemEntity
        {
            get
            {
                MDItemEntity entity = new MDItemEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDItemEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDItemEntity CurrentMDItemEntity
        {
            get
            {
                if (_ItemID > 0)
                {
                    if (_MDItemEntity.ItemID != _ItemID)
                    {
                        _MDItemEntity = FCCMDItem.GetFacadeCreate().GetByID(_ItemID);
                    }
                }

                return _MDItemEntity;
            }
            set
            {
                _MDItemEntity = value;
            }
        }

        #endregion Item

        #region Item Default 

        private MDItemDefaultEntity CurrentMDItemDefaultEntity
        {
            get
            {
                MDItemDefaultEntity entity = new MDItemDefaultEntity();
                if (_ItemID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemDefaultEntity.FLD_NAME_ItemID, _ItemID.ToString(), SQLMatchType.Equal);

                    IList<MDItemDefaultEntity> list = FCCMDItemDefault.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (list != null && list.Count > 0)
                    {
                        ViewState["CurrentItemDefaultEntity"] = entity = list[0];
                    }
                    else
                    {
                        entity = new MDItemDefaultEntity();
                    }
                }

                return entity;
            }
        }

        #endregion Item Default

        #region Item Brand Map

        public IList<PRMItemBrandMapEntity> _CurrentItemBrandMapList
        {
            get
            {
                IList<PRMItemBrandMapEntity> itemBrandMapList = null;

                if (ViewState["CurrentItemBrandMapList"] != null)
                {
                    itemBrandMapList = (List<PRMItemBrandMapEntity>)ViewState["CurrentItemBrandMapList"];
                }
                else
                {
                    itemBrandMapList = new List<PRMItemBrandMapEntity>();
                }

                return itemBrandMapList;
            }
            set
            {
                ViewState["CurrentItemBrandMapList"] = value;
            }
        }

        public IList<MDBrandEntity> _CurrentItemBrandList
        {
            get
            {
                IList<MDBrandEntity> itemBrandList = null;

                if (ViewState["CurrentItemBrandList"] != null)
                {
                    itemBrandList = (List<MDBrandEntity>)ViewState["CurrentItemBrandList"];
                }
                else
                {
                    itemBrandList = new List<MDBrandEntity>();
                }

                return itemBrandList;
            }
            set
            {
                ViewState["CurrentItemBrandList"] = value;
            }
        }

        #endregion Item Brand Map

        #region Item Thumb Rule

        private MDItemThumbRuleEntity CurrentMDItemThumbRuleEntity
        {
            get
            {
                MDItemThumbRuleEntity entity = new MDItemThumbRuleEntity();


                if (_ItemID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemThumbRuleEntity.FLD_NAME_ItemID, _ItemID.ToString(), SQLMatchType.Equal);

                    IList<MDItemThumbRuleEntity> list = FCCMDItemThumbRule.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (list != null && list.Count > 0)
                    {
                        entity = list[0];
                    }
                    else
                    {
                        entity = new MDItemThumbRuleEntity();
                    }
                }
                
                return entity;
            }
        }

        #endregion Item Thumb Rule

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDUnit(ddlUnitID, true);
            MiscUtil.PopulateBDProjectOnlyBOQOrProjectCost(ddlProjectID, false);

            PrepareInitialViewItemDefault();
        }

        private void PrepareInitialViewItemDefault()
        {
            MiscUtil.PopulateMDBrand(ddlBrandID, false);
            MiscUtil.PopulateMDRegion(ddlRegionID, false);

            BuildSupplierByBrand();

            ddlBrandID.SelectedValue = MasterDataConstants.ItemDefaults.DEFAULT_BRAD.ToString();
            ddlSupplierID.SelectedValue = MasterDataConstants.ItemDefaults.DEFAULT_SUPPLIER.ToString();
            ddlRegionID.SelectedValue = MasterDataConstants.ItemDefaults.DEFAULT_REGION.ToString();

            BuildCountryDropdownByRegion();
            
        }

        private void BuildSupplierByBrand()
        {
            if (ddlBrandID != null && ddlBrandID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMSupplierByBrandID(ddlSupplierID, false, Int64.Parse(ddlBrandID.SelectedValue.ToString()));
            }
            else
            {
                ddlSupplierID.Items.Clear();
            }
        }

        private void BuildCountryDropdownByRegion()
        {
            if (ddlRegionID.SelectedValue != "0")
            {
                MiscUtil.PopulateMDCountryByRegionID(ddlCountryID, false, Int64.Parse(ddlRegionID.SelectedValue));
            }
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            BindPRMItemBrandMapList();

            txtItemName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;
            PrepareInitialViewItemThumbRule();

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareInitialViewItemThumbRule()
        {
            txtFloorRuleVariable.Text = "1.0";
            txtBasementRuleVariable.Text = "1.0";
            txtOverallRuleVariable.Text = "1.0";
            txtFloorQuantity.Text = "0";
            txtOverallQuantity.Text = "0";
            txtBasementQuantity.Text = "0";
        }

        private void BindPRMItemBrandMapList()
        {
            String sortExpression = SqlExpressionBuilder.PrepareSortExpression(MDBrandEntity.FLD_NAME_BrandName, SQLSortOrderType.Assending);
            IList<MDBrandEntity> ItemBrandList = FCCMDBrand.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
            _CurrentItemBrandList = ItemBrandList;
            chbxItemBrand.DataSource = ItemBrandList;
            chbxItemBrand.DataTextField = "BrandName";
            chbxItemBrand.DataValueField = "BrandID";
            chbxItemBrand.DataBind();
        }

        private void PrepareEditView()
        {
            MDItemEntity mDItemEntity = CurrentMDItemEntity;


            if (!mDItemEntity.IsNew)
            {
                #region Item

                txtItemName.Text = mDItemEntity.ItemName.ToString();

                if (ddlUnitID.Items.Count > 0 && mDItemEntity.UnitID != null)
                {
                    ddlUnitID.SelectedValue = mDItemEntity.UnitID.ToString();
                }

                txtDescription.Text = mDItemEntity.Description.ToString();
                chkIsRemoved.Checked = mDItemEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;

                #endregion

                #region Item Default

                MDItemDefaultEntity mDItemDefaultEntity = CurrentMDItemDefaultEntity;

                if (!mDItemDefaultEntity.IsNew)
                {
                    if (ddlBrandID.Items.Count > 0 && mDItemDefaultEntity.BrandID != null)
                    {
                        ddlBrandID.SelectedValue = mDItemDefaultEntity.BrandID.ToString();
                    }

                    BuildSupplierByBrand();

                    if (ddlSupplierID.Items.Count > 0 && mDItemDefaultEntity.SupplierID != null)
                    {
                        ddlSupplierID.SelectedValue = mDItemDefaultEntity.SupplierID.ToString();
                    }

                    if (ddlRegionID.Items.Count > 0 && mDItemDefaultEntity.RegionID != null)
                    {
                        ddlRegionID.SelectedValue = mDItemDefaultEntity.RegionID.ToString();
                    }

                    BuildCountryDropdownByRegion();

                    if (ddlCountryID.Items.Count > 0 && mDItemDefaultEntity.CountryID != null)
                    {
                        ddlCountryID.SelectedValue = mDItemDefaultEntity.CountryID.ToString();
                    }
                }
                else
                {
                    PrepareInitialViewItemDefault();
                }

                #endregion 

                #region Item Brand Map

                if (treeItem.SelectedNode.Depth == 2)
                {

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMItemBrandMapEntity.FLD_NAME_ItemID, treeItem.SelectedValue.ToString(), SQLMatchType.Equal);
                    IList<PRMItemBrandMapEntity> ItemBrandList = FCCPRMItemBrandMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                    _CurrentItemBrandMapList = ItemBrandList;

                    if (ItemBrandList != null && ItemBrandList.Count > 0)
                    {
                        foreach (PRMItemBrandMapEntity ent in ItemBrandList)
                        {
                            foreach (ListItem chbxItem in chbxItemBrand.Items)
                            {

                                if (ent.BrandID.ToString() == chbxItem.Value.ToString())
                                {
                                    chbxItem.Selected = true;
                                    break;
                                }
                            }
                        }
                        IList<PRMItemBrandMapEntity> TempitemBrandList = new List<PRMItemBrandMapEntity>();
                        if (_CurrentItemBrandMapList != null && _CurrentItemBrandMapList.Count > 0)
                        {
                            foreach (MDBrandEntity ent in _CurrentItemBrandList)
                            {
                                PRMItemBrandMapEntity mDItemBrandEntity = new PRMItemBrandMapEntity();
                                mDItemBrandEntity.BrandID = ent.BrandID;
                                TempitemBrandList.Add(mDItemBrandEntity);
                            }

                            IList<PRMItemBrandMapEntity> uncheckedList = TempitemBrandList.Except(_CurrentItemBrandMapList, new CustomerComparerAnother()).ToList();

                            if (uncheckedList != null && uncheckedList.Count > 0)
                            {
                                foreach (PRMItemBrandMapEntity ent in uncheckedList)
                                {
                                    foreach (ListItem chbxItem in chbxItemBrand.Items)
                                    {

                                        if (ent.BrandID.ToString() == chbxItem.Value.ToString())
                                        {
                                            chbxItem.Selected = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (ListItem chbxItem in chbxItemBrand.Items)
                        {
                            chbxItem.Selected = false;
                        }
                    }
                }

                #endregion

                #region Item Thumb Rule
               
                MDItemThumbRuleEntity mDItemThumbRuleEntity = CurrentMDItemThumbRuleEntity;

                if (!mDItemThumbRuleEntity.IsNew)
                {
                    txtFloorRuleVariable.Text = mDItemThumbRuleEntity.FloorRuleVariable.ToString();
                    txtFloorQuantity.Text = mDItemThumbRuleEntity.FloorQuantity.ToString();
                    txtBasementRuleVariable.Text = mDItemThumbRuleEntity.BasementRuleVariable.ToString();
                    txtBasementQuantity.Text = mDItemThumbRuleEntity.BasementQuantity.ToString();
                    txtOverallRuleVariable.Text = mDItemThumbRuleEntity.OverallRuleVariable.ToString();
                    txtOverallQuantity.Text = mDItemThumbRuleEntity.OverallQuantity.ToString();
                }
                else
                {
                    PrepareInitialViewItemThumbRule();
                }
                #endregion
            }
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;
                        
            if (treeItem.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Item Sub Category.", true);
            }
            else if (treeItem.SelectedNode.Depth != 1)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Item Sub Category.", true);
            }

            return validationResult;
        }

        private Boolean ValidateInput1()
        {
            Boolean validationResult = true;

            if (treeItem.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Item.", true);
            }
            else if (treeItem.SelectedNode.Depth != 2)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Item.", true);
            }

            return validationResult;
        }

        private Boolean CheckAvailablity()
        {
            Boolean flag = true;

            MDItemEntity mDItemEntity = CurrentMDItemEntity;

            if (mDItemEntity.IsNew)
            {
                if (txtItemName.Text.Trim() != "")
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemEntity.FLD_NAME_ItemName, txtItemName.Text.Trim(), SQLMatchType.Equal);
                    IList<MDItemEntity> itemList = FCCMDItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (itemList != null && itemList.Count > 0)
                    {
                        flag = false;
                        MiscUtil.ShowMessage(lblMessage, "Item Already Exists, Please Insert new one...", true);
                    }
                }
            }

            return flag;
        }

        private void LoadTreeView()
        {
            treeItem.ReBuildTree();
        }

        private MDItemEntity BuildMDItemEntity()
        {
            MDItemEntity mDItemEntity = CurrentMDItemEntity;

            if (treeItem.SelectedNode.Depth == 1)
            {
                mDItemEntity.ItemCategoryID = Int64.Parse(treeItem.SelectedValue.ToString());
            }

            mDItemEntity.ItemName = txtItemName.Text.Trim();
            if (ddlUnitID.Items.Count > 0)
            {
                if (ddlUnitID.SelectedValue == "0")
                {
                    mDItemEntity.UnitID = null;
                }
                else
                {
                    mDItemEntity.UnitID = Int64.Parse(ddlUnitID.SelectedValue);
                }
            }

            mDItemEntity.Description = txtDescription.Text.Trim();
            mDItemEntity.IsRemoved = chkIsRemoved.Checked;


            return mDItemEntity;
        }

        private MDItemDefaultEntity BuildMDItemDefaultEntity()
        {
            MDItemDefaultEntity mDItemDefaultEntity = CurrentMDItemDefaultEntity;

            if (ddlBrandID.Items.Count > 0)
            {
                if (ddlBrandID.SelectedValue == "0")
                {
                }
                else
                {
                    mDItemDefaultEntity.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                }
            }

            if (ddlSupplierID.Items.Count > 0)
            {
                if (ddlSupplierID.SelectedValue == "0")
                {
                }
                else
                {
                    mDItemDefaultEntity.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
                }
            }

            if (ddlRegionID.Items.Count > 0)
            {
                if (ddlRegionID.SelectedValue == "0")
                {
                }
                else
                {
                    mDItemDefaultEntity.RegionID = Int64.Parse(ddlRegionID.SelectedValue);
                }
            }

            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                }
                else
                {
                    mDItemDefaultEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }


            return mDItemDefaultEntity;
        }

        private MDItemThumbRuleEntity BuildMDItemThumbRuleEntity()
        {
            MDItemThumbRuleEntity mDItemThumbRuleEntity = CurrentMDItemThumbRuleEntity;


            if (!txtFloorRuleVariable.Text.Trim().IsNullOrEmpty())
            {
                mDItemThumbRuleEntity.FloorRuleVariable = Decimal.Parse(txtFloorRuleVariable.Text.Trim());
            }

            if (!txtFloorQuantity.Text.Trim().IsNullOrEmpty())
            {
                mDItemThumbRuleEntity.FloorQuantity = Decimal.Parse(txtFloorQuantity.Text.Trim());
            }

            if (!txtBasementRuleVariable.Text.Trim().IsNullOrEmpty())
            {
                mDItemThumbRuleEntity.BasementRuleVariable = Decimal.Parse(txtBasementRuleVariable.Text.Trim());
            }

            if (!txtBasementQuantity.Text.Trim().IsNullOrEmpty())
            {
                mDItemThumbRuleEntity.BasementQuantity = Decimal.Parse(txtBasementQuantity.Text.Trim());
            }

            if (!txtOverallRuleVariable.Text.Trim().IsNullOrEmpty())
            {
                mDItemThumbRuleEntity.OverallRuleVariable = Decimal.Parse(txtOverallRuleVariable.Text.Trim());
            }

            if (!txtOverallQuantity.Text.Trim().IsNullOrEmpty())
            {
                mDItemThumbRuleEntity.OverallQuantity = Decimal.Parse(txtOverallQuantity.Text.Trim());
            }


            return mDItemThumbRuleEntity;
        }

        private void SaveMDItemEntity()
        {
            if (IsValid)
            {
                try
                {
                    Boolean addInputValidation = true;

                    MDItemEntity mDItemEntity = BuildMDItemEntity();

                    Int64 result = -1;

                    if (mDItemEntity.IsNew)
                    {
                        if (ValidateInput())
                        {
                            if (treeItem.SelectedNode != null)
                            {
                                mDItemEntity.ItemCategoryID = Int64.Parse(treeItem.SelectedValue);
                            }

                            result = FCCMDItem.GetFacadeCreate().Add(mDItemEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                        else
                        {
                            addInputValidation = false;
                        }
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDItemEntity.FLD_NAME_ItemID, mDItemEntity.ItemID.ToString(), SQLMatchType.Equal);
                        result = FCCMDItem.GetFacadeCreate().Update(mDItemEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (addInputValidation == true)
                    {
                        if (result > 0)
                        {
                            #region Item Brand Map

                            ViewState["LastUpdatedItemID"] = result;
                            
                            try
                            {
                                IList<PRMItemBrandMapEntity> newMappedItems = new List<PRMItemBrandMapEntity>();

                                foreach (ListItem chbxItem in chbxItemBrand.Items)
                                {
                                    if (chbxItem.Selected)
                                    {
                                        PRMItemBrandMapEntity mDItemBrandMapEntity = new PRMItemBrandMapEntity();
                                        mDItemBrandMapEntity.ItemID = result;
                                        mDItemBrandMapEntity.BrandID = Int64.Parse(chbxItem.Value.ToString());
                                        newMappedItems.Add(mDItemBrandMapEntity);
                                    }
                                }

                                IList<PRMItemBrandMapEntity> deleteList = _CurrentItemBrandMapList.Except(newMappedItems, new CustomerComparer()).ToList();
                                IList<PRMItemBrandMapEntity> addNewList = newMappedItems.Except(_CurrentItemBrandMapList, new CustomerComparer()).ToList();

                                if (deleteList != null && deleteList.Count > 0)
                                {
                                    foreach (PRMItemBrandMapEntity ent in deleteList)
                                    {
                                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMItemBrandMapEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
                                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMItemBrandMapEntity.FLD_NAME_BrandID, ent.BrandID.ToString(), SQLMatchType.Equal);
                                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                                        FCCPRMItemBrandMap.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                                    }
                                }

                                if (addNewList != null && addNewList.Count > 0)
                                {
                                    foreach (PRMItemBrandMapEntity ent in addNewList)
                                    {
                                        FCCPRMItemBrandMap.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                                    }
                                }

                                String feCurrent = SqlExpressionBuilder.PrepareFilterExpression(PRMItemBrandMapEntity.FLD_NAME_ItemID, result.ToString(), SQLMatchType.Equal);
                                IList<PRMItemBrandMapEntity> ItemBrandList = FCCPRMItemBrandMap.GetFacadeCreate().GetIL(null, null, String.Empty, feCurrent, DatabaseOperationType.LoadWithFilterExpression);
                                _CurrentItemBrandMapList = ItemBrandList;

                                if (ddlBrandID.Items.Count > 0 && ddlBrandID.SelectedValue != MasterDataConstants.ItemDefaults.DEFAULT_BRAD.ToString())
                                {
                                    Boolean isNeedToInsert = false;

                                    if (ItemBrandList != null && ItemBrandList.Count > 0)
                                    {
                                        PRMItemBrandMapEntity itemBrandInfo = (from s in ItemBrandList
                                                                               where s.BrandID.ToString() == ddlBrandID.SelectedValue
                                                                               select s).FirstOrDefault();
                                        if (itemBrandInfo == null)
                                        {
                                            isNeedToInsert = true;
                                        }
                                    }
                                    else
                                    {
                                        isNeedToInsert = true;
                                    }

                                    if (isNeedToInsert)
                                    {
                                        PRMItemBrandMapEntity pRMItemBrandMapEntity = new PRMItemBrandMapEntity();
                                        pRMItemBrandMapEntity.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                                        pRMItemBrandMapEntity.ItemID = result;

                                        FCCPRMItemBrandMap.GetFacadeCreate().Add(pRMItemBrandMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                            }


                            #endregion

                            #region Item Defaults

                            MDItemDefaultEntity mDItemDefaultEntity = BuildMDItemDefaultEntity();

                            mDItemDefaultEntity.ItemID = result;
                            
                            if (mDItemDefaultEntity.IsNew)
                            {
                                FCCMDItemDefault.GetFacadeCreate().Add(mDItemDefaultEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            }
                            else
                            {
                                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDItemDefaultEntity.FLD_NAME_ItemDefaultID, mDItemDefaultEntity.ItemDefaultID.ToString(), SQLMatchType.Equal);
                                FCCMDItemDefault.GetFacadeCreate().Update(mDItemDefaultEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                            }

                            #endregion

                            //#region Item Thumb Rule

                            //MDItemThumbRuleEntity mDItemThumbRuleEntity = BuildMDItemThumbRuleEntity();

                            //mDItemThumbRuleEntity.ItemID = result;

                            //if (mDItemThumbRuleEntity.IsNew)
                            //{
                            //    result = FCCMDItemThumbRule.GetFacadeCreate().Add(mDItemThumbRuleEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            //}
                            //else
                            //{
                            //    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDItemThumbRuleEntity.FLD_NAME_MDItemThumbRuleID, mDItemThumbRuleEntity.MDItemThumbRuleID.ToString(), SQLMatchType.Equal);
                            //    result = FCCMDItemThumbRule.GetFacadeCreate().Update(mDItemThumbRuleEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                            //}

                            //#endregion

                            //if (mDItemEntity.IsNew)
                            //{
                            //    if (Roles.IsUserInRole(this.Page.User.Identity.Name, "Admin") == true || Roles.IsUserInRole(this.Page.User.Identity.Name, "Engineer") || Roles.IsUserInRole(this.Page.User.Identity.Name, "MIS") == true)
                            //    {
                            //        lblItemName.Text = mDItemEntity.ItemName.ToString();
                            //        this.Panel2_ModalPopupExtender.Show();
                            //    }
                            //}

                            _ItemID = 0;
                            _MDItemEntity = new MDItemEntity();

                            // clearing cache
                            FCCMDItem.GetFacadeCreate().RemoveCache();

                            PrepareInitialView();

                            LoadTreeView();

                            if (mDItemEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Item Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Item Information has been updated successfully.", false);
                            }
                        }
                        else
                        {
                            if (mDItemEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Item Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Item Information.", false);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void EditItem()
        {
            Int64 ItemID;

            Int64.TryParse(treeItem.SelectedValue, out ItemID);

            if (ItemID > 0)
            {
                _ItemID = ItemID;

                PrepareEditView();
            }
        }

        private void DeleteItem()
        {
            Int64 ItemID;

            Int64.TryParse(treeItem.SelectedValue, out ItemID);

            if (ItemID > 0)
            {
                try
                {
                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemEntity.FLD_NAME_ItemID, ItemID.ToString(), SQLMatchType.Equal);

                    MDItemEntity mDItemEntity = new MDItemEntity();

                    #region Item Brand Map

                    String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMItemBrandMapEntity.FLD_NAME_ItemID, ItemID.ToString(), SQLMatchType.Equal);
                    PRMItemBrandMapEntity prmItemBrandMap = new PRMItemBrandMapEntity();
                    FCCPRMItemBrandMap.GetFacadeCreate().Delete(prmItemBrandMap, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                    #endregion

                    #region Item Default 

                    String fe2 = SqlExpressionBuilder.PrepareFilterExpression(MDItemDefaultEntity.FLD_NAME_ItemID, ItemID.ToString(), SQLMatchType.Equal);
                    MDItemDefaultEntity mDItemDefaultEntity = new MDItemDefaultEntity();
                    FCCMDItemDefault.GetFacadeCreate().Delete(mDItemDefaultEntity, fe2, DatabaseOperationType.Delete, TransactionRequired.No);

                    #endregion

                    #region Item Thumb Rule

                    String fe3 = SqlExpressionBuilder.PrepareFilterExpression(MDItemThumbRuleEntity.FLD_NAME_ItemID, ItemID.ToString(), SQLMatchType.Equal);
                    MDItemThumbRuleEntity mDItemThumbRuleEntity = new MDItemThumbRuleEntity();
                    result = FCCMDItemThumbRule.GetFacadeCreate().Delete(mDItemThumbRuleEntity, fe3, DatabaseOperationType.Delete, TransactionRequired.No);

                    #endregion

                    result = FCCMDItem.GetFacadeCreate().Delete(mDItemEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                    if (result == 0)
                    {
                        _ItemID = 0;
                        _MDItemEntity = new MDItemEntity();

                        // clearing cache
                        FCCMDItem.GetFacadeCreate().RemoveCache();

                        PrepareInitialView();

                        LoadTreeView();

                        MiscUtil.ShowMessage(lblMessage, "Item has been successfully deleted.", true);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to delete Item.", true);
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckAvailablity())
            {
                SaveMDItemEntity();
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ItemID = 0;
            _MDItemEntity = new MDItemEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            Boolean isAvailable = CheckAvailablity();

            if (!isAvailable)
            {
                MiscUtil.ShowMessage(lblMessage, "Item Already Exists, Please Insert new one...", true);
                //Should implement Here.
            }
            else
            {
                if (txtItemName.Text.Trim().IsNullOrEmpty())
                {
                    MiscUtil.ShowMessage(lblMessage, "Please Write Something..", false);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Item Free.", false);
                }
            }
        }

        protected void lnkBtnEditItemCategory_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                EditItem();
            }
        }

        protected void lnkBtnAdvanceSearch_Click(object sender, EventArgs e)
        {
            String navUrl = UrlHelper.BuildSecureUrl("~/Common/CMNAdvanceSearch.aspx", string.Empty, "do", AdvanceSearchConstants.SearchConstants.ITEM_ADVANCE_SEARCH, "EntityName",AdvanceSearchConstants.EntityConstants.ITEM_CUSTOM_ENTITY).ToString();
            Helper.Response.Redirect(navUrl);
        }

        protected void lnkBtnremoveItemCategory_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                DeleteItem();
            }
        }

        protected void btnAddToProject_Click(object sender, EventArgs e)
        {
            if (ddlProjectID.Items.Count > 0 && ddlProjectID.SelectedValue != "0")
            {
                Int64 itemID = 0;
                if (ViewState["LastUpdatedItemID"] != null)
                {
                    itemID = (Int64)ViewState["LastUpdatedItemID"];
                }

                if (itemID > 0)
                {
                    String fe_itemDefault = SqlExpressionBuilder.PrepareFilterExpression(MDItemDefaultEntity.FLD_NAME_ItemID, itemID.ToString(), SQLMatchType.Equal);
                    IList<MDItemDefaultEntity> lstmDItemDefaultEntity = FCCMDItemDefault.GetFacadeCreate().GetIL(null, null, String.Empty, fe_itemDefault, DatabaseOperationType.LoadWithFilterExpression);

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                    IList<PRMPreBOQEntity> preBOQList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (preBOQList != null && preBOQList.Count > 0)
                    {
                        Int64 preBOQID = preBOQList[0].PreBOQID;
                        Decimal totalQty = 0;
                        Decimal.TryParse(txtQty.Text.Trim().ToString(),out totalQty);
                        Decimal currentPrice = MiscUtil.GetCurrentPrice(itemID, lstmDItemDefaultEntity[0].BrandID, lstmDItemDefaultEntity[0].SupplierID, lstmDItemDefaultEntity[0].RegionID, lstmDItemDefaultEntity[0].CountryID); 

                        switch (preBOQList[0].IsLocked)
                        {

                            case true:
                                #region Add Item to BOQ

                                try
                                {
                                    String fe_boq = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                                    IList<PRMBOQEntity> lstPRMBOQ = FCCPRMBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe_boq, DatabaseOperationType.LoadWithFilterExpression);

                                    if (lstPRMBOQ != null && lstPRMBOQ.Count > 0)
                                    {
                                        PRMBOQDetailEntity pRMBOQDeatEntity = new PRMBOQDetailEntity();
                                        pRMBOQDeatEntity.BOQID = lstPRMBOQ[0].BOQID;
                                        pRMBOQDeatEntity.ItemID = itemID;
                                        pRMBOQDeatEntity.BrandID=lstmDItemDefaultEntity[0].BrandID;
                                        pRMBOQDeatEntity.RegionID=lstmDItemDefaultEntity[0].RegionID;
                                        pRMBOQDeatEntity.CountryID=lstmDItemDefaultEntity[0].CountryID;
                                        pRMBOQDeatEntity.SupplierID=lstmDItemDefaultEntity[0].SupplierID;
                                        pRMBOQDeatEntity.Remarks = "Directly Added From Item";
                                        pRMBOQDeatEntity.IsRemoved = false;
                                        pRMBOQDeatEntity.Rate = currentPrice;
                                        pRMBOQDeatEntity.EntryDate = System.DateTime.Now;
                                        pRMBOQDeatEntity.TotalQty =totalQty;

                                        Int64 result_boq = -1;

                                        result_boq = FCCPRMBOQDetail.GetFacadeCreate().Add(pRMBOQDeatEntity, DatabaseOperationType.Add, TransactionRequired.No);

                                        if (result_boq > 0)
                                        {
                                            PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity = new PRMAvailableBOQQtyForRequisitionEntity();

                                            pRMAvailableBOQQtyForRequisitionEntity.IsBOQ = true;
                                            pRMAvailableBOQQtyForRequisitionEntity.PreBOQOrBOQDetailID = result_boq;
                                            pRMAvailableBOQQtyForRequisitionEntity.ItemID = itemID;
                                            pRMAvailableBOQQtyForRequisitionEntity.Qty = totalQty;
                                            pRMAvailableBOQQtyForRequisitionEntity.CreateDate = DateTime.Now;
                                            pRMAvailableBOQQtyForRequisitionEntity.CreatedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                                            pRMAvailableBOQQtyForRequisitionEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);


                                            Int64 result_available = -1;
                                            result_available = FCCPRMAvailableBOQQtyForRequisition.GetFacadeCreate().Add(pRMAvailableBOQQtyForRequisitionEntity, DatabaseOperationType.Add, TransactionRequired.No);

                                            MiscUtil.ShowMessage(lblMessage, "Qty Added Successfully to Project Cost.", false);
                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    MiscUtil.ShowMessage(lblMessage, "Some Error Occured.", true);
                                }

                                #endregion

                                break;

                            case false:

                                #region Add Item to Pre-BOQ

                                try
                                {
                                    String fe_preBOQ = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                                    IList<PRMPreBOQEntity> lstPRMPreBOQ = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe_preBOQ, DatabaseOperationType.LoadWithFilterExpression);

                                    if (lstPRMPreBOQ != null && lstPRMPreBOQ.Count > 0)
                                    {
                                        PRMPreBOQDetailEntity pRMPreBOQDeatEntity = new PRMPreBOQDetailEntity();
                                        pRMPreBOQDeatEntity.PreBOQID = lstPRMPreBOQ[0].PreBOQID;
                                        pRMPreBOQDeatEntity.ItemID = itemID;
                                        pRMPreBOQDeatEntity.BrandID = lstmDItemDefaultEntity[0].BrandID;
                                        pRMPreBOQDeatEntity.RegionID = lstmDItemDefaultEntity[0].RegionID;
                                        pRMPreBOQDeatEntity.CountryID = lstmDItemDefaultEntity[0].CountryID;
                                        pRMPreBOQDeatEntity.SupplierID = lstmDItemDefaultEntity[0].SupplierID;
                                        pRMPreBOQDeatEntity.TotalQty = totalQty;
                                        pRMPreBOQDeatEntity.Remarks = "Directly Added From Item";
                                        pRMPreBOQDeatEntity.IsRemoved = false;
                                        pRMPreBOQDeatEntity.Rate = currentPrice;
                                        pRMPreBOQDeatEntity.EntryDate = System.DateTime.Now;

                                        Int64 result_preboq = -1;

                                        result_preboq = FCCPRMPreBOQDetail.GetFacadeCreate().Add(pRMPreBOQDeatEntity, DatabaseOperationType.Add, TransactionRequired.No);

                                        if (result_preboq > 0)
                                        {
                                            PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity = new PRMAvailableBOQQtyForRequisitionEntity();

                                            pRMAvailableBOQQtyForRequisitionEntity.IsBOQ = false;
                                            pRMAvailableBOQQtyForRequisitionEntity.PreBOQOrBOQDetailID = result_preboq;
                                            pRMAvailableBOQQtyForRequisitionEntity.ItemID = itemID;
                                            pRMAvailableBOQQtyForRequisitionEntity.Qty = totalQty;
                                            pRMAvailableBOQQtyForRequisitionEntity.CreateDate = DateTime.Now;
                                            pRMAvailableBOQQtyForRequisitionEntity.CreatedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                                            pRMAvailableBOQQtyForRequisitionEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);

                                            Int64 result_available = -1;
                                            result_available = FCCPRMAvailableBOQQtyForRequisition.GetFacadeCreate().Add(pRMAvailableBOQQtyForRequisitionEntity, DatabaseOperationType.Add, TransactionRequired.No);

                                            MiscUtil.ShowMessage(lblMessage, "Qty Added Successfully to BOQ.", false);
                                        }
                                    }

                                }
                                catch (Exception)
                                {
                                    MiscUtil.ShowMessage(lblMessage, "Some Error Occured.", true);
                                }

                                #endregion

                                break;

                            default:
                                break;
                        }
                    }
                }
            }
        }
        
        #endregion

        #region Dropdown Event

        protected void ddlRegionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildCountryDropdownByRegion();
        }

        protected void ddlBrandID_SelectedIndexChanged(object sender, EventArgs e)
        {  
            BuildSupplierByBrand();

            if (ddlBrandID.SelectedValue != MasterDataConstants.ItemDefaults.DEFAULT_BRAD.ToString())
            {
                foreach (ListItem chbxItem in chbxItemBrand.Items)
                {
                    if (chbxItem.Value == ddlBrandID.SelectedValue)
                    {
                        chbxItem.Selected = true;
                        break;
                    }
                }
            }
        }

        #endregion

        #endregion Event
    }
}
