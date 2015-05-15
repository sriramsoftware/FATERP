// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




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
    public partial class APPanelItemCategoryMapControl : BaseControl
    {       
        #region Properties

        public Int64 _APPanelItemCategoryMapID
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

        public APPanelItemCategoryMapEntity _APPanelItemCategoryMapEntity
        {
            get
            {
                APPanelItemCategoryMapEntity entity = new APPanelItemCategoryMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (APPanelItemCategoryMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private APPanelItemCategoryMapEntity CurrentAPPanelItemCategoryMapEntity
        {
            get
            {
                if (_APPanelItemCategoryMapID > 0)
                {
                    if (_APPanelItemCategoryMapEntity.APPanelItemCategoryMapID != _APPanelItemCategoryMapID)
                    {
                        _APPanelItemCategoryMapEntity = FCCAPPanelItemCategoryMap.GetFacadeCreate().GetByID(_APPanelItemCategoryMapID);
                    }
                }

                return _APPanelItemCategoryMapEntity;
            }
            set
            {
                _APPanelItemCategoryMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateAPPanel(ddlAPPanelID, false);
            MiscUtil.PopulateMDItemCategory(ddlItemCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();


            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            APPanelItemCategoryMapEntity aPPanelItemCategoryMapEntity = CurrentAPPanelItemCategoryMapEntity;


            if (!aPPanelItemCategoryMapEntity.IsNew)
            {
                if (ddlAPPanelID.Items.Count > 0 && aPPanelItemCategoryMapEntity.APPanelID != null)
                {
                    ddlAPPanelID.SelectedValue = aPPanelItemCategoryMapEntity.APPanelID.ToString();
                }

                if (ddlItemCategoryID.Items.Count > 0 && aPPanelItemCategoryMapEntity.ItemCategoryID != null)
                {
                    ddlItemCategoryID.SelectedValue = aPPanelItemCategoryMapEntity.ItemCategoryID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindAPPanelItemCategoryMapList();
        }

        private void BindAPPanelItemCategoryMapList()
        {
            lvAPPanelItemCategoryMap.DataBind();
        }

        private APPanelItemCategoryMapEntity BuildAPPanelItemCategoryMapEntity()
        {
            APPanelItemCategoryMapEntity aPPanelItemCategoryMapEntity = CurrentAPPanelItemCategoryMapEntity;

            if (ddlAPPanelID.Items.Count > 0)
            {
                if (ddlAPPanelID.SelectedValue == "0")
                {
                }
                else
                {
                    aPPanelItemCategoryMapEntity.APPanelID = Int64.Parse(ddlAPPanelID.SelectedValue);
                }
            }

            if (ddlItemCategoryID.Items.Count > 0)
            {
                if (ddlItemCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    aPPanelItemCategoryMapEntity.ItemCategoryID = Int64.Parse(ddlItemCategoryID.SelectedValue);
                }
            }


            return aPPanelItemCategoryMapEntity;
        }

        private void SaveAPPanelItemCategoryMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    APPanelItemCategoryMapEntity aPPanelItemCategoryMapEntity = BuildAPPanelItemCategoryMapEntity();

                    Int64 result = -1;

                    if (aPPanelItemCategoryMapEntity.IsNew)
                    {
                        result = FCCAPPanelItemCategoryMap.GetFacadeCreate().Add(aPPanelItemCategoryMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(APPanelItemCategoryMapEntity.FLD_NAME_APPanelItemCategoryMapID, aPPanelItemCategoryMapEntity.APPanelItemCategoryMapID.ToString(), SQLMatchType.Equal);
                        result = FCCAPPanelItemCategoryMap.GetFacadeCreate().Update(aPPanelItemCategoryMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _APPanelItemCategoryMapID = 0;
                        _APPanelItemCategoryMapEntity = new APPanelItemCategoryMapEntity();
                        PrepareInitialView();
                        BindAPPanelItemCategoryMapList();

                        if (aPPanelItemCategoryMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PPanel Item Category Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PPanel Item Category Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aPPanelItemCategoryMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A PPanel Item Category Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A PPanel Item Category Map Information.", false);
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

        protected void lvAPPanelItemCategoryMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 APPanelItemCategoryMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out APPanelItemCategoryMapID);

            if (APPanelItemCategoryMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _APPanelItemCategoryMapID = APPanelItemCategoryMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(APPanelItemCategoryMapEntity.FLD_NAME_APPanelItemCategoryMapID, APPanelItemCategoryMapID.ToString(), SQLMatchType.Equal);

                        APPanelItemCategoryMapEntity aPPanelItemCategoryMapEntity = new APPanelItemCategoryMapEntity();


                        result = FCCAPPanelItemCategoryMap.GetFacadeCreate().Delete(aPPanelItemCategoryMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _APPanelItemCategoryMapID = 0;
                            _APPanelItemCategoryMapEntity = new APPanelItemCategoryMapEntity();
                            PrepareInitialView();
                            BindAPPanelItemCategoryMapList();

                            MiscUtil.ShowMessage(lblMessage, "A PPanel Item Category Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A PPanel Item Category Map.", true);
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

        protected void odsAPPanelItemCategoryMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveAPPanelItemCategoryMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _APPanelItemCategoryMapID = 0;
            _APPanelItemCategoryMapEntity = new APPanelItemCategoryMapEntity();
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
