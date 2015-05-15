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
    public partial class PRMPreBOQTemplateItemMapControl : BaseControl
    {

        #region Extra

        class CustomerComparer : IEqualityComparer<PRMPreBOQTemplateItemMapEntity>
        {
            public bool Equals(PRMPreBOQTemplateItemMapEntity x, PRMPreBOQTemplateItemMapEntity y)
            {
                return (x.ItemID.Equals(y.ItemID) && x.PreBOQTemplateID.Equals(y.PreBOQTemplateID));
            }

            public int GetHashCode(PRMPreBOQTemplateItemMapEntity obj)
            {
                return obj.ItemID.GetHashCode();
            }
        }

        class CustomerComparerAnother : IEqualityComparer<PRMPreBOQTemplateItemMapEntity>
        {
            public bool Equals(PRMPreBOQTemplateItemMapEntity x, PRMPreBOQTemplateItemMapEntity y)
            {
                return (x.ItemID.Equals(y.ItemID));
            }

            public int GetHashCode(PRMPreBOQTemplateItemMapEntity obj)
            {
                return obj.ItemID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 PreBOQTemplateID
        {
            get
            {
                Int64 PreBOQTemplateID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[PRMPreBOQTemplateEntity.FLD_NAME_PreBOQTemplateID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[PRMPreBOQTemplateEntity.FLD_NAME_PreBOQTemplateID], out PreBOQTemplateID);
                }

                return PreBOQTemplateID;
            }
        }

        public IList<PRMPreBOQTemplateItemMapEntity> currentMappedItems
        {
            get
            {
                return (IList<PRMPreBOQTemplateItemMapEntity>)ViewState["vs_currentMappedItems"];
            }
            set
            {
                ViewState["vs_currentMappedItems"] = value;
            }
        }

        public IList<MDItemEntity> temporaryMappedItems
        {
            get
            {
                return (IList<MDItemEntity>)ViewState["vs_temporaryMappedItems"];
            }
            set
            {
                ViewState["vs_temporaryMappedItems"] = value;
            }
        }
        IList<PRMPreBOQTemplateItemMapEntity> newMappedItems = new List<PRMPreBOQTemplateItemMapEntity>();
        IList<PRMPreBOQTemplateItemMapEntity> currentlyPopulatedMappedItems = new List<PRMPreBOQTemplateItemMapEntity>();


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

        }

        private void IsItemNode(TreeNode tn)
        {

            if (tn.Depth == 1)
            {
                foreach (TreeNode n in tn.ChildNodes)
                {
                    Int64 itemID = Int64.Parse(n.Value.ToString());
                    var tempItem = from s in currentMappedItems
                                   where s.ItemID == itemID
                                   select s;

                    if (tempItem != null && tempItem.Count() > 0)
                    {
                        n.Checked = true;
                    }
                }
            }

        }

        private void PrepareEditView()
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQTemplateItemMapEntity.FLD_NAME_PreBOQTemplateID, PreBOQTemplateID.ToString(), SQLMatchType.Equal);
            currentMappedItems = FCCPRMPreBOQTemplateItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (currentMappedItems == null)
            {
                currentMappedItems = new List<PRMPreBOQTemplateItemMapEntity>();
            }
        }

        private void PrepareCurrentlyPopulatedMappedItems(TreeNode parentNode)
        {
            foreach (TreeNode node in parentNode.ChildNodes)
            {
                if (node.Depth == 2)
                {
                    PRMPreBOQTemplateItemMapEntity ent = new PRMPreBOQTemplateItemMapEntity();
                    ent.ItemID = Int64.Parse(node.Value.ToString());
                    ent.PreBOQTemplateID = PreBOQTemplateID;
                    currentlyPopulatedMappedItems.Add(ent);
                }

                PrepareCurrentlyPopulatedMappedItems(node);
            }
        }

        private void SavePRMPreBOQTemplateItemMapEntity()
        {
            try
            {
                foreach (TreeNode catNode in treeItem.Nodes)
                {
                    PrepareCurrentlyPopulatedMappedItems(catNode);
                }

                foreach (TreeNode tn in treeItem.CheckedNodes)
                {
                    PRMPreBOQTemplateItemMapEntity ent = new PRMPreBOQTemplateItemMapEntity();
                    ent.ItemID = Int64.Parse(tn.Value.ToString());
                    ent.PreBOQTemplateID = PreBOQTemplateID;
                    newMappedItems.Add(ent);
                }

                if (currentMappedItems.Count <= 0)
                {
                    IList<PRMPreBOQTemplateItemMapEntity> unCheckedList = currentlyPopulatedMappedItems.Except(newMappedItems, new CustomerComparer()).ToList();
                    IList<PRMPreBOQTemplateItemMapEntity> templateItemList = new List<PRMPreBOQTemplateItemMapEntity>();
                    foreach (var v in temporaryMappedItems)
                    {
                        PRMPreBOQTemplateItemMapEntity ent = new PRMPreBOQTemplateItemMapEntity();
                        ent.ItemID = v.ItemID;
                        ent.PreBOQTemplateID = PreBOQTemplateID;
                        templateItemList.Add(ent);
                    }
                    IList<PRMPreBOQTemplateItemMapEntity> addCheckedList = templateItemList.Except(unCheckedList, new CustomerComparerAnother()).ToList();
                    Int64 i = 0;
                    StringBuilder xmlStr = new StringBuilder();
                    xmlStr.Append("<m>");
                    String subXmlStr = null;
                    foreach (PRMPreBOQTemplateItemMapEntity ent in addCheckedList)
                    {
                        i++;
                        subXmlStr = subXmlStr + "<i><a>" + ent.PreBOQTemplateID + "</a><b>" + ent.ItemID + "</b><c>" + i + "</c></i>";

                    }
                    xmlStr.Append(subXmlStr.ToString());
                    xmlStr.Append("</m>");
                    FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.PreBOQItemMapTableInfo);
                }

                else if (currentMappedItems.Count > 0)
                {
                    currentlyPopulatedMappedItems = currentlyPopulatedMappedItems.Intersect(currentMappedItems, new CustomerComparer()).ToList();

                    IList<PRMPreBOQTemplateItemMapEntity> deleteList = currentlyPopulatedMappedItems.Except(newMappedItems, new CustomerComparer()).ToList();
                    IList<PRMPreBOQTemplateItemMapEntity> addNewList = newMappedItems.Except(currentlyPopulatedMappedItems, new CustomerComparer()).ToList();

                    if (deleteList != null && deleteList.Count > 0)
                    {
                        foreach (PRMPreBOQTemplateItemMapEntity ent in deleteList)
                        {
                            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQTemplateItemMapEntity.FLD_NAME_PreBOQTemplateID, ent.PreBOQTemplateID.ToString(), SQLMatchType.Equal);
                            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQTemplateItemMapEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
                            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                            FCCPRMPreBOQTemplateItemMap.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                        }
                    }

                    if (addNewList != null && addNewList.Count > 0)
                    {
                        foreach (PRMPreBOQTemplateItemMapEntity ent in addNewList)
                        {
                            FCCPRMPreBOQTemplateItemMap.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                    }
                }

                MiscUtil.ShowMessage(lblMessage, "Template BOQ Item Map Updated Successfully.", false);
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
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();

                if (currentMappedItems.Count <= 0)
                {
                    treeItem.ShowCheckedAtLastNode = true;
                    temporaryMappedItems = FCCMDItem.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
                }
            }
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMPreBOQTemplateItemMapEntity();
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

