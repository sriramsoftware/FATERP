// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jan-2012, 04:09:33




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class CMProjectMilestoneViewControl : ProjectBaseControl
    {       
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

        public CMProjectMilestoneEntity _CMProjectMilestoneEntity
        {
            get
            {
                CMProjectMilestoneEntity entity = new CMProjectMilestoneEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMProjectMilestoneEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMProjectMilestoneEntity CurrentCMProjectMilestoneEntity
        {
            get
            {
                if (_ProjectMilestoneID > 0)
                {
                    if (_CMProjectMilestoneEntity.ProjectMilestoneID != _ProjectMilestoneID)
                    {
                        _CMProjectMilestoneEntity = FCCCMProjectMilestone.GetFacadeCreate().GetByID(_ProjectMilestoneID);
                    }
                }

                return _CMProjectMilestoneEntity;
            }
            set
            {
                _CMProjectMilestoneEntity = value;
            }
        }

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
            BuildDropDownList();

            BindList();
        }

        private void PrepareEditView()
        {
            CMProjectMilestoneEntity cMProjectMilestoneEntity = CurrentCMProjectMilestoneEntity;
        }

        private void BindList()
        {
            BindCMProjectMilestoneList();
        }

        private void BindCMProjectMilestoneList()
        {
            lvCMProjectMilestone.DataSource = FCCCMProjectMilestone_Custom.GetFacadeCreate().GetIL(this.OverviewProjectID);
            lvCMProjectMilestone.DataBind();
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

        #region List View Event

        protected void lvCMProjectMilestone_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectMilestoneID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectMilestoneID);

            if (ProjectMilestoneID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectMilestoneID = ProjectMilestoneID;

                    PrepareEditView();

                    
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMProjectMilestoneEntity.FLD_NAME_ProjectMilestoneID, ProjectMilestoneID.ToString(), SQLMatchType.Equal);

                        CMProjectMilestoneEntity cMProjectMilestoneEntity = new CMProjectMilestoneEntity();


                        result = FCCCMProjectMilestone.GetFacadeCreate().Delete(cMProjectMilestoneEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectMilestoneID = 0;
                            _CMProjectMilestoneEntity = new CMProjectMilestoneEntity();
                            PrepareInitialView();
                            BindCMProjectMilestoneList();

                           //MiscUtil.ShowMessage(lblMessage, "C MProject Milestone has been successfully deleted.", true);
                        }
                        else
                        {
                          //  MiscUtil.ShowMessage(lblMessage, "Failed to delete C MProject Milestone.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                       // MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsCMProjectMilestone_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //SaveCMProjectMilestoneEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectMilestoneID = 0;
            _CMProjectMilestoneEntity = new CMProjectMilestoneEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #endregion Event
    }
}
