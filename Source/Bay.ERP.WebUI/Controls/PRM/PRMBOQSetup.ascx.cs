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
    public partial class PRMBOQSetupControl : ProjectBaseControl
    {
        #region Extra

        class CustomerComparer : IEqualityComparer<PRMBOQDetailEntity>
        {
            public bool Equals(PRMBOQDetailEntity x, PRMBOQDetailEntity y)
            {
                return (x.ItemID.Equals(y.ItemID));
            }

            public int GetHashCode(PRMBOQDetailEntity obj)
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

        public PRMBOQEntity currentBOQ
        {
            get
            {
                return (PRMBOQEntity)ViewState["vs_currentBOQ"];
            }
            set
            {
                ViewState["vs_currentBOQ"] = value;
            }
        }

        public IList<PRMBOQDetailEntity> currentlyCheckedItems
        {
            get
            {
                return (IList<PRMBOQDetailEntity>)ViewState["vs_currentlyCheckedItems"];
            }
            set
            {
                ViewState["vs_currentlyCheckedItems"] = value;
            }
        }

        public IList<PRMBOQDetailEntity> mappedItemsFromDB
        {
            get
            {
                return (IList<PRMBOQDetailEntity>)ViewState["vs_mappedItemsFromDB"];
            }
            set
            {
                ViewState["vs_mappedItemsFromDB"] = value;
            }
        }
        
        public IList<PRMBOQDetailEntity> populatedItems
        {
            get
            {
                return (IList<PRMBOQDetailEntity>)ViewState["vs_populatedItems"];
            }
            set
            {
                ViewState["vs_populatedItems"] = value;
            }
        }

        public IList<PRMBOQDetailEntity> populatedCheckedItems
        {
            get
            {
                return (IList<PRMBOQDetailEntity>)ViewState["vs_populatedCheckedItems"];
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
            MiscUtil.PopulatePRMBOQTemplate(ddlBOQTemplateID, true);
        }

        private void PrepareFormView()
        {
            populatedItems = new List<PRMBOQDetailEntity>();
            populatedCheckedItems = new List<PRMBOQDetailEntity>();

            BuildDropDownList();

            #region New or Update mode decission making

            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);

            IList<PRMBOQEntity> lst = FCCPRMBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lst != null && lst.Count > 0)
            {
                isNewEntry = false;
                currentBOQ = lst[0];
            }
            else
            {
                isNewEntry = true;
                currentBOQ = null;
            }

            #endregion

            currentlyCheckedItems = new List<PRMBOQDetailEntity>();
            mappedItemsFromDB = new List<PRMBOQDetailEntity>();

            #region Determine Current Mapped & Checked Items

            if (isNewEntry == true)
            {
                IList<MDItemEntity> itemList = FCCMDItem.GetFacadeCreate().GetILFC();

                if (itemList != null && itemList.Count > 0)
                {
                    foreach (MDItemEntity item in itemList)
                    {
                        PRMBOQDetailEntity ent = new PRMBOQDetailEntity();

                        ent.ItemID = item.ItemID;

                        currentlyCheckedItems.Add(ent);
                    }
                }                
            }
            else
            {
                String fe_PreBOQDetail = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQID, currentBOQ.BOQID.ToString(), SQLMatchType.Equal);

                mappedItemsFromDB = FCCPRMBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_PreBOQDetail, DatabaseOperationType.LoadWithFilterExpression);

                if (mappedItemsFromDB == null)
                {
                    mappedItemsFromDB = new List<PRMBOQDetailEntity>();
                }
                
                currentlyCheckedItems = mappedItemsFromDB;
            }

            #endregion
        }        
                
        private PRMBOQEntity BuildPRMBOQEntity()
        {
            PRMBOQEntity PRMBOQEntity = new PRMBOQEntity();
            
            PRMBOQEntity.ProjectID = OverviewProjectID;
            PRMBOQEntity.StartDate = System.DateTime.Now;
            PRMBOQEntity.PreparedByMemberID = 1;
            PRMBOQEntity.BOQStatusID = 1;

            return PRMBOQEntity;
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

                        PRMBOQDetailEntity ent1 = new PRMBOQDetailEntity();
                        ent1.ItemID = Int64.Parse(n.Value.ToString());
                        populatedCheckedItems.Add(ent1);

                        #endregion
                    }
                    else
                    {
                        n.Checked = false;
                    }

                    #region Storing the populated nodes

                    PRMBOQDetailEntity ent = new PRMBOQDetailEntity();
                    ent.ItemID = Int64.Parse(n.Value.ToString());
                    populatedItems.Add(ent);

                    #endregion
                }
            }

        }

        private void SaveBOQDetailInfo()
        {
            try
            {
                #region Getting the checked items from tree

                IList<PRMBOQDetailEntity> checkedItemsFromTree = new List<PRMBOQDetailEntity>();

                foreach (TreeNode tn in treeItem.CheckedNodes)
                {
                    PRMBOQDetailEntity ent = new PRMBOQDetailEntity();
                    ent.ItemID = Int64.Parse(tn.Value.ToString());
                    
                    checkedItemsFromTree.Add(ent);
                }

                #endregion 

                Int64 bOQID = 0;

                if (isNewEntry == true)
                {
                    bOQID = FCCPRMBOQ.GetFacadeCreate().Add(BuildPRMBOQEntity(), DatabaseOperationType.Add, TransactionRequired.No);                    
                }
                else
                {
                    bOQID = currentBOQ.BOQID;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQID, bOQID.ToString(),SQLMatchType.Equal);

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

                IList<PRMBOQDetailEntity> addListOfNotPopulatedItems = currentlyCheckedItems.Except(populatedItems, new CustomerComparer()).ToList();

                IList<PRMBOQDetailEntity> completeAddList = new List<PRMBOQDetailEntity>();
                completeAddList = addListOfNotPopulatedItems;

                foreach (PRMBOQDetailEntity ent in checkedItemsFromTree)
                {
                    completeAddList.Add(ent);
                }

                IList<PRMBOQDetailEntity> finalAddList = completeAddList.Except(mappedItemsFromDB, new CustomerComparer()).ToList();
                IList<PRMBOQDetailEntity> finalDeleteList = mappedItemsFromDB.Except(completeAddList, new CustomerComparer()).ToList();

                if (finalAddList != null && finalAddList.Count > 0)
                {
                    StringBuilder xmlStr = new StringBuilder();
                    String subXmlStr = String.Empty;
                    xmlStr.Append("<m>");

                    foreach (PRMBOQDetailEntity ent in finalAddList)
                    {

                        #region SET Item Rate and Qty

                        //GET Item Actual Price From Pre-BOQ or Set Zero

                        Decimal actualPrice = 0;
                        Decimal totalQty = 0;
                        Int64 BrandID = MasterDataConstants.ItemDefaults.DEFAULT_BRAD;
                        Int64 SupplierID = MasterDataConstants.ItemDefaults.DEFAULT_SUPPLIER;
                        Int64 RegionID = MasterDataConstants.ItemDefaults.DEFAULT_REGION;
                        Int64 CountryID = MasterDataConstants.ItemDefaults.DEFAULT_COUNTRY;

                        IList<PRMBOQDetailEntity> _pRMBOQDeatilEntity = (from s in mappedItemsFromDB
                                                                         where s.ItemID == ent.ItemID
                                                                         select s).ToList();

                        if (_pRMBOQDeatilEntity != null && _pRMBOQDeatilEntity.Count > 0 && _pRMBOQDeatilEntity[0].TotalQty > 0)
                        {

                            Int64.TryParse(_pRMBOQDeatilEntity[0].BrandID.ToString(), out BrandID);
                            Int64.TryParse(_pRMBOQDeatilEntity[0].SupplierID.ToString(), out SupplierID);
                            Int64.TryParse(_pRMBOQDeatilEntity[0].RegionID.ToString(), out RegionID);
                            Int64.TryParse(_pRMBOQDeatilEntity[0].CountryID.ToString(), out CountryID);
                            Decimal.TryParse(_pRMBOQDeatilEntity[0].Rate.ToString(), out actualPrice);
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

                        if (_pRMBOQDeatilEntity != null && _pRMBOQDeatilEntity.Count > 0 && _pRMBOQDeatilEntity[0].Rate > 0)
                        {
                            Decimal.TryParse(_pRMBOQDeatilEntity[0].TotalQty.ToString(), out totalQty);
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


                        #endregion

                        subXmlStr = subXmlStr + "<i><a>" + bOQID + "</a><b>" + ent.ItemID + "</b><c>" + actualPrice + "</c><d>" + totalQty + "</d><e>" + String.Empty + "</e><f>" + MiscUtil.ParseToDateTime(DateTime.Now.ToStringDefault()) + "</f><g>" + BrandID + "</g><j>" + SupplierID + "</j><k>" + RegionID + "</k><l>" + CountryID + "</l></i>";
                    }
                    xmlStr.Append(subXmlStr.ToString());
                    xmlStr.Append("</m>");

                    FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.BOQDetailTableInfo);
                }
                #endregion New

                #region DeleteFromDB New

                if (finalDeleteList != null && finalDeleteList.Count > 0)
                {
                    foreach (PRMBOQDetailEntity ent in finalDeleteList)
                    {
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQDetailID, ent.BOQDetailID.ToString(), SQLMatchType.Equal);
                        FCCPRMBOQDetail.GetFacadeCreate().Delete(new PRMBOQDetailEntity(), fe, DatabaseOperationType.Delete, TransactionRequired.No);
                    }
                }

                #endregion DeleteFromDB New




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

                treeItem.ReBuildTree();
                PrepareFormView();

                MiscUtil.ShowMessage(lblMessage, "Project Cost Setup Updated Successfully.", false);
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
                PrepareFormView();
            }
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBOQDetailInfo();
        }

        #endregion

        #region DropDownList Events

        protected void ddlBOQTemplateID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int64 bOQTemplateID = 0;

            Int64.TryParse(ddlBOQTemplateID.SelectedValue, out bOQTemplateID);

            // getting selected Item for template
            if (bOQTemplateID > 0)
            {
                populatedItems = new List<PRMBOQDetailEntity>();
                populatedCheckedItems = new List<PRMBOQDetailEntity>();
                currentlyCheckedItems = new List<PRMBOQDetailEntity>();

                IList<PRMBOQTemplateItemMapEntity> templateItemList = new List<PRMBOQTemplateItemMapEntity>();

                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQTemplateItemMapEntity.FLD_NAME_BOQTemplateID, bOQTemplateID.ToString(), SQLMatchType.Equal);
                templateItemList = FCCPRMBOQTemplateItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (templateItemList != null && templateItemList.Count > 0)
                {
                    foreach (PRMBOQTemplateItemMapEntity ent in templateItemList)
                    {
                        PRMBOQDetailEntity bOQDetail = new PRMBOQDetailEntity();

                        bOQDetail.ItemID = ent.ItemID;

                        currentlyCheckedItems.Add(bOQDetail);

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