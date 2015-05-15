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
using System.Text;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class PRMPreBOQSetupControl : ProjectBaseControl
    {
        #region Extra

        class CustomerComparer : IEqualityComparer<PRMPreBOQDetailEntity>
        {
            public bool Equals(PRMPreBOQDetailEntity x, PRMPreBOQDetailEntity y)
            {
                return (x.ItemID.Equals(y.ItemID));
            }

            public int GetHashCode(PRMPreBOQDetailEntity obj)
            {
                return obj.ItemID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Boolean isNewEntry
        {
            get
            {
                return (Boolean)ViewState["vs_isNewEntry"];
            }
            set
            {
                ViewState["vs_isNewEntry"] = value;
            }
        }

        public String SelectAction
        {
            get
            {
                return (String)ViewState["vs_SelectAction"];
            }
            set
            {
                ViewState["vs_SelectAction"] = value;
            }
        }

        public PRMPreBOQEntity currentPreBOQ
        {
            get
            {
                return (PRMPreBOQEntity)ViewState["vs_currentPreBOQ"];
            }
            set
            {
                ViewState["vs_currentPreBOQ"] = value;
            }
        }

        public IList<PRMPreBOQDetailEntity> currentlyCheckedItems
        {
            get
            {
                return (IList<PRMPreBOQDetailEntity>)ViewState["vs_currentlyCheckedItems"];
            }
            set
            {
                ViewState["vs_currentlyCheckedItems"] = value;
            }
        }

        public IList<PRMPreBOQDetailEntity> mappedItemsFromDB
        {
            get
            {
                return (IList<PRMPreBOQDetailEntity>)ViewState["vs_mappedItemsFromDB"];
            }
            set
            {
                ViewState["vs_mappedItemsFromDB"] = value;
            }
        }
        
        public IList<PRMPreBOQDetailEntity> populatedItems
        {
            get
            {
                return (IList<PRMPreBOQDetailEntity>)ViewState["vs_populatedItems"];
            }
            set
            {
                ViewState["vs_populatedItems"] = value;
            }
        }

        public IList<PRMPreBOQDetailEntity> populatedCheckedItems
        {
            get
            {
                return (IList<PRMPreBOQDetailEntity>)ViewState["vs_populatedCheckedItems"];
            }
            set
            {
                ViewState["vs_populatedCheckedItems"] = value;
            }
        }

        public IList<PRMSupplierItemMapEntity> supplierItemMapList
        {
            get
            {
                IList<PRMSupplierItemMapEntity> _prmSupplierItmeMapList = null;

                if (ViewState["vs_supplierItemMapList"] != null)
                {
                    _prmSupplierItmeMapList = (List<PRMSupplierItemMapEntity>)ViewState["vs_supplierItemMapList"];
                }
                else
                {
                    _prmSupplierItmeMapList = FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
                }

                return _prmSupplierItmeMapList;
            }
            set
            {
                ViewState["vs_supplierItemMapList"] = value;
            }
        }
        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulatePRMPreBOQTemplate(ddlPreBOQTemplateID, true);
        }

        private void PrepareFormView()
        {
            populatedItems = new List<PRMPreBOQDetailEntity>();
            populatedCheckedItems = new List<PRMPreBOQDetailEntity>();

            BuildDropDownList();

            #region New or Update mode decission making

            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);

            IList<PRMPreBOQEntity> lst = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lst != null && lst.Count > 0)
            {
                isNewEntry = false;
                currentPreBOQ = lst[0];
            }
            else
            {
                isNewEntry = true;
                currentPreBOQ = null;
            }

            #endregion

            currentlyCheckedItems = new List<PRMPreBOQDetailEntity>();
            mappedItemsFromDB = new List<PRMPreBOQDetailEntity>();

            #region Determine Current Mapped & Checked Items

            if (isNewEntry == true)
            {
                IList<MDItemEntity> itemList = FCCMDItem.GetFacadeCreate().GetILFC();

                if (itemList != null && itemList.Count > 0)
                {
                    foreach (MDItemEntity item in itemList)
                    {
                        PRMPreBOQDetailEntity ent = new PRMPreBOQDetailEntity();

                        ent.ItemID = item.ItemID;

                        currentlyCheckedItems.Add(ent);
                    }
                }                
            }
            else
            {
                String fe_PreBOQDetail = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, currentPreBOQ.PreBOQID.ToString(), SQLMatchType.Equal);

                mappedItemsFromDB = FCCPRMPreBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_PreBOQDetail, DatabaseOperationType.LoadWithFilterExpression);

                if (mappedItemsFromDB == null)
                {
                    mappedItemsFromDB = new List<PRMPreBOQDetailEntity>();
                }
                
                currentlyCheckedItems = mappedItemsFromDB;
            }

            #endregion

            if (isNewEntry == true)
            {
                FormLock(false);
            }
            else
            {
                FormLock(currentPreBOQ.IsLocked);
            }
          
        }

        private void PrepareInitialView()
        {
            chbxImportInfoList.Items.Add(CommonConstants.IMPORT_RATE_INFO);
            chbxImportInfoList.Items.Add(CommonConstants.IMPORT_QTY_INFO);
        }

        private void FormLock(Boolean isLocked)
        {
            #region Form Lock

            if (isLocked == true)
            {
                btnSubmit.Enabled = false;
                lblFormLock.Visible = true;
            }
            else
            {
                btnSubmit.Enabled = true;
                lblFormLock.Visible = false;
            }

            #endregion Form Lock
        }
                
        private PRMPreBOQEntity BuildPRMPreBOQEntity()
        {
            PRMPreBOQEntity PRMpreBOQEntity = new PRMPreBOQEntity();
            
            PRMpreBOQEntity.ProjectID = OverviewProjectID;
            PRMpreBOQEntity.StartDate = System.DateTime.Now;
            PRMpreBOQEntity.PreparedByMemberID = 1;
            PRMpreBOQEntity.PreBOQStatusID = 1;

            return PRMpreBOQEntity;
        }

        private void IsItemNode(TreeNode tn)
        {

            if (tn.Depth == 1)
            {
                foreach (TreeNode n in tn.ChildNodes)
                {
                    Int64 itemID = Int64.Parse(n.Value.ToString());
                    var tempItem = from s in currentlyCheckedItems
                                   where s.ItemID == itemID
                                   select s;

                    if (tempItem != null && tempItem.Count() > 0)
                    {
                        n.Checked = true;

                        #region Storing the populated checked nodes

                        PRMPreBOQDetailEntity ent1 = new PRMPreBOQDetailEntity();
                        ent1.ItemID = Int64.Parse(n.Value.ToString());
                        populatedCheckedItems.Add(ent1);

                        #endregion
                    }
                    else
                    {
                        n.Checked = false;
                    }

                    switch (SelectAction)
                    {
                        case "SelectAll":
                            n.Checked = true;
                            break;
                        case "DeselectAll":
                            n.Checked = false;
                            break;
                    }

                    #region Storing the populated nodes

                    PRMPreBOQDetailEntity ent = new PRMPreBOQDetailEntity();
                    ent.ItemID = Int64.Parse(n.Value.ToString());
                    populatedItems.Add(ent);

                    #endregion
                }
            }

        }

        private void SavePreBOQDetailInfo()
        {
            try
            {
                #region Getting the checked items from tree

                IList<PRMPreBOQDetailEntity> checkedItemsFromTree = new List<PRMPreBOQDetailEntity>();

                foreach (TreeNode tn in treeItem.CheckedNodes)
                {
                    PRMPreBOQDetailEntity ent = new PRMPreBOQDetailEntity();
                    ent.ItemID = Int64.Parse(tn.Value.ToString());
                    
                    checkedItemsFromTree.Add(ent);
                }

                #endregion 

                Int64 preBOQID = 0;

                if (isNewEntry == true)
                {
                    preBOQID = FCCPRMPreBOQ.GetFacadeCreate().Add(BuildPRMPreBOQEntity(), DatabaseOperationType.Add, TransactionRequired.No);                    
                }
                else
                {
                    preBOQID = currentPreBOQ.PreBOQID;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, preBOQID.ToString(),SQLMatchType.Equal);

                  //  FCCPRMPreBOQDetail.GetFacadeCreate().Delete(new PRMPreBOQDetailEntity(), fe, DatabaseOperationType.Delete, TransactionRequired.No);
                }


                #region Adding OLD

                //IList<PRMPreBOQDetailEntity> addListOfNotPopulatedItems = currentlyCheckedItems.Except(populatedItems, new CustomerComparer()).ToList();

                //StringBuilder xmlStr = new StringBuilder();
                //String subXmlStr = String.Empty;

                //xmlStr.Append("<m>");

                //foreach (PRMPreBOQDetailEntity ent in addListOfNotPopulatedItems)
                //{
                //    subXmlStr = subXmlStr + "<i><a>" + preBOQID + "</a><b>" + ent.ItemID + "</b></i>";
                //}

                //foreach (PRMPreBOQDetailEntity ent in checkedItemsFromTree)
                //{
                //    subXmlStr = subXmlStr + "<i><a>" + preBOQID + "</a><b>" + ent.ItemID + "</b></i>";
                //}

                //xmlStr.Append(subXmlStr.ToString());
                //xmlStr.Append("</m>");


                //FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.PreBOQDetailTableInfo);

                #endregion OLD

                #region Adding New

                IList<PRMPreBOQDetailEntity> addListOfNotPopulatedItems = currentlyCheckedItems.Except(populatedItems, new CustomerComparer()).ToList();

                IList<PRMPreBOQDetailEntity> completeAddList = new List<PRMPreBOQDetailEntity>();
                completeAddList = addListOfNotPopulatedItems;

                foreach (PRMPreBOQDetailEntity ent in checkedItemsFromTree)
                {
                    completeAddList.Add(ent);
                }

                IList<PRMPreBOQDetailEntity> finalAddList = completeAddList.Except(mappedItemsFromDB, new CustomerComparer()).ToList();
                IList<PRMPreBOQDetailEntity> finalDeleteList = mappedItemsFromDB.Except(completeAddList, new CustomerComparer()).ToList();

                if (finalAddList != null && finalAddList.Count > 0)
                {
                    StringBuilder xmlStr = new StringBuilder();
                    String subXmlStr = String.Empty;
                    xmlStr.Append("<m>");

                    foreach (PRMPreBOQDetailEntity ent in finalAddList)
                    {
                        #region SET Item Rate and Qty OLD

                        #region Get and Assign Item Price
                        ////Collect Item Actual Price with Default Brand, Vendor, Region, Country ID.
                        //Decimal ActualPrice=0;
                        //Int64 BrandID=MasterDataConstants.ItemDefaults.DEFAULT_BRAD;
                        //Int64 SupplierID=MasterDataConstants.ItemDefaults.DEFAULT_SUPPLIER;
                        //Int64 RegionID=MasterDataConstants.ItemDefaults.DEFAULT_REGION;
                        //Int64 CountryID= MasterDataConstants.ItemDefaults.DEFAULT_COUNTRY;

                        //String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemDefaultEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
                        //IList<MDItemDefaultEntity> itemDefaultList = FCCMDItemDefault.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                        //if (itemDefaultList != null && itemDefaultList.Count > 0)
                        //{
                        //    Int64.TryParse(itemDefaultList[0].BrandID.ToString(),out BrandID);
                        //    Int64.TryParse(itemDefaultList[0].SupplierID.ToString(), out SupplierID);
                        //    Int64.TryParse(itemDefaultList[0].RegionID.ToString(), out RegionID);
                        //    Int64.TryParse(itemDefaultList[0].CountryID.ToString(), out CountryID);
                        //}

                        //var supplierItemMap = (from s in supplierItemMapList
                        //                       where s.ItemID == ent.ItemID
                        //                       && s.BrandID == BrandID
                        //                       && s.SupplierID == SupplierID
                        //                       && s.OriginRegionID == RegionID
                        //                       && s.OriginCountryID == CountryID
                        //                       select s).ToList();

                        //if (supplierItemMap != null && supplierItemMap.Count > 0)
                        //{
                        //    Decimal.TryParse(supplierItemMap[0].Price.ToString(), out ActualPrice);
                        //}
                       
                        #endregion

                        #region Thumb Rules
                        ////Collect Total Qty From Thumb Rules
                        //Decimal totalQty = 0;

                        //String feThumbRule = SqlExpressionBuilder.PrepareFilterExpression(MDItemThumbRuleEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
                        //IList<MDItemThumbRuleEntity> itemThumbRuleList = FCCMDItemThumbRule.GetFacadeCreate().GetIL(null, null, String.Empty, feThumbRule, DatabaseOperationType.LoadWithFilterExpression);

                        //if (itemThumbRuleList != null && itemThumbRuleList.Count > 0)
                        //{
                        //    totalQty += itemThumbRuleList[0].FloorQuantity * itemThumbRuleList[0].FloorRuleVariable * this.OverviewProject.LandAreaSft.Value * this.OverviewProject.NoOfStoried.Value;
                        //    totalQty += itemThumbRuleList[0].BasementQuantity * itemThumbRuleList[0].BasementRuleVariable * this.OverviewProject.LandAreaSft.Value * this.OverviewProject.NoOfBasement.Value;
                        //    totalQty += itemThumbRuleList[0].OverallQuantity * itemThumbRuleList[0].OverallRuleVariable * this.OverviewProject.LandAreaSft.Value;                                                       
                        //}
                        
                        #endregion

                        #endregion

                        #region SET Item Rate and Qty

                        //GET Item Actual Price From Pre-BOQ or Set Zero

                        Decimal actualPrice = 0;
                        Decimal totalQty = 0;

                        Boolean importPriceFlag = false, importQtyFlag = false;

                        foreach (ListItem chbxItem in chbxImportInfoList.Items)
                        {
                            if (chbxItem.Selected == true && chbxItem.Text == CommonConstants.IMPORT_RATE_INFO)
                            {
                                importPriceFlag = true;
                            }

                            if (chbxItem.Selected == true && chbxItem.Text == CommonConstants.IMPORT_QTY_INFO)
                            {
                                importQtyFlag = true;
                            }

                         }
                            Int64 BrandID = MasterDataConstants.ItemDefaults.DEFAULT_BRAD;
                            Int64 SupplierID = MasterDataConstants.ItemDefaults.DEFAULT_SUPPLIER;
                            Int64 RegionID = MasterDataConstants.ItemDefaults.DEFAULT_REGION;
                            Int64 CountryID = MasterDataConstants.ItemDefaults.DEFAULT_COUNTRY;

                            IList<PRMPreBOQDetailEntity> _pRMPreBOQDeatilEntity = (from s in mappedItemsFromDB
                                                                                   where s.ItemID == ent.ItemID
                                                                                   select s).ToList();
                            if (importPriceFlag)
                            {

                                if (_pRMPreBOQDeatilEntity != null && _pRMPreBOQDeatilEntity.Count > 0 && _pRMPreBOQDeatilEntity[0].Rate > 0)
                                {
                                    Int64.TryParse(_pRMPreBOQDeatilEntity[0].BrandID.ToString(), out BrandID);
                                    Int64.TryParse(_pRMPreBOQDeatilEntity[0].SupplierID.ToString(), out SupplierID);
                                    Int64.TryParse(_pRMPreBOQDeatilEntity[0].RegionID.ToString(), out RegionID);
                                    Int64.TryParse(_pRMPreBOQDeatilEntity[0].CountryID.ToString(), out CountryID);
                                    Decimal.TryParse(_pRMPreBOQDeatilEntity[0].Rate.ToString(), out actualPrice);
                                }

                                else
                                {

                                    #region SET Rate From Price Database

                                    String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemDefaultEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
                                    IList<MDItemDefaultEntity> itemDefaultList = FCCMDItemDefault.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                                    if (itemDefaultList != null && itemDefaultList.Count > 0)
                                    {
                                        Int64.TryParse(itemDefaultList[0].BrandID.ToString(), out BrandID);
                                        Int64.TryParse(itemDefaultList[0].SupplierID.ToString(), out SupplierID);
                                        Int64.TryParse(itemDefaultList[0].RegionID.ToString(), out RegionID);
                                        Int64.TryParse(itemDefaultList[0].CountryID.ToString(), out CountryID);
                                    }

                                    var supplierItemMap = (from s in supplierItemMapList
                                                           where s.ItemID == ent.ItemID
                                                           && s.BrandID == BrandID
                                                           && s.SupplierID == SupplierID
                                                           && s.OriginRegionID == RegionID
                                                           && s.OriginCountryID == CountryID
                                                           select s).ToList();

                                    if (supplierItemMap != null && supplierItemMap.Count > 0)
                                    {
                                        Decimal.TryParse(supplierItemMap[0].Price.ToString(), out actualPrice);
                                    }

                                    #endregion
                                }

                            }

                            if (importQtyFlag)
                            {
                                if (_pRMPreBOQDeatilEntity != null && _pRMPreBOQDeatilEntity.Count > 0 && _pRMPreBOQDeatilEntity[0].TotalQty > 0)
                                {
                                    Decimal.TryParse(_pRMPreBOQDeatilEntity[0].TotalQty.ToString(), out totalQty);
                                }


                                else
                                {
                                    #region GET Qty From ThumbRule

                                    String feThumbRule = SqlExpressionBuilder.PrepareFilterExpression(MDItemThumbRuleEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
                                    IList<MDItemThumbRuleEntity> itemThumbRuleList = FCCMDItemThumbRule.GetFacadeCreate().GetIL(null, null, String.Empty, feThumbRule, DatabaseOperationType.LoadWithFilterExpression);

                                    if (itemThumbRuleList != null && itemThumbRuleList.Count > 0)
                                    {
                                        totalQty += itemThumbRuleList[0].FloorQuantity * itemThumbRuleList[0].FloorRuleVariable * this.OverviewProject.LandAreaSft.Value * this.OverviewProject.NoOfStoried.Value;
                                        totalQty += itemThumbRuleList[0].BasementQuantity * itemThumbRuleList[0].BasementRuleVariable * this.OverviewProject.LandAreaSft.Value * this.OverviewProject.NoOfBasement.Value;
                                        totalQty += itemThumbRuleList[0].OverallQuantity * itemThumbRuleList[0].OverallRuleVariable * this.OverviewProject.LandAreaSft.Value;
                                    }

                                    #endregion
                                }
                            }


                        #endregion

                        subXmlStr = subXmlStr + "<i><a>" + preBOQID + "</a><b>" + ent.ItemID + "</b><c>" + actualPrice + "</c><d>" + totalQty + "</d><e>" + String.Empty + "</e><f>" + MiscUtil.ParseToDateTime(DateTime.Now.ToStringDefault()) + "</f><g>" + BrandID + "</g><j>" + SupplierID + "</j><k>" + RegionID + "</k><l>" + CountryID + "</l></i>";
                    }
                    xmlStr.Append(subXmlStr.ToString());
                    xmlStr.Append("</m>");

                    FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.PreBOQDetailTableInfo);
                }
                #endregion New

                #region DeleteFromDB New

                if (finalDeleteList != null && finalDeleteList.Count > 0)
                {
                    foreach (PRMPreBOQDetailEntity ent in finalDeleteList)
                    {
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQDetailID, ent.PreBOQDetailID.ToString(), SQLMatchType.Equal);
                        FCCPRMPreBOQDetail.GetFacadeCreate().Delete(new PRMPreBOQDetailEntity(), fe, DatabaseOperationType.Delete, TransactionRequired.No);
                    }
                }

                #endregion DeleteFromDB New


                #region Backup

                //else
                //{
                    

                //    IList<PRMPreBOQDetailEntity> temp_currentlyCheckedItems = currentlyCheckedItems.Except(populatedItems, new CustomerComparer()).ToList();
                //    IList<PRMPreBOQDetailEntity> temp_mappedItemsFromDB = mappedItemsFromDB.Except(populatedItems, new CustomerComparer()).ToList();

                //    IList<PRMPreBOQDetailEntity> al = temp_currentlyCheckedItems.Except(temp_mappedItemsFromDB, new CustomerComparer()).ToList();
                //    IList<PRMPreBOQDetailEntity> dl = temp_mappedItemsFromDB.Except(temp_currentlyCheckedItems, new CustomerComparer()).ToList();

                    
                //    IList<PRMPreBOQDetailEntity> new_al = checkedItemsFromTree.Except(populatedCheckedItems, new CustomerComparer()).ToList();
                //    IList<PRMPreBOQDetailEntity> new_dl = populatedCheckedItems.Except(checkedItemsFromTree, new CustomerComparer()).ToList();

                //    #region Deleting

                //    foreach (PRMPreBOQDetailEntity ent in new_dl)
                //    {
                //        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                //        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
                //        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                //        FCCPRMPreBOQDetail.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                //    }

                //    foreach (PRMPreBOQDetailEntity ent in dl)
                //    {
                //        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                //        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
                //        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                //        FCCPRMPreBOQDetail.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                //    }

                //    #endregion

                //    #region Adding

                //    StringBuilder xmlStr = new StringBuilder();
                //    String subXmlStr = String.Empty;

                //    xmlStr.Append("<m>");

                //    foreach (PRMPreBOQDetailEntity ent in new_al)
                //    {
                //        subXmlStr = subXmlStr + "<i><a>" + preBOQID + "</a><b>" + ent.ItemID + "</b></i>";
                //    }

                //    foreach (PRMPreBOQDetailEntity ent in al)
                //    {
                //        subXmlStr = subXmlStr + "<i><a>" + preBOQID + "</a><b>" + ent.ItemID + "</b></i>";
                //    }

                //    xmlStr.Append(subXmlStr.ToString());
                //    xmlStr.Append("</m>");


                //    FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.PreBOQDetailTableInfo);

                //    #endregion
                //}

                #endregion

                treeItem.ReBuildTree();
                PrepareFormView();

                MiscUtil.ShowMessage(lblMessage, "BOQ Setup Updated Successfully.", false);
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "An Error Occoured.", true);
            }
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareInitialView();
                PrepareFormView();
            }
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePreBOQDetailInfo();
        }

        protected void btnSelectAll_Click(object sender, EventArgs e)
        {
            SelectAction = "SelectAll";
            treeItem.ReBuildTree();
            lblSelectMessage.Text = "Selected All";
        }

        protected void btnDeselectAll_Click(object sender, EventArgs e)
        {
            SelectAction = "DeselectAll";
            treeItem.ReBuildTree();
            lblSelectMessage.Text = "Deselected All";
        }

        protected void btnClearSelection_Click(object sender, EventArgs e)
        {
            SelectAction = "none";
            treeItem.ReBuildTree();
            lblSelectMessage.Text = "Selected None";
        }

        #endregion

        #region DropDownList Events

        protected void ddlPreBOQTemplateID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int64 preBOQTemplateID = 0;

            Int64.TryParse(ddlPreBOQTemplateID.SelectedValue, out preBOQTemplateID);

            // getting selected Item for template
            if (preBOQTemplateID > 0)
            {
                populatedItems = new List<PRMPreBOQDetailEntity>();
                populatedCheckedItems = new List<PRMPreBOQDetailEntity>();
                currentlyCheckedItems = new List<PRMPreBOQDetailEntity>();

                IList<PRMPreBOQTemplateItemMapEntity> templateItemList = new List<PRMPreBOQTemplateItemMapEntity>();

                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQTemplateItemMapEntity.FLD_NAME_PreBOQTemplateID, preBOQTemplateID.ToString(), SQLMatchType.Equal);
                templateItemList = FCCPRMPreBOQTemplateItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (templateItemList != null && templateItemList.Count > 0)
                {
                    foreach (PRMPreBOQTemplateItemMapEntity ent in templateItemList)
                    {
                        PRMPreBOQDetailEntity preBOQDetail = new PRMPreBOQDetailEntity();

                        preBOQDetail.ItemID = ent.ItemID;

                        currentlyCheckedItems.Add(preBOQDetail);

                        treeItem.ReBuildTree();
                    }
                }
            }
        }

        #endregion

        #region Treeview Event

        protected void treeItem_SelectedNodeChanged(object sender, EventArgs e)
        {
            IsItemNode(treeItem.SelectedNode);
        }

        #endregion

        #endregion Event
    }
}
#region Backup

