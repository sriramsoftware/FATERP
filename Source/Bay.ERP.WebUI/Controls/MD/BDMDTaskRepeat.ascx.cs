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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class BDMDTaskRepeatControl : BaseControl
    {       
        #region Properties

        public Int64 _TaskRepeatID
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

        public BDMDTaskRepeatEntity _BDMDTaskRepeatEntity
        {
            get
            {
                BDMDTaskRepeatEntity entity = new BDMDTaskRepeatEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDMDTaskRepeatEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDMDTaskRepeatEntity CurrentBDMDTaskRepeatEntity
        {
            get
            {
                if (_TaskRepeatID > 0)
                {
                    if (_BDMDTaskRepeatEntity.TaskRepeatID != _TaskRepeatID)
                    {
                        _BDMDTaskRepeatEntity = FCCBDMDTaskRepeat.GetFacadeCreate().GetByID(_TaskRepeatID);
                    }
                }

                return _BDMDTaskRepeatEntity;
            }
            set
            {
                _BDMDTaskRepeatEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDMDTask(ddlTaskID, false);
            MiscUtil.PopulateBDMDRepeatCategory(ddlRepeatCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtRepeatEvery.Text = String.Empty;
            txtStartsOn.Text = String.Empty;
            txtEndsOn.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDMDTaskRepeatEntity bDMDTaskRepeatEntity = CurrentBDMDTaskRepeatEntity;


            if (!bDMDTaskRepeatEntity.IsNew)
            {
                if (ddlTaskID.Items.Count > 0 && bDMDTaskRepeatEntity.TaskID != null)
                {
                    ddlTaskID.SelectedValue = bDMDTaskRepeatEntity.TaskID.ToString();
                }

                if (ddlRepeatCategoryID.Items.Count > 0 && bDMDTaskRepeatEntity.RepeatCategoryID != null)
                {
                    ddlRepeatCategoryID.SelectedValue = bDMDTaskRepeatEntity.RepeatCategoryID.ToString();
                }

                txtRepeatEvery.Text = bDMDTaskRepeatEntity.RepeatEvery.ToString();
                txtStartsOn.Text = bDMDTaskRepeatEntity.StartsOn.ToStringDefault();
                txtEndsOn.Text = bDMDTaskRepeatEntity.EndsOn.ToStringDefault();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDMDTaskRepeatList();
        }

        private void BindBDMDTaskRepeatList()
        {
            lvBDMDTaskRepeat.DataBind();
        }

        private BDMDTaskRepeatEntity BuildBDMDTaskRepeatEntity()
        {
            BDMDTaskRepeatEntity bDMDTaskRepeatEntity = CurrentBDMDTaskRepeatEntity;

            if (ddlTaskID.Items.Count > 0)
            {
                if (ddlTaskID.SelectedValue == "0")
                {
                }
                else
                {
                    bDMDTaskRepeatEntity.TaskID = Int64.Parse(ddlTaskID.SelectedValue);
                }
            }

            if (ddlRepeatCategoryID.Items.Count > 0)
            {
                if (ddlRepeatCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    bDMDTaskRepeatEntity.RepeatCategoryID = Int64.Parse(ddlRepeatCategoryID.SelectedValue);
                }
            }

            if (!txtRepeatEvery.Text.Trim().IsNullOrEmpty())
            {
                bDMDTaskRepeatEntity.RepeatEvery = Int32.Parse(txtRepeatEvery.Text.Trim());
            }

            if (txtStartsOn.Text.Trim().IsNotNullOrEmpty())
            {
                bDMDTaskRepeatEntity.StartsOn = MiscUtil.ParseToDateTime(txtStartsOn.Text);
            }

            if (txtEndsOn.Text.Trim().IsNotNullOrEmpty())
            {
                bDMDTaskRepeatEntity.EndsOn = MiscUtil.ParseToDateTime(txtEndsOn.Text);
            }
            else
            {
                bDMDTaskRepeatEntity.EndsOn = null;
            }


            return bDMDTaskRepeatEntity;
        }

        private void SaveBDMDTaskRepeatEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDMDTaskRepeatEntity bDMDTaskRepeatEntity = BuildBDMDTaskRepeatEntity();

                    Int64 result = -1;

                    if (bDMDTaskRepeatEntity.IsNew)
                    {
                        result = FCCBDMDTaskRepeat.GetFacadeCreate().Add(bDMDTaskRepeatEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDMDTaskRepeatEntity.FLD_NAME_TaskRepeatID, bDMDTaskRepeatEntity.TaskRepeatID.ToString(), SQLMatchType.Equal);
                        result = FCCBDMDTaskRepeat.GetFacadeCreate().Update(bDMDTaskRepeatEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _TaskRepeatID = 0;
                        _BDMDTaskRepeatEntity = new BDMDTaskRepeatEntity();
                        PrepareInitialView();
                        BindBDMDTaskRepeatList();

                        if (bDMDTaskRepeatEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Task Repeat Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Task Repeat Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDMDTaskRepeatEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Task Repeat Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Task Repeat Information.", false);
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

        protected void lvBDMDTaskRepeat_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TaskRepeatID;

            Int64.TryParse(e.CommandArgument.ToString(), out TaskRepeatID);

            if (TaskRepeatID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _TaskRepeatID = TaskRepeatID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDMDTaskRepeatEntity.FLD_NAME_TaskRepeatID, TaskRepeatID.ToString(), SQLMatchType.Equal);

                        BDMDTaskRepeatEntity bDMDTaskRepeatEntity = new BDMDTaskRepeatEntity();


                        result = FCCBDMDTaskRepeat.GetFacadeCreate().Delete(bDMDTaskRepeatEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _TaskRepeatID = 0;
                            _BDMDTaskRepeatEntity = new BDMDTaskRepeatEntity();
                            PrepareInitialView();
                            BindBDMDTaskRepeatList();

                            MiscUtil.ShowMessage(lblMessage, "Task Repeat has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Task Repeat.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsBDMDTaskRepeat_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDMDTaskRepeatEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _TaskRepeatID = 0;
            _BDMDTaskRepeatEntity = new BDMDTaskRepeatEntity();
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
