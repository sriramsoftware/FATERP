// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
using System.Text;

namespace Bay.ERP.Web.UI
{
    public partial class PRMBOQTemplateItemMapControl : BaseControl
    {
        #region Extra

        class CustomerComparer : IEqualityComparer<PRMBOQTemplateItemMapEntity>
        {
            public bool Equals(PRMBOQTemplateItemMapEntity x, PRMBOQTemplateItemMapEntity y)
            {
                return (x.ItemID.Equals(y.ItemID) && x.BOQTemplateID.Equals(y.BOQTemplateID));
            }

            public int GetHashCode(PRMBOQTemplateItemMapEntity obj)
            {
                return obj.ItemID.GetHashCode();
            }
        }

        class CustomerComparerAnother : IEqualityComparer<PRMBOQTemplateItemMapEntity>
        {
            public bool Equals(PRMBOQTemplateItemMapEntity x, PRMBOQTemplateItemMapEntity y)
            {
                return (x.ItemID.Equals(y.ItemID));
            }

            public int GetHashCode(PRMBOQTemplateItemMapEntity obj)
            {
                return obj.ItemID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _BOQTemplateItemMapID
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

        public Int64 BOQTemplateID
        {
            get
            {
                Int64 _bOQTemplateID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[PRMBOQTemplateEntity.FLD_NAME_BOQTemplateID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[PRMBOQTemplateEntity.FLD_NAME_BOQTemplateID], out _bOQTemplateID);
                }

                return _bOQTemplateID;
            }
        }

        public PRMBOQTemplateItemMapEntity _PRMBOQTemplateItemMapEntity
        {
            get
            {
                PRMBOQTemplateItemMapEntity entity = new PRMBOQTemplateItemMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMBOQTemplateItemMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMBOQTemplateItemMapEntity CurrentPRMBOQTemplateItemMapEntity
        {
            get
            {
                if (_BOQTemplateItemMapID > 0)
                {
                    if (_PRMBOQTemplateItemMapEntity.BOQTemplateItemMapID != _BOQTemplateItemMapID)
                    {
                        _PRMBOQTemplateItemMapEntity = FCCPRMBOQTemplateItemMap.GetFacadeCreate().GetByID(_BOQTemplateItemMapID);
                    }
                }

                return _PRMBOQTemplateItemMapEntity;
            }
            set
            {
                _PRMBOQTemplateItemMapEntity = value;
            }
        }

        public IList<PRMBOQTemplateItemMapEntity> currentMappedItems
        {
            get
            {
                return (IList<PRMBOQTemplateItemMapEntity>)ViewState["vs_currentMappedItems"];
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

        IList<PRMBOQTemplateItemMapEntity> newMappedItems = new List<PRMBOQTemplateItemMapEntity>();
        IList<PRMBOQTemplateItemMapEntity> currentlyPopulatedMappedItems = new List<PRMBOQTemplateItemMapEntity>();

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
            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQTemplateItemMapEntity.FLD_NAME_BOQTemplateID, BOQTemplateID.ToString(), SQLMatchType.Equal);
            currentMappedItems = FCCPRMBOQTemplateItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (currentMappedItems == null)
            {
                currentMappedItems = new List<PRMBOQTemplateItemMapEntity>();
            }
        }

        private void PrepareCurrentlyPopulatedMappedItems(TreeNode parentNode)
        {
            foreach (TreeNode node in parentNode.ChildNodes)
            {
                if (node.Depth == 2)
                {
                    PRMBOQTemplateItemMapEntity ent = new PRMBOQTemplateItemMapEntity();
                    ent.ItemID = Int64.Parse(node.Value.ToString());
                    ent.BOQTemplateID = BOQTemplateID;
                    currentlyPopulatedMappedItems.Add(ent);
                }

                PrepareCurrentlyPopulatedMappedItems(node);
            }
        }

        private void SavePRMBOQTemplateItemMapEntity()
        {
            try
            {
                foreach (TreeNode catNode in treeItem.Nodes)
                {
                    PrepareCurrentlyPopulatedMappedItems(catNode);
                }

                foreach (TreeNode tn in treeItem.CheckedNodes)
                {
                    PRMBOQTemplateItemMapEntity ent = new PRMBOQTemplateItemMapEntity();
                    ent.ItemID = Int64.Parse(tn.Value.ToString());
                    ent.BOQTemplateID = BOQTemplateID;
                    newMappedItems.Add(ent);
                }

                if (currentMappedItems.Count <= 0)
                {
                    IList<PRMBOQTemplateItemMapEntity> unCheckedList = currentlyPopulatedMappedItems.Except(newMappedItems, new CustomerComparer()).ToList();
                    IList<PRMBOQTemplateItemMapEntity> templateItemList = new List<PRMBOQTemplateItemMapEntity>();
                    foreach (var v in temporaryMappedItems)
                    {
                        PRMBOQTemplateItemMapEntity ent = new PRMBOQTemplateItemMapEntity();
                        ent.ItemID = v.ItemID;
                        ent.BOQTemplateID = BOQTemplateID;
                        templateItemList.Add(ent);
                    }
                    IList<PRMBOQTemplateItemMapEntity> addCheckedList = templateItemList.Except(unCheckedList, new CustomerComparerAnother()).ToList();
                    Int64 i = 0;

                    StringBuilder xmlStr = new StringBuilder();
                    xmlStr.Append("<m>");
                    String subXmlStr = null;

                    foreach (PRMBOQTemplateItemMapEntity ent in addCheckedList)
                    {
                        i++;
                        subXmlStr = subXmlStr + "<i><a>" + ent.BOQTemplateID + "</a><b>" + ent.ItemID + "</b><c>" + i + "</c></i>";

                    }
                    xmlStr.Append(subXmlStr.ToString());
                    xmlStr.Append("</m>");
                    FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.BOQItemMapTableInfo);


                }

                else if (currentMappedItems.Count > 0)
                {
                    currentlyPopulatedMappedItems = currentlyPopulatedMappedItems.Intersect(currentMappedItems, new CustomerComparer()).ToList();

                    IList<PRMBOQTemplateItemMapEntity> deleteList = currentlyPopulatedMappedItems.Except(newMappedItems, new CustomerComparer()).ToList();
                    IList<PRMBOQTemplateItemMapEntity> addNewList = newMappedItems.Except(currentlyPopulatedMappedItems, new CustomerComparer()).ToList();

                    if (deleteList != null && deleteList.Count > 0)
                    {
                        foreach (PRMBOQTemplateItemMapEntity ent in deleteList)
                        {
                            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQTemplateItemMapEntity.FLD_NAME_BOQTemplateID, ent.BOQTemplateID.ToString(), SQLMatchType.Equal);
                            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQTemplateItemMapEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
                            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                            FCCPRMBOQTemplateItemMap.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                        }
                    }

                    if (addNewList != null && addNewList.Count > 0)
                    {
                        foreach (PRMBOQTemplateItemMapEntity ent in addNewList)
                        {
                            FCCPRMBOQTemplateItemMap.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                    }
                }

                MiscUtil.ShowMessage(lblMessage, "Template Project Cost Item Map Updated Successfully.", false);
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
            SavePRMBOQTemplateItemMapEntity();
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