//private void SavePreBOQDetailInfo()
//        {
//            try
//            {
//                #region Getting the checked items from tree

//                IList<PRMPreBOQDetailEntity> checkedItemsFromTree = new List<PRMPreBOQDetailEntity>();

//                foreach (TreeNode tn in treeItem.CheckedNodes)
//                {
//                    PRMPreBOQDetailEntity ent = new PRMPreBOQDetailEntity();
//                    ent.ItemID = Int64.Parse(tn.Value.ToString());
//                    checkedItemsFromTree.Add(ent);
//                }

//                #endregion 

//                Int64 preBOQID = 0;

//                if (isNewEntry == true)
//                {
//                    preBOQID = FCCPRMPreBOQ.GetFacadeCreate().Add(BuildPRMPreBOQEntity(), DatabaseOperationType.Add, TransactionRequired.No);

//                    #region Adding 

//                    IList<PRMPreBOQDetailEntity> addListOfNotPopulatedItems = currentlyCheckedItems.Except(populatedItems, new CustomerComparer()).ToList();                    

//                    StringBuilder xmlStr = new StringBuilder();
//                    String subXmlStr = String.Empty;
                    
//                    xmlStr.Append("<m>");

//                    foreach (PRMPreBOQDetailEntity ent in addListOfNotPopulatedItems)
//                    {
//                        subXmlStr = subXmlStr + "<i><a>" + preBOQID + "</a><b>" + ent.ItemID + "</b></i>";
//                    }

