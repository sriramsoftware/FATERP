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

namespace Bay.ERP.Web.UI
{
        #region Extra

    class CustomerComparer : IEqualityComparer<BDProjectDocumentTemplateMapEntity>
    {
        public bool Equals(BDProjectDocumentTemplateMapEntity x, BDProjectDocumentTemplateMapEntity y)
        {
            return (x.ProjectDocumentID.Equals(y.ProjectDocumentID) && x.ProjectDocumentTemplateID.Equals(y.ProjectDocumentTemplateID));
        }

        public int GetHashCode(BDProjectDocumentTemplateMapEntity obj)
        {
            return obj.ProjectDocumentID.GetHashCode();
        }
    }

    #endregion

    public partial class BDProjectDocumentTemplateMapControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 ProjectDocumentTemplateID
        {
            get
            {
                Int64 projectDocumentTemplateID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[BDProjectDocumentTemplateEntity.FLD_NAME_ProjectDocumentTemplateID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[BDProjectDocumentTemplateEntity.FLD_NAME_ProjectDocumentTemplateID], out projectDocumentTemplateID);
                }

                return projectDocumentTemplateID;
            }
        }

        public IList<BDProjectDocumentTemplateMapEntity> currentMappedDocuments 
        {
            get 
            {
                return (IList<BDProjectDocumentTemplateMapEntity>) ViewState["vs_currentMappedDocuments"];
            }
            set
            {
                ViewState["vs_currentMappedDocuments"] = value;
            }
        }
        
        IList<BDProjectDocumentTemplateMapEntity> newMappedDocuments = new List<BDProjectDocumentTemplateMapEntity>();

        TreeNodeCollection currentMappedNodes;
        TreeNodeCollection newMappedNodes;

        #endregion

        #region Methods
               
        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            treeDocument.BuildTree();
        }

        private void PrepareEditView()
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectDocumentTemplateMapEntity.FLD_NAME_ProjectDocumentTemplateID, ProjectDocumentTemplateID.ToString(), SQLMatchType.Equal);

            currentMappedDocuments = FCCBDProjectDocumentTemplateMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

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
                currentMappedDocuments = new List<BDProjectDocumentTemplateMapEntity>();
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

                var tempDocument = from s in currentMappedDocuments where s.ProjectDocumentID == id select s;

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

        private void SaveBDProjectDocumentTemplateMapEntity()
        {
            try
            {
                newMappedNodes = treeDocument.CheckedNodes;

                foreach (TreeNode tn in treeDocument.CheckedNodes)
                {
                    BayTreeNodeValue bayTreeNodeValue = new BayTreeNodeValue();
                    bayTreeNodeValue.SetValuesFromString(tn.Value);

                    BDProjectDocumentTemplateMapEntity ent = new BDProjectDocumentTemplateMapEntity();
                    ent.ProjectDocumentID = Int64.Parse(bayTreeNodeValue.Value);
                    ent.ProjectDocumentTemplateID = ProjectDocumentTemplateID;
                    newMappedDocuments.Add(ent);
                }

                IList<BDProjectDocumentTemplateMapEntity> deleteList = currentMappedDocuments.Except(newMappedDocuments, new CustomerComparer()).ToList();
                IList<BDProjectDocumentTemplateMapEntity> addNewList = newMappedDocuments.Except(currentMappedDocuments, new CustomerComparer()).ToList();

                if (deleteList != null && deleteList.Count > 0)
                {
                    foreach (BDProjectDocumentTemplateMapEntity ent in deleteList)
                    {
                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(BDProjectDocumentTemplateMapEntity.FLD_NAME_ProjectDocumentTemplateID, ent.ProjectDocumentTemplateID.ToString(), SQLMatchType.Equal);
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(BDProjectDocumentTemplateMapEntity.FLD_NAME_ProjectDocumentID, ent.ProjectDocumentID.ToString(), SQLMatchType.Equal);
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                        FCCBDProjectDocumentTemplateMap.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                    }
                }

                if (addNewList != null && addNewList.Count > 0)
                {
                    foreach (BDProjectDocumentTemplateMapEntity ent in addNewList)
                    {
                        FCCBDProjectDocumentTemplateMap.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                }

                MiscUtil.ShowMessage(lblMessage, "Template Document Map Updated Successfully.", false);
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
            SaveBDProjectDocumentTemplateMapEntity();
        }

        #endregion

        #endregion Event
    }
}
