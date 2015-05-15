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
    public partial class OTProjectIssueListControl : BaseControl
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

        public Int64 CMProjectScheduleTemplateID
        {
            get
            {
                Int64 cMProjectScheduleTemplateID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[CMProjectScheduleTemplateEntity.FLD_NAME_ProjectScheduleTemplateID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[CMProjectScheduleTemplateEntity.FLD_NAME_ProjectScheduleTemplateID], out cMProjectScheduleTemplateID);
                }

                return cMProjectScheduleTemplateID;
            }
        }

        public IList<CMProjectScheduleTemplateItemMapEntity> _CMProjectScheduleTemplateItemMapEntity
        {
            get
            {
                return (IList<CMProjectScheduleTemplateItemMapEntity>)ViewState["CurrentEntity"];
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMProjectScheduleTemplateItemMapEntity CurrentCMProjectScheduleTemplateItemMapEntity
        {
            get
            {
                return (CMProjectScheduleTemplateItemMapEntity)ViewState["vs_currentTemplateItemMap"];
            }
            set
            {
                ViewState["vs_currentTemplateItemMap"] = value;
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

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialViewForm()
        {
            BuildDropDownList();

            CMProjectScheduleTemplateItemMapEntity cMProjectScheduleTemplateMapEntity = CurrentCMProjectScheduleTemplateItemMapEntity;
            //if (!cMProjectScheduleTemplateMapEntity.IsNew)
            //{
            //    if (ddlIssuePriorityID.Items.Count > 0 && cMProjectScheduleTemplateMapEntity.IssuePriorityID != null)
            //    {
            //        ddlIssuePriorityID.SelectedValue = cMProjectScheduleTemplateMapEntity.IssuePriorityID.ToString();
            //    }

            //    txtDuration.Text = cMProjectScheduleTemplateMapEntity.Duration.ToString();
            //    txtNotifyBeforeMin.Text = cMProjectScheduleTemplateMapEntity.NotifyBeforeMin.ToString();
            //}
            //else
            //{
            //    txtDuration.Text = String.Empty;
            //    txtNotifyBeforeMin.Text = String.Empty;
            //}

            //btnSubmit.Text = "Update";
        }

        private void PrepareInitialView()
        {
           
            
        }

        private void IsDocumentNode(TreeNode tn)
        {
            if (tn.ChildNodes.Count==0)
            {
                Int64 id = Int64.Parse(tn.Value);

                var tempDocument = (from s in currentMappedScheduleItem
                                    where s.ProjectScheduleItemID == id
                                    select s);

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

        private void PrepareEditView()
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMProjectScheduleTemplateItemMapEntity.FLD_NAME_ProjectScheduleTemplateID, CMProjectScheduleTemplateID.ToString(), SQLMatchType.Equal);

            currentMappedScheduleItem = FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            #region Setting check to the Schedule Item

            if (currentMappedScheduleItem != null && currentMappedScheduleItem.Count > 0)
            {
                foreach (TreeNode tn in treeProjectSchedule.Nodes)
                {
                    IsDocumentNode(tn);
                }
            }
            else
            {
                currentMappedScheduleItem = new List<CMProjectScheduleTemplateItemMapEntity>();
            }

           #endregion
        }

        private void PrepareEditViewForm()
        {
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CMProjectScheduleTemplateItemMapEntity.FLD_NAME_ProjectScheduleTemplateID, CMProjectScheduleTemplateID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CMProjectScheduleTemplateItemMapEntity.FLD_NAME_ProjectScheduleItemID, treeProjectSchedule.SelectedValue.ToString(), SQLMatchType.Equal);

            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            _CMProjectScheduleTemplateItemMapEntity = FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            #region Setting check to the Schedule Item

            if (_CMProjectScheduleTemplateItemMapEntity != null && _CMProjectScheduleTemplateItemMapEntity.Count > 0)
            {
                CurrentCMProjectScheduleTemplateItemMapEntity = _CMProjectScheduleTemplateItemMapEntity[0];
            }
            else
            {
                CurrentCMProjectScheduleTemplateItemMapEntity = new CMProjectScheduleTemplateItemMapEntity();
            }

            #endregion
        }
        private void BindList()
        {
            BindCMProjectScheduleTemplateItemMapList();
        }

        private void BindCMProjectScheduleTemplateItemMapList()
        {
            
        }

        private CMProjectScheduleTemplateItemMapEntity BuildCMProjectScheduleTemplateItemMapEntity()
        {
            CMProjectScheduleTemplateItemMapEntity cMProjectScheduleTemplateItemMapEntity = CurrentCMProjectScheduleTemplateItemMapEntity;

            //cMProjectScheduleTemplateItemMapEntity.ProjectScheduleTemplateID = CMProjectScheduleTemplateID;
            //cMProjectScheduleTemplateItemMapEntity.ProjectScheduleItemID = Int32.Parse(treeProjectSchedule.SelectedValue.ToString());

            //if (!txtNotifyBeforeMin.Text.Trim().IsNullOrEmpty())
            //{
            //    cMProjectScheduleTemplateItemMapEntity.NotifyBeforeMin = Int32.Parse(txtNotifyBeforeMin.Text.Trim());
            //}
            //else
            //{
            //    cMProjectScheduleTemplateItemMapEntity.NotifyBeforeMin = null;
            //}

            //if (ddlIssuePriorityID.Items.Count > 0)
            //{
            //    if (ddlIssuePriorityID.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        cMProjectScheduleTemplateItemMapEntity.IssuePriorityID = Int64.Parse(ddlIssuePriorityID.SelectedValue);
            //    }
            //}

            //if (!txtDuration.Text.Trim().IsNullOrEmpty())
            //{
            //    cMProjectScheduleTemplateItemMapEntity.Duration = Decimal.Parse(txtDuration.Text.Trim());
            //}
            //else
            //{
            //    cMProjectScheduleTemplateItemMapEntity.Duration = null;
            //}


            return cMProjectScheduleTemplateItemMapEntity;
        }

        private void SaveCMProjectScheduleTemplateItemMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMProjectScheduleTemplateItemMapEntity cMProjectScheduleTemplateItemMapEntity = BuildCMProjectScheduleTemplateItemMapEntity();

                    Int64 result = -1;

                    if (cMProjectScheduleTemplateItemMapEntity.IsNew)
                    {
                        result = FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().Add(cMProjectScheduleTemplateItemMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMProjectScheduleTemplateItemMapEntity.FLD_NAME_ProjectScheduleTemplateItemMapID, cMProjectScheduleTemplateItemMapEntity.ProjectScheduleTemplateItemMapID.ToString(), SQLMatchType.Equal);
                        result = FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().Update(cMProjectScheduleTemplateItemMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        //_ProjectScheduleTemplateItemMapID = 0;
                        //_CMProjectScheduleTemplateItemMapEntity = new List<CMProjectScheduleTemplateItemMapEntity>();
                        //PrepareInitialViewForm();
                        //BindCMProjectScheduleTemplateItemMapList();

                        if (cMProjectScheduleTemplateItemMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MProject Schedule Template Item Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MProject Schedule Template Item Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMProjectScheduleTemplateItemMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MProject Schedule Template Item Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MProject Schedule Template Item Map Information.", false);
                        }
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

        #region Tree Events

        protected void treeProjectSchedule_SelectedNodeChanged(object sender, EventArgs e)
        {
            
            if (treeProjectSchedule.SelectedNode.ChildNodes.Count==0)
            {
                ///divUpdatePanel.Visible = true;
                PrepareEditViewForm();
                PrepareInitialViewForm();
                
            }
          
        }

        #endregion

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                treeProjectSchedule.ShowCheckBoxes = TreeNodeTypes.Leaf;
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
                foreach (TreeNode tn in treeProjectSchedule.CheckedNodes)
                {
                    CMProjectScheduleTemplateItemMapEntity ent = new CMProjectScheduleTemplateItemMapEntity();
                    ent.ProjectScheduleItemID = Int64.Parse(tn.Value);
                    ent.ProjectScheduleTemplateID = CMProjectScheduleTemplateID;
                    ent.IssuePriorityID = Int32.Parse("1");
                    newMappedScheduleItems.Add(ent);
                }

                IList<CMProjectScheduleTemplateItemMapEntity> deleteList = currentMappedScheduleItem.Except(newMappedScheduleItems, new CustomerComparer()).ToList();
                IList<CMProjectScheduleTemplateItemMapEntity> addNewList = newMappedScheduleItems.Except(currentMappedScheduleItem, new CustomerComparer()).ToList();

                if (deleteList != null && deleteList.Count > 0)
                {
                    foreach (CMProjectScheduleTemplateItemMapEntity ent in deleteList)
                    {
                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CMProjectScheduleTemplateItemMapEntity.FLD_NAME_ProjectScheduleTemplateID, ent.ProjectScheduleTemplateID.ToString(), SQLMatchType.Equal);
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CMProjectScheduleTemplateItemMapEntity.FLD_NAME_ProjectScheduleItemID, ent.ProjectScheduleItemID.ToString(), SQLMatchType.Equal);
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                        FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                    }
                }

                if (addNewList != null && addNewList.Count > 0)
                {
                    foreach (CMProjectScheduleTemplateItemMapEntity ent in addNewList)
                    {
                        FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                }

                MiscUtil.ShowMessage(lblMessage, "Project Schedule Template Item Map Information has been added successfully.", false);
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
