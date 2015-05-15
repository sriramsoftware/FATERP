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

namespace Bay.ERP.Web.UI
{
    public partial class BDTaskTemplateItemMapControl : BaseControl
    {
        #region Extra

        class CustomerComparer : IEqualityComparer<BDTaskTemplateItemMapEntity>
        {
            public bool Equals(BDTaskTemplateItemMapEntity x, BDTaskTemplateItemMapEntity y)
            {
                return (x.TaskID.Equals(y.TaskID) && x.TaskTemplateID.Equals(y.TaskTemplateID));
            }

            public int GetHashCode(BDTaskTemplateItemMapEntity obj)
            {
                return obj.TaskID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _TaskTemplateItemMap
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

        public BDTaskTemplateItemMapEntity _BDTaskTemplateItemMapEntity
        {
            get
            {
                BDTaskTemplateItemMapEntity entity = new BDTaskTemplateItemMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDTaskTemplateItemMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDTaskTemplateItemMapEntity CurrentBDTaskTemplateItemMapEntity
        {
            get
            {
                if (_TaskTemplateItemMap > 0)
                {
                    if (_BDTaskTemplateItemMapEntity.TaskTemplateItemMap != _TaskTemplateItemMap)
                    {
                        _BDTaskTemplateItemMapEntity = FCCBDTaskTemplateItemMap.GetFacadeCreate().GetByID(_TaskTemplateItemMap);
                    }
                }

                return _BDTaskTemplateItemMapEntity;
            }
            set
            {
                _BDTaskTemplateItemMapEntity = value;
            }
        }

        public Int64 OverviewTaskTemplateID
        {
            get
            {
                Int64 templateID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TASK_TEMPLATE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TASK_TEMPLATE_ID], out templateID);
                }

                return templateID;
            }
        }

        public IList<BDTaskTemplateItemMapEntity> currentMappedDocuments
        {
            get
            {
                return (IList<BDTaskTemplateItemMapEntity>)ViewState["vs_currentMappedTasks"];
            }
            set
            {
                ViewState["vs_currentMappedTasks"] = value;
            }
        }

        IList<BDTaskTemplateItemMapEntity> newMappedDocuments = new List<BDTaskTemplateItemMapEntity>();

        TreeNodeCollection currentMappedNodes;
        TreeNodeCollection newMappedNodes;

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
            treeDocument.BuildTree();
        }

        private void PrepareEditView()
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDTaskTemplateItemMapEntity.FLD_NAME_TaskTemplateID, OverviewTaskTemplateID.ToString(), SQLMatchType.Equal);

            currentMappedDocuments = FCCBDTaskTemplateItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            #region Setting check to the documents

            if (currentMappedDocuments != null && currentMappedDocuments.Count > 0)
            {
                foreach (TreeNode tn in treeDocument.Nodes)
                {
                    IsDocumentNode(tn);
                }
            }
            else
            {
                currentMappedDocuments = new List<BDTaskTemplateItemMapEntity>();
            }

            currentMappedNodes = treeDocument.CheckedNodes;

            #endregion
        }

        private void IsDocumentNode(TreeNode tn)
        {
            BayTreeNodeValue bayTreeNodeValue = new BayTreeNodeValue();
            bayTreeNodeValue.SetValuesFromString(tn.Value);
            if (bayTreeNodeValue.Attributes["NodeType"] == CustomControlConstants.DocumentNodeType.Document)
            {
                Int64 id = Int64.Parse(bayTreeNodeValue.Value);

                var tempDocument = from s in currentMappedDocuments where s.TaskID == id select s;

                if (tempDocument != null && tempDocument.Count() > 0)
                {
                    tn.Checked = true;
                }
            }
            else
            {
                foreach (TreeNode n in tn.ChildNodes)
                {
                    IsDocumentNode(n);
                }
            }
        }

        private void BindList()
        {
            BindBDTaskTemplateItemMapList();
        }

        private void BindBDTaskTemplateItemMapList()
        {
           
        }

        private void SaveBDTaskTemplateItemMapEntity()
        {
            try
            {
                newMappedNodes = treeDocument.CheckedNodes;

                foreach (TreeNode tn in treeDocument.CheckedNodes)
                {
                    BayTreeNodeValue bayTreeNodeValue = new BayTreeNodeValue();
                    bayTreeNodeValue.SetValuesFromString(tn.Value);

                    BDTaskTemplateItemMapEntity ent = new BDTaskTemplateItemMapEntity();
                    ent.TaskID = Int64.Parse(bayTreeNodeValue.Value);
                    ent.TaskTemplateID = OverviewTaskTemplateID;
                    newMappedDocuments.Add(ent);
                }

                IList<BDTaskTemplateItemMapEntity> deleteList = currentMappedDocuments.Except(newMappedDocuments, new CustomerComparer()).ToList();
                IList<BDTaskTemplateItemMapEntity> addNewList = newMappedDocuments.Except(currentMappedDocuments, new CustomerComparer()).ToList();

                if (deleteList != null && deleteList.Count > 0)
                {
                    foreach (BDTaskTemplateItemMapEntity ent in deleteList)
                    {
                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(BDTaskTemplateItemMapEntity.FLD_NAME_TaskTemplateID, ent.TaskTemplateID.ToString(), SQLMatchType.Equal);
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(BDTaskTemplateItemMapEntity.FLD_NAME_TaskID, ent.TaskID.ToString(), SQLMatchType.Equal);
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                        FCCBDTaskTemplateItemMap.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                    }
                }

                if (addNewList != null && addNewList.Count > 0)
                {
                    foreach (BDTaskTemplateItemMapEntity ent in addNewList)
                    {
                        FCCBDTaskTemplateItemMap.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                }

                MiscUtil.ShowMessage(lblMessage, "Template Task Map Updated Successfully.", false);
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
            }
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDTaskTemplateItemMapEntity();
        }

        #endregion

        #endregion Event
    }
}
