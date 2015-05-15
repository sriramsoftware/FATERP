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
using System.Text;

namespace Bay.ERP.Web.UI
{

    #region Extra

    class ProjectDocumentComparer : IEqualityComparer<BDProjectCollectedDocumentInfoEntity>
    {
        public bool Equals(BDProjectCollectedDocumentInfoEntity x, BDProjectCollectedDocumentInfoEntity y)
        {
            return (x.ProjectDocumentID.Equals(y.ProjectDocumentID) && x.ProjectID.Equals(y.ProjectID));
        }

        public int GetHashCode(BDProjectCollectedDocumentInfoEntity obj)
        {
            return obj.ProjectDocumentID.GetHashCode();
        }
    }

    #endregion

    public partial class BDTaskSetupControl : BaseControl
    {       
        #region Properties

        IList<BDTaskTemplateItemMapEntity> templateDocumentList = new List<BDTaskTemplateItemMapEntity>();
        IList<BDProjectCollectedDocumentInfoEntity> newProjectDocuments = new List<BDProjectCollectedDocumentInfoEntity>();

        TreeNodeCollection currentProjectNodes;
        TreeNodeCollection newProjectNodes;

        public IList<BDProjectCollectedDocumentInfoEntity> currentProjectDocuments
        {
            get
            {
                return (IList<BDProjectCollectedDocumentInfoEntity>)ViewState["vs_currentProjectDocuments"];
            }
            set
            {
                ViewState["vs_currentProjectDocuments"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDTaskTemplate(ddlTaskTemplateID, true);
            MiscUtil.PopulateHREmployee(ddlAssignedToEmployeeID, false);
            MiscUtil.PopulateBDProject(ddlProjectID, true);

            if (ddlAssignedToEmployeeID != null && ddlAssignedToEmployeeID.Items.Count > 0)
            {
                Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                if (employeeID > 0)
                {
                    ddlAssignedToEmployeeID.SelectedValue = employeeID.ToString();
                }
            }
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            treeTask.BuildTree();
        }

        private void PrepareEditView()
        {
            //String fe = SqlExpressionBuilder.PrepareFilterExpression(.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);

            //currentProjectDocuments = FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            // Setting check to the documents

            if (currentProjectDocuments != null && currentProjectDocuments.Count > 0)
            {
                foreach (TreeNode tn in treeTask.Nodes)
                {
                    IsDocumentNode(tn, 1);
                }
            }
            else
            {
                currentProjectDocuments = new List<BDProjectCollectedDocumentInfoEntity>();
            }

            currentProjectNodes = treeTask.CheckedNodes;
        }

        private BDProjectCollectedDocumentInfoEntity BuildBDProjectCollectedDocumentInfoEntity()
        {
            BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity = new BDProjectCollectedDocumentInfoEntity();
            //BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity = CurrentBDProjectCollectedDocumentInfoEntity;

            //if (ddlProjectID.Items.Count > 0)
            //{
            //    if (ddlProjectID.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        bDProjectCollectedDocumentInfoEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
            //    }
            //}

            //if (ddlProjectDocumentID.Items.Count > 0)
            //{
            //    if (ddlProjectDocumentID.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        bDProjectCollectedDocumentInfoEntity.ProjectDocumentID = Int64.Parse(ddlProjectDocumentID.SelectedValue);
            //    }
            //}

            //if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            //{
            //    bDProjectCollectedDocumentInfoEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            //}
            //else
            //{
            //    bDProjectCollectedDocumentInfoEntity.StartDate = null;
            //}

            //if (!txtRequiredTime.Text.Trim().IsNullOrEmpty())
            //{
            //    bDProjectCollectedDocumentInfoEntity.RequiredTime = Int32.Parse(txtRequiredTime.Text.Trim());
            //}
            //else
            //{
            //    bDProjectCollectedDocumentInfoEntity.RequiredTime = null;
            //}

            //if (!txtReminder.Text.Trim().IsNullOrEmpty())
            //{
            //    bDProjectCollectedDocumentInfoEntity.Reminder = Int32.Parse(txtReminder.Text.Trim());
            //}
            //else
            //{
            //    bDProjectCollectedDocumentInfoEntity.Reminder = null;
            //}

            //if (ddlProjectCollectedDocumentStatusID.Items.Count > 0)
            //{
            //    if (ddlProjectCollectedDocumentStatusID.SelectedValue == "0")
            //    {
            //        bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentStatusID = null;
            //    }
            //    else
            //    {
            //        bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentStatusID = Int64.Parse(ddlProjectCollectedDocumentStatusID.SelectedValue);
            //    }
            //}

            //bDProjectCollectedDocumentInfoEntity.Remarks = txtRemarks.Text.Trim();

            return bDProjectCollectedDocumentInfoEntity;
        }

        private void SaveBDProjectCollectedDocumentInfoEntity()
        {
            //if (IsValid)
            //{
            //    try
            //    {
            //        BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity = BuildBDProjectCollectedDocumentInfoEntity();

            //        Int64 result = -1;

            //        if (bDProjectCollectedDocumentInfoEntity.IsNew)
            //        {
            //            result = FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().Add(bDProjectCollectedDocumentInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
            //        }
            //        else
            //        {
            //            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentInfoEntity.FLD_NAME_ProjectCollectedDocumentInfoID, bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentInfoID.ToString(), SQLMatchType.Equal);
            //            result = FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().Update(bDProjectCollectedDocumentInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            //        }

            //        if (result > 0)
            //        {
            //            _ProjectCollectedDocumentInfoID = 0;
            //            _BDProjectCollectedDocumentInfoEntity = new BDProjectCollectedDocumentInfoEntity();
            //            PrepareInitialView();
            //            BindBDProjectCollectedDocumentInfoList();

            //            if (bDProjectCollectedDocumentInfoEntity.IsNew)
            //            {
            //                MiscUtil.ShowMessage(lblMessage, "Project Collected Document Info Information has been added successfully.", false);
            //            }
            //            else
            //            {
            //                MiscUtil.ShowMessage(lblMessage, "Project Collected Document Info Information has been updated successfully.", false);
            //            }
            //        }
            //        else
            //        {
            //            if (bDProjectCollectedDocumentInfoEntity.IsNew)
            //            {
            //                MiscUtil.ShowMessage(lblMessage, "Failed to add Project Collected Document Info Information.", false);
            //            }
            //            else
            //            {
            //                MiscUtil.ShowMessage(lblMessage, "Failed to update Project Collected Document Info Information.", false);
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            //    }
            //}
        }

        private void UpdateProjectDocument()
        {
            try
            {
                //newProjectNodes = treeTask.CheckedNodes;

                //foreach (TreeNode tn in treeTask.CheckedNodes)
                //{
                //    BayTreeNodeValue bayTreeNodeValue = new BayTreeNodeValue();
                //    bayTreeNodeValue.SetValuesFromString(tn.Value);

                //    BDProjectCollectedDocumentInfoEntity ent = new BDProjectCollectedDocumentInfoEntity();
                //    ent.ProjectDocumentID = Int64.Parse(bayTreeNodeValue.Value);
                //    ent.ProjectID = this.OverviewProjectID;
                //    newProjectDocuments.Add(ent);
                //}

                //IList<BDProjectCollectedDocumentInfoEntity> deleteList = currentProjectDocuments.Except(newProjectDocuments, new ProjectDocumentComparer()).ToList();
                //IList<BDProjectCollectedDocumentInfoEntity> addNewList = newProjectDocuments.Except(currentProjectDocuments, new ProjectDocumentComparer()).ToList();

                //if (deleteList != null && deleteList.Count > 0)
                //{
                //    foreach (BDProjectCollectedDocumentInfoEntity ent in deleteList)
                //    {
                //        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentInfoEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                //        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentInfoEntity.FLD_NAME_ProjectDocumentID, ent.ProjectDocumentID.ToString(), SQLMatchType.Equal);
                //        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                //        FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                //    }
                //}

                //if (addNewList != null && addNewList.Count > 0)
                //{
                //    foreach (BDProjectCollectedDocumentInfoEntity ent in addNewList)
                //    {
                //        FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                //    }
                //}

                //MiscUtil.ShowMessage(lblMessage, "Project Document Updated Successfully.", false);
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "An Error Occoured.", true);
            }
        }
        
        // listType - 1 means from project node, 2 means from template
        private void IsDocumentNode(TreeNode tn, Int32 listType)
        {
            BayTreeNodeValue bayTreeNodeValue = new BayTreeNodeValue();
            bayTreeNodeValue.SetValuesFromString(tn.Value);
            if (bayTreeNodeValue.Attributes["NodeType"] == CustomControlConstants.DocumentNodeType.Document)
            {
                Int64 id = Int64.Parse(bayTreeNodeValue.Value);

                if (listType == 1)
                {
                    var tempDocument = from s in currentProjectDocuments
                                       where s.ProjectDocumentID == id
                                       select s;

                    if (tempDocument != null && tempDocument.Count() > 0)
                    {
                        tn.Checked = true;
                    }
                    else
                    {
                        tn.Checked = false;
                    }
                }
                else
                {
                    if (templateDocumentList != null && templateDocumentList.Count > 0)
                    {
                        var tempDocument = from s in templateDocumentList
                                           where s.TaskID == id
                                           select s;

                        if (tempDocument != null && tempDocument.Count() > 0)
                        {
                            tn.Checked = true;
                        }
                        else
                        {
                            tn.Checked = false;
                        }
                    }
                }
            }
            else
            {
                foreach (TreeNode n in tn.ChildNodes)
                {
                    IsDocumentNode(n, listType);
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
               // PrepareEditView();
            }
        }

        #endregion

        #region DropDownList Events

        protected void ddlProjectDocumentTemplateID_SelectedIndexChanged(object sender, EventArgs e)
        {
            templateDocumentList = new List<BDTaskTemplateItemMapEntity>();

            Int64 projectDocumentTemplateID = 0;

            Int64.TryParse(ddlTaskTemplateID.SelectedValue, out projectDocumentTemplateID);

            // getting selected documents for template
            if (projectDocumentTemplateID > 0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(BDTaskTemplateItemMapEntity.FLD_NAME_TaskTemplateID, projectDocumentTemplateID.ToString(), SQLMatchType.Equal);
                templateDocumentList = FCCBDTaskTemplateItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            }

            // setting up node checks
            foreach (TreeNode tn in treeTask.Nodes)
            {
                IsDocumentNode(tn, 2);
            }
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder xmlStr = new StringBuilder();

                Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                String ip = MiscUtil.GetLocalIP();

                Int64 projectID = 0;

                if (ddlProjectID != null && ddlProjectID.SelectedValue != "0")
                {
                    projectID = Int64.Parse(ddlProjectID.SelectedValue);
                }

                xmlStr.Append("<m>");

                foreach (TreeNode tn in treeTask.CheckedNodes)
                {   
                    String subXmlStr = null;
                    subXmlStr = subXmlStr + "<i><a>" + tn.Text + "</a><b>" + employeeID + "</b><c>" + ddlAssignedToEmployeeID.SelectedValue + "</c><d>"+ip+"</d><e>"+CurrentMember.MemberID+"</e><f>"+ projectID +"</f></i>";
                    xmlStr.Append(subXmlStr.ToString());
                }
                xmlStr.Append("</m>");

                FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.TaskTemplateInfo);

                MiscUtil.ShowMessage(lblMessage, "Task Template Item Map Save Successfully.", false);
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
