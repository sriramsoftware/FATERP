// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2012, 10:59:14




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
    public partial class APWOPanelItemCategoryMapControl : BaseControl
    {       
        #region Properties

        public Int64 _APWOPanelItemCategoryMapID
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

        public APWOPanelItemCategoryMapEntity _APWOPanelItemCategoryMapEntity
        {
            get
            {
                APWOPanelItemCategoryMapEntity entity = new APWOPanelItemCategoryMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (APWOPanelItemCategoryMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private APWOPanelItemCategoryMapEntity CurrentAPWOPanelItemCategoryMapEntity
        {
            get
            {
                if (_APWOPanelItemCategoryMapID > 0)
                {
                    if (_APWOPanelItemCategoryMapEntity.APWOPanelItemCategoryMapID != _APWOPanelItemCategoryMapID)
                    {
                        _APWOPanelItemCategoryMapEntity = FCCAPWOPanelItemCategoryMap.GetFacadeCreate().GetByID(_APWOPanelItemCategoryMapID);
                    }
                }

                return _APWOPanelItemCategoryMapEntity;
            }
            set
            {
                _APWOPanelItemCategoryMapEntity = value;
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
            APWOPanelItemCategoryMapEntity aPWOPanelItemCategoryMapEntity = CurrentAPWOPanelItemCategoryMapEntity;


            if (!aPWOPanelItemCategoryMapEntity.IsNew)
            {
                if (ddlAPPanelID.Items.Count > 0 && aPWOPanelItemCategoryMapEntity.APPanelID != null)
                {
                    ddlAPPanelID.SelectedValue = aPWOPanelItemCategoryMapEntity.APPanelID.ToString();
                }

                if (ddlItemCategoryID.Items.Count > 0 && aPWOPanelItemCategoryMapEntity.ItemCategoryID != null)
                {
                    ddlItemCategoryID.SelectedValue = aPWOPanelItemCategoryMapEntity.ItemCategoryID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindAPWOPanelItemCategoryMapList();
        }

        private void BindAPWOPanelItemCategoryMapList()
        {
            lvAPWOPanelItemCategoryMap.DataBind();
        }

        private APWOPanelItemCategoryMapEntity BuildAPWOPanelItemCategoryMapEntity()
        {
            APWOPanelItemCategoryMapEntity aPWOPanelItemCategoryMapEntity = CurrentAPWOPanelItemCategoryMapEntity;

            if (ddlAPPanelID.Items.Count > 0)
            {
                if (ddlAPPanelID.SelectedValue == "0")
                {
                }
                else
                {
                    aPWOPanelItemCategoryMapEntity.APPanelID = Int64.Parse(ddlAPPanelID.SelectedValue);
                }
            }

            if (ddlItemCategoryID.Items.Count > 0)
            {
                if (ddlItemCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    aPWOPanelItemCategoryMapEntity.ItemCategoryID = Int64.Parse(ddlItemCategoryID.SelectedValue);
                }
            }


            return aPWOPanelItemCategoryMapEntity;
        }

        private void SaveAPWOPanelItemCategoryMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    APWOPanelItemCategoryMapEntity aPWOPanelItemCategoryMapEntity = BuildAPWOPanelItemCategoryMapEntity();

                    Int64 result = -1;

                    if (aPWOPanelItemCategoryMapEntity.IsNew)
                    {
                        result = FCCAPWOPanelItemCategoryMap.GetFacadeCreate().Add(aPWOPanelItemCategoryMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(APWOPanelItemCategoryMapEntity.FLD_NAME_APWOPanelItemCategoryMapID, aPWOPanelItemCategoryMapEntity.APWOPanelItemCategoryMapID.ToString(), SQLMatchType.Equal);
                        result = FCCAPWOPanelItemCategoryMap.GetFacadeCreate().Update(aPWOPanelItemCategoryMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _APWOPanelItemCategoryMapID = 0;
                        _APWOPanelItemCategoryMapEntity = new APWOPanelItemCategoryMapEntity();
                        PrepareInitialView();
                        BindAPWOPanelItemCategoryMapList();

                        if (aPWOPanelItemCategoryMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Work Order Panel Item Category Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Work Order Panel Item Category Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aPWOPanelItemCategoryMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Work Order Panel Item Category Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Work Order Panel Item Category Map Information.", false);
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

        protected void lvAPWOPanelItemCategoryMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 APWOPanelItemCategoryMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out APWOPanelItemCategoryMapID);

            if (APWOPanelItemCategoryMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _APWOPanelItemCategoryMapID = APWOPanelItemCategoryMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(APWOPanelItemCategoryMapEntity.FLD_NAME_APWOPanelItemCategoryMapID, APWOPanelItemCategoryMapID.ToString(), SQLMatchType.Equal);

                        APWOPanelItemCategoryMapEntity aPWOPanelItemCategoryMapEntity = new APWOPanelItemCategoryMapEntity();


                        result = FCCAPWOPanelItemCategoryMap.GetFacadeCreate().Delete(aPWOPanelItemCategoryMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _APWOPanelItemCategoryMapID = 0;
                            _APWOPanelItemCategoryMapEntity = new APWOPanelItemCategoryMapEntity();
                            PrepareInitialView();
                            BindAPWOPanelItemCategoryMapList();

                            MiscUtil.ShowMessage(lblMessage, "Work Order Panel Item Category Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Work Order Panel Item Category Map.", true);
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

        protected void odsAPWOPanelItemCategoryMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveAPWOPanelItemCategoryMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _APWOPanelItemCategoryMapID = 0;
            _APWOPanelItemCategoryMapEntity = new APWOPanelItemCategoryMapEntity();
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