//                    foreach (PRMPreBOQDetailEntity ent in checkedItemsFromTree)
//                    {
//                        subXmlStr = subXmlStr + "<i><a>" + preBOQID + "</a><b>" + ent.ItemID + "</b></i>";
//                    }

//                    xmlStr.Append(subXmlStr.ToString());
//                    xmlStr.Append("</m>");


//                    FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.PreBOQDetailTableInfo);

//                    #endregion
//                }
//                else
//                {
//                    preBOQID = currentPreBOQ.PreBOQID;

//                    IList<PRMPreBOQDetailEntity> temp_currentlyCheckedItems = currentlyCheckedItems.Except(populatedItems, new CustomerComparer()).ToList();
//                    IList<PRMPreBOQDetailEntity> temp_mappedItemsFromDB = mappedItemsFromDB.Except(populatedItems, new CustomerComparer()).ToList();

//                    IList<PRMPreBOQDetailEntity> al = temp_currentlyCheckedItems.Except(temp_mappedItemsFromDB, new CustomerComparer()).ToList();
//                    IList<PRMPreBOQDetailEntity> dl = temp_mappedItemsFromDB.Except(temp_currentlyCheckedItems, new CustomerComparer()).ToList();

                    
//                    IList<PRMPreBOQDetailEntity> new_al = checkedItemsFromTree.Except(populatedCheckedItems, new CustomerComparer()).ToList();
//                    IList<PRMPreBOQDetailEntity> new_dl = populatedCheckedItems.Except(checkedItemsFromTree, new CustomerComparer()).ToList();

