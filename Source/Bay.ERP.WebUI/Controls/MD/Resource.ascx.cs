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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class ResourceControl : BaseControl
    {       
        #region Properties

        public Int64 _ResourceID
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

        public ResourceEntity _ResourceEntity
        {
            get
            {
                ResourceEntity entity = new ResourceEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ResourceEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ResourceEntity CurrentResourceEntity
        {
            get
            {
                if (_ResourceID > 0)
                {
                    if (_ResourceEntity.ResourceID != _ResourceID)
                    {
                        _ResourceEntity = FCCResource.GetFacadeCreate().GetByID(_ResourceID);
                    }
                }

                return _ResourceEntity;
            }
            set
            {
                _ResourceEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDResourceCategory(ddlResourceCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtReferenceID.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ResourceEntity resourceEntity = CurrentResourceEntity;


            if (!resourceEntity.IsNew)
            {
                if (ddlResourceCategoryID.Items.Count > 0 && resourceEntity.ResourceCategoryID != null)
                {
                    ddlResourceCategoryID.SelectedValue = resourceEntity.ResourceCategoryID.ToString();
                }

                txtReferenceID.Text = resourceEntity.ReferenceID.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindResourceList();
        }

        private void BindResourceList()
        {
            lvResource.DataBind();
        }

        private ResourceEntity BuildResourceEntity()
        {
            ResourceEntity resourceEntity = CurrentResourceEntity;

            if (ddlResourceCategoryID.Items.Count > 0)
            {
                if (ddlResourceCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    resourceEntity.ResourceCategoryID = Int64.Parse(ddlResourceCategoryID.SelectedValue);
                }
            }

            if (!txtReferenceID.Text.Trim().IsNullOrEmpty())
            {
                resourceEntity.ReferenceID = Int64.Parse(txtReferenceID.Text.Trim());
            }


            return resourceEntity;
        }

        private void SaveResourceEntity()
        {
            if (IsValid)
            {
                try
                {
                    ResourceEntity resourceEntity = BuildResourceEntity();

                    Int64 result = -1;

                    if (resourceEntity.IsNew)
                    {
                        result = FCCResource.GetFacadeCreate().Add(resourceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceID, resourceEntity.ResourceID.ToString(), SQLMatchType.Equal);
                        result = FCCResource.GetFacadeCreate().Update(resourceEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ResourceID = 0;
                        _ResourceEntity = new ResourceEntity();
                        PrepareInitialView();
                        BindResourceList();

                        if (resourceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Resource Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Resource Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (resourceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Resource Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Resource Information.", false);
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

        protected void lvResource_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ResourceID;

            Int64.TryParse(e.CommandArgument.ToString(), out ResourceID);

            if (ResourceID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ResourceID = ResourceID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceID, ResourceID.ToString(), SQLMatchType.Equal);

                        ResourceEntity resourceEntity = new ResourceEntity();


                        result = FCCResource.GetFacadeCreate().Delete(resourceEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ResourceID = 0;
                            _ResourceEntity = new ResourceEntity();
                            PrepareInitialView();
                            BindResourceList();

                            MiscUtil.ShowMessage(lblMessage, "Resource has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Resource.", true);
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

        protected void odsResource_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveResourceEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ResourceID = 0;
            _ResourceEntity = new ResourceEntity();
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
