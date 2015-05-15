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
    public partial class CMProjectScheduleTemplateIssueControl : ProjectBaseControl
    {
        #region Extra

        class CustomerComparer : IEqualityComparer<CMProjectScheduleTemplateItemMapEntity>
        {
            public bool Equals(CMProjectScheduleTemplateItemMapEntity x, CMProjectScheduleTemplateItemMapEntity y)
            {
                return (x.ProjectScheduleItemID.Equals(y.ProjectScheduleItemID) && x.ProjectScheduleTemplateID.Equals(y.ProjectScheduleTemplateID));
            }

            public int GetHashCode(CMProjectScheduleTemplateItemMapEntity obj)
            {
                return obj.ProjectScheduleItemID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _ProjectScheduleTemplateItemMapID
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

        public IList<CMProjectScheduleTemplateItemMapEntity> currentMappedScheduleItem
        {
            get
            {
                return (IList<CMProjectScheduleTemplateItemMapEntity>)ViewState["vs_currentMappedScheduleItem"];
            }
            set
            {
                ViewState["vs_currentMappedScheduleItem"] = value;
            }
        }

        IList<CMProjectScheduleTemplateItemMapEntity> newMappedScheduleItems = new List<CMProjectScheduleTemplateItemMapEntity>();
        IList<OTIssueEntity> newMappedIssueItems = new List<OTIssueEntity>();

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMProjectScheduleTemplate(ddlScheduleTemplateID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
        }

        private void IsScheduleItemNode(TreeNode tn)
        {
            
                Int64 id = Int64.Parse(tn.Value);

                var tempDocument = (from s in currentMappedScheduleItem
                                    where s.ProjectScheduleItemID == id
                                    select s);

                if (tempDocument != null && tempDocument.Count() > 0)
                {
                    tn.Checked = true;
                }
            
                foreach (TreeNode n in tn.ChildNodes)
                {
                    IsScheduleItemNode(n);
                }
           
        }

        private void SaveNodesToDB(TreeNode parentNode, Int64 parentProjectTaskID)
        {
            if (parentNode.ChildNodes.Count > 0)
            {
                foreach (TreeNode node in parentNode.ChildNodes)
                {
                    if (node.Checked == true)
                    {
                        OTIssueEntity projectTask = new OTIssueEntity();

                        projectTask.Title = node.Text;
                        //
                        projectTask.IssueIdentityCategoryID = MasterDataConstants.IssueIdentityCategory.PROJECT_TASK;

                        //Hard Codeed Member
                        projectTask.CreatedByMemberID = 1;// this.CurrentMember.MemberID;
                        projectTask.CreateDate = DateTime.Now;
                        projectTask.IsNotifyCompleted = false;
                        projectTask.IsRemoved = false;

                        projectTask.ParentIssueID = parentProjectTaskID;
                        projectTask.ReferenceID = this.OverviewProjectID;
                        projectTask.ReferenceIssueID = null;

                        #region Sensitive Hard Coded Here

                        //Hard Coded Issue Status ID

                        projectTask.IssueStatusID = 1;
                        projectTask.IssueCategoryID = 2;
                        projectTask.IssuePriorityID = 1;

                        #endregion
                        
                        Int64 result = FCCOTIssue.GetFacadeCreate().Add(projectTask, DatabaseOperationType.Add, TransactionRequired.No);
                        SaveNodesToDB(node, result);
                    }
                }
            }
        }


        private void PrepareEditViewForm()
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMProjectScheduleTemplateItemMapEntity.FLD_NAME_ProjectScheduleTemplateID, ddlScheduleTemplateID.SelectedValue.ToString(), SQLMatchType.Equal);

            currentMappedScheduleItem = FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            #region Setting check to the Schedule Item

            if (currentMappedScheduleItem != null && currentMappedScheduleItem.Count > 0)
            {
                foreach (TreeNode tn in treeProjectSchedule.Nodes)
                {
                    IsScheduleItemNode(tn);
                }
                _ProjectScheduleTemplateItemMapID=Int64.Parse(ddlScheduleTemplateID.SelectedValue.ToString());
            }
            else
            {
                currentMappedScheduleItem = new List<CMProjectScheduleTemplateItemMapEntity>();

            }

            #endregion
        }

        private void PrepareEditView()
        {
           
        }
        private void BindList()
        {
            BindCMProjectScheduleTemplateItemMapList();
        }

        private void BindCMProjectScheduleTemplateItemMapList()
        {
            
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
                //treeProjectSchedule.ShowCheckBoxes = TreeNodeTypes.Leaf;
                PrepareEditView();
                
            }
        }

        #endregion

        #region Button Event

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCMProjectScheduleTemplateItemMapEntity();
        }

        private void UpdateCMProjectScheduleTemplateItemMapEntity()
        {
            try
            {
                Int64 rootTaskID = 0;

                // search in the database....
               
                String fe1=SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_ParentIssueID,String.Empty,SQLMatchType.IsNull);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_ReferenceID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueIdentityCategoryID,MasterDataConstants.IssueIdentityCategory.PROJECT_TASK.ToString(), SQLMatchType.Equal);

                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.AND, fe4);

                IList<OTIssueEntity> temporaryIssueList = FCCOTIssue.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

               
                if(temporaryIssueList!=null && temporaryIssueList.Count>0)
                {
                    rootTaskID =Int64.Parse(temporaryIssueList[0].IssueID.ToString());
                }
                else
                {
                    OTIssueEntity rootTask = new OTIssueEntity();

                    rootTask.Title = OverviewProject.ProjectName + "Project Schedules";
                    rootTask.IssueIdentityCategoryID = MasterDataConstants.IssueIdentityCategory.PROJECT_TASK;

                    //Hard Codeed Member
                    rootTask.CreatedByMemberID = this.CurrentMember.MemberID;
                    rootTask.CreateDate = DateTime.Now;
                    rootTask.IsNotifyCompleted = false;
                    rootTask.IsRemoved = false;

                    rootTask.ParentIssueID = null;
                    rootTask.ReferenceID = this.OverviewProjectID;
                    rootTask.ReferenceIssueID = null;

                    #region Badly Hard-Coded Here
                    
                    //Hard Coded Issue Status ID
                    rootTask.IssuePriorityID = 1;
                    rootTask.IssueStatusID = 1;
                    rootTask.IssueCategoryID = 2;

                    #endregion

                    rootTaskID = FCCOTIssue.GetFacadeCreate().Add(rootTask, DatabaseOperationType.Add, TransactionRequired.No);

                }


                foreach (TreeNode rootNode in treeProjectSchedule.Nodes)
                {                
                    SaveNodesToDB(rootNode, rootTaskID);
                }
                MiscUtil.ShowMessage(lblMessage, "Project Schedule Template Issue Information has been added successfully.", false);
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "An Error Occoured.", true);
            }
        }

        #endregion

        #region Dropdown Event

        protected void ddlScheduleTemplateID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int64 scheduleTemplateID;
            Int64.TryParse(ddlScheduleTemplateID.SelectedValue, out scheduleTemplateID);

            // getting selected Item for template
            if (scheduleTemplateID > 0)
            {
                PrepareEditViewForm();
            }
        }
        #endregion

        #endregion Event
    }
}