//                    #region Deleting

//                    foreach (PRMPreBOQDetailEntity ent in new_dl)
//                    {
//                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
//                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
//                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
//                        FCCPRMPreBOQDetail.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
//                    }

//                    foreach (PRMPreBOQDetailEntity ent in dl)
//                    {
//                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
//                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
//                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
//                        FCCPRMPreBOQDetail.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
//                    }

//                    #endregion

//                    #region Adding

//                    StringBuilder xmlStr = new StringBuilder();
//                    String subXmlStr = String.Empty;

//                    xmlStr.Append("<m>");

//                    foreach (PRMPreBOQDetailEntity ent in new_al)
//                    {
//                        subXmlStr = subXmlStr + "<i><a>" + preBOQID + "</a><b>" + ent.ItemID + "</b></i>";
//                    }

//                    foreach (PRMPreBOQDetailEntity ent in al)
//                    {
//                        subXmlStr = subXmlStr + "<i><a>" + preBOQID + "</a><b>" + ent.ItemID + "</b></i>";
//                    }

//                    xmlStr.Append(subXmlStr.ToString());
//                    xmlStr.Append("</m>");


//                    FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.PreBOQDetailTableInfo);

//                    #endregion
//                }

//                treeItem.ReBuildTree();
//                PrepareFormView();

//                MiscUtil.ShowMessage(lblMessage, "PreBOQ Setup Updated Successfully.", false);
//            }
//            catch (Exception ex)
//            {
//                MiscUtil.ShowMessage(lblMessage, "An Error Occoured.", true);
//            }
//        }

#endregion