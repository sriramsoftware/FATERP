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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Linq;

namespace Bay.ERP.Web.UI
{
    public partial class BDProjectFloorControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectFloorID
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

        public BDProjectFloorEntity _BDProjectFloorEntity
        {
            get
            {
                BDProjectFloorEntity entity = new BDProjectFloorEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectFloorEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectFloorEntity CurrentBDProjectFloorEntity
        {
            get
            {
                if (_ProjectFloorID > 0)
                {
                    if (_BDProjectFloorEntity.ProjectFloorID != _ProjectFloorID)
                    {
                        _BDProjectFloorEntity = FCCBDProjectFloor.GetFacadeCreate().GetByID(_ProjectFloorID);
                    }
                }

                return _BDProjectFloorEntity;
            }
            set
            {
                _BDProjectFloorEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDFloorCategory(ddlFloorCategoryID, false);
            BuildMDFloorByFloorCategory();
        }

        private void BuildMDFloorByFloorCategory()
        {
            if (ddlFloorCategoryID.SelectedValue != "0")
            {
                MiscUtil.PopulateMDFloorByFloorCategoryID(ddlFloorID, false, Int64.Parse(ddlFloorCategoryID.SelectedValue));
            }
        }


        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtSize.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDProjectFloorEntity bDProjectFloorEntity = CurrentBDProjectFloorEntity;

            if (!bDProjectFloorEntity.IsNew)
            {   

                if (ddlFloorCategoryID.Items.Count > 0 && bDProjectFloorEntity.FloorCategoryID != null)
                {
                    ddlFloorCategoryID.SelectedValue = bDProjectFloorEntity.FloorCategoryID.ToString();
                }

                BuildMDFloorByFloorCategory();

                if (ddlFloorID.Items.Count > 0 && bDProjectFloorEntity.FloorID != null)
                {
                    ddlFloorID.SelectedValue = bDProjectFloorEntity.FloorID.ToString();
                }

                txtName.Text = bDProjectFloorEntity.Name.ToString();
                txtSize.Text = bDProjectFloorEntity.Size.ToString();
                txtDescription.Text = bDProjectFloorEntity.Description.ToString();
                chkIsRemoved.Checked = bDProjectFloorEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDProjectFloorList();
        }

        private void BindBDProjectFloorList()
        {
            lvBDProjectFloor.DataBind();
        }

        private BDProjectFloorEntity BuildBDProjectFloorEntity()
        {
            BDProjectFloorEntity bDProjectFloorEntity = CurrentBDProjectFloorEntity;

            bDProjectFloorEntity.ProjectID = this.OverviewProjectID;

            if (ddlFloorCategoryID.Items.Count > 0)
            {
                if (ddlFloorCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectFloorEntity.FloorCategoryID = Int64.Parse(ddlFloorCategoryID.SelectedValue);
                }
            }

            if (ddlFloorID.Items.Count > 0)
            {
                if (ddlFloorID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectFloorEntity.FloorID = Int64.Parse(ddlFloorID.SelectedValue);
                }
            }

            IList<MDFloorEntity> lst = FCCMDFloor.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            MDFloorEntity mDFloorEntity = lst.Where(x => x.FloorID == bDProjectFloorEntity.FloorID).Single();

            bDProjectFloorEntity.Name = mDFloorEntity.Name;
            if (!txtSize.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorEntity.Size = Int32.Parse(txtSize.Text.Trim());
            }

            bDProjectFloorEntity.Description = txtDescription.Text.Trim();
            bDProjectFloorEntity.IsRemoved = chkIsRemoved.Checked;


            return bDProjectFloorEntity;
        }

        private void SaveBDProjectFloorEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectFloorEntity bDProjectFloorEntity = BuildBDProjectFloorEntity();

                    Int64 result = -1;

                    if (bDProjectFloorEntity.IsNew)
                    {
                        result = FCCBDProjectFloor.GetFacadeCreate().Add(bDProjectFloorEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorEntity.FLD_NAME_ProjectFloorID, bDProjectFloorEntity.ProjectFloorID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectFloor.GetFacadeCreate().Update(bDProjectFloorEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectFloorID = 0;
                        _BDProjectFloorEntity = new BDProjectFloorEntity();
                        PrepareInitialView();
                        BindBDProjectFloorList();

                        if (bDProjectFloorEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Floor Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Floor Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectFloorEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Floor Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Floor Information.", false);
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

        protected void lvBDProjectFloor_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectFloorID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectFloorID);

            if (ProjectFloorID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectFloorID = ProjectFloorID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorEntity.FLD_NAME_ProjectFloorID, ProjectFloorID.ToString(), SQLMatchType.Equal);

                        BDProjectFloorEntity bDProjectFloorEntity = new BDProjectFloorEntity();


                        result = FCCBDProjectFloor.GetFacadeCreate().Delete(bDProjectFloorEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectFloorID = 0;
                            _BDProjectFloorEntity = new BDProjectFloorEntity();
                            PrepareInitialView();
                            BindBDProjectFloorList();

                            MiscUtil.ShowMessage(lblMessage, "Project Floor has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Floor.", true);
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

        protected void odsBDProjectFloor_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("BDProjectFloor." + BDProjectFloorEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProjectFloorEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectFloorID = 0;
            _BDProjectFloorEntity = new BDProjectFloorEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlFloorCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildMDFloorByFloorCategory();
        }

        #endregion

        #endregion Event
    }
}
