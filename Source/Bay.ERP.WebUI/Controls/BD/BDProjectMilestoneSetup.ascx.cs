// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public partial class BDProjectMilestoneSetupControl : ProjectBaseControl
    {

        #region Extra

        class CustomerComparer : IEqualityComparer<CMProjectMilestoneEntity>
        {
            public bool Equals(CMProjectMilestoneEntity x, CMProjectMilestoneEntity y)
            {
                return (x.IssueID.Equals(y.IssueID) && x.ProjectID.Equals(y.ProjectID));
            }

            public int GetHashCode(CMProjectMilestoneEntity obj)
            {
                return obj.IssueID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _ProjectMilestoneID
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

        public IList<CMProjectMilestoneEntity> currentMappedMilestone
        {
            get
            {
                return (IList<CMProjectMilestoneEntity>)ViewState["vs_currentMappedMilestone"];
            }
            set
            {
                ViewState["vs_currentMappedMilestone"] = value;
            }
        }

        IList<CMProjectMilestoneEntity> newMappedMilestones = new List<CMProjectMilestoneEntity>();

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
           treeProjectSchedule.ProjectID = this.OverviewProjectID;
           treeProjectSchedule.ReBuildTree();
        }

        private void IsMilestoneNode(TreeNode tn)
        {
                Int64 id = Int64.Parse(tn.Value);

                var tempMilestone = from s in currentMappedMilestone
                                    where s.IssueID == id
                                    select s;

                if (tempMilestone != null && tempMilestone.Count() > 0)
                {
                    tn.Checked = true;
                }
                foreach (TreeNode n in tn.ChildNodes)
                {
                    IsMilestoneNode(n);
                }
        }

        private void PrepareEditView()
        {

            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CMProjectMilestoneEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
            currentMappedMilestone = FCCCMProjectMilestone.GetFacadeCreate().GetIL(null, null, String.Empty, fe1, DatabaseOperationType.LoadWithFilterExpression);

            if (currentMappedMilestone != null && currentMappedMilestone.Count > 0)
            {
                foreach (TreeNode tn in treeProjectSchedule.Nodes)
                {
                    IsMilestoneNode(tn);
                }
            }
            else
            {
                currentMappedMilestone = new List<CMProjectMilestoneEntity>();
            }
        }

        private void BindList()
        {
            BindCMProjectMilestoneList();
        }

        private void BindCMProjectMilestoneList()
        {
           
        }

        private void SaveNodesToDB()
        {
            foreach (TreeNode tn in treeProjectSchedule.CheckedNodes)
            {
                Int64 issueID=Int64.Parse(tn.Value.ToString());
                if (issueID > 0)
                {
                    CMProjectMilestoneEntity projectMilestone = new CMProjectMilestoneEntity();

                    projectMilestone.ProjectID = this.OverviewProjectID;
                    projectMilestone.IssueID = Int64.Parse(tn.Value.ToString());
                    newMappedMilestones.Add(projectMilestone);
                }
            }

            IList<CMProjectMilestoneEntity> deleteList = currentMappedMilestone.Except(newMappedMilestones, new CustomerComparer()).ToList();
            IList<CMProjectMilestoneEntity> addNewList = newMappedMilestones.Except(currentMappedMilestone, new CustomerComparer()).ToList();

            if (deleteList != null && deleteList.Count > 0)
            {
                foreach (CMProjectMilestoneEntity ent in deleteList)
                {
                    String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CMProjectMilestoneEntity.FLD_NAME_ProjectID, ent.ProjectID.ToString(), SQLMatchType.Equal);
                    String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CMProjectMilestoneEntity.FLD_NAME_IssueID, ent.IssueID.ToString(), SQLMatchType.Equal);
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                    FCCCMProjectMilestone.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                }
            }

            if (addNewList != null && addNewList.Count > 0)
            {
                foreach (CMProjectMilestoneEntity ent in addNewList)
                {
                    FCCCMProjectMilestone.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SaveNodesToDB();

                MiscUtil.ShowMessage(lblMessage, "Project Milestone Information has been added successfully.", false);
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "An Error Occoured.", true);
            }
        }

        #endregion

        #endregion Event
    }
}
    