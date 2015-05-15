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
    public partial class OTScheduleResourceControl : BaseControl
    {       
        #region Properties

        public Int64 _OTScheduleResourceID
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

        public OTScheduleResourceEntity _OTScheduleResourceEntity
        {
            get
            {
                OTScheduleResourceEntity entity = new OTScheduleResourceEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (OTScheduleResourceEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private OTScheduleResourceEntity CurrentOTScheduleResourceEntity
        {
            get
            {
                if (_OTScheduleResourceID > 0)
                {
                    if (_OTScheduleResourceEntity.OTScheduleResourceID != _OTScheduleResourceID)
                    {
                        _OTScheduleResourceEntity = FCCOTScheduleResource.GetFacadeCreate().GetByID(_OTScheduleResourceID);
                    }
                }

                return _OTScheduleResourceEntity;
            }
            set
            {
                _OTScheduleResourceEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateOTSchedule(ddlScheduleID, false);
            MiscUtil.PopulateResource(ddlResourceID, false);
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
            OTScheduleResourceEntity oTScheduleResourceEntity = CurrentOTScheduleResourceEntity;


            if (!oTScheduleResourceEntity.IsNew)
            {
                if (ddlScheduleID.Items.Count > 0 && oTScheduleResourceEntity.ScheduleID != null)
                {
                    ddlScheduleID.SelectedValue = oTScheduleResourceEntity.ScheduleID.ToString();
                }

                if (ddlResourceID.Items.Count > 0 && oTScheduleResourceEntity.ResourceID != null)
                {
                    ddlResourceID.SelectedValue = oTScheduleResourceEntity.ResourceID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindOTScheduleResourceList();
        }

        private void BindOTScheduleResourceList()
        {
            lvOTScheduleResource.DataBind();
        }

        private OTScheduleResourceEntity BuildOTScheduleResourceEntity()
        {
            OTScheduleResourceEntity oTScheduleResourceEntity = CurrentOTScheduleResourceEntity;

            if (ddlScheduleID.Items.Count > 0)
            {
                if (ddlScheduleID.SelectedValue == "0")
                {
                }
                else
                {
                    oTScheduleResourceEntity.ScheduleID = Int64.Parse(ddlScheduleID.SelectedValue);
                }
            }

            if (ddlResourceID.Items.Count > 0)
            {
                if (ddlResourceID.SelectedValue == "0")
                {
                }
                else
                {
                    oTScheduleResourceEntity.ResourceID = Int64.Parse(ddlResourceID.SelectedValue);
                }
            }


            return oTScheduleResourceEntity;
        }

        private void SaveOTScheduleResourceEntity()
        {
            if (IsValid)
            {
                try
                {
                    OTScheduleResourceEntity oTScheduleResourceEntity = BuildOTScheduleResourceEntity();

                    Int64 result = -1;

                    if (oTScheduleResourceEntity.IsNew)
                    {
                        result = FCCOTScheduleResource.GetFacadeCreate().Add(oTScheduleResourceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(OTScheduleResourceEntity.FLD_NAME_OTScheduleResourceID, oTScheduleResourceEntity.OTScheduleResourceID.ToString(), SQLMatchType.Equal);
                        result = FCCOTScheduleResource.GetFacadeCreate().Update(oTScheduleResourceEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _OTScheduleResourceID = 0;
                        _OTScheduleResourceEntity = new OTScheduleResourceEntity();
                        PrepareInitialView();
                        BindOTScheduleResourceList();

                        if (oTScheduleResourceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "O TSchedule Resource Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "O TSchedule Resource Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (oTScheduleResourceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add O TSchedule Resource Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update O TSchedule Resource Information.", false);
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

        protected void lvOTScheduleResource_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 OTScheduleResourceID;

            Int64.TryParse(e.CommandArgument.ToString(), out OTScheduleResourceID);

            if (OTScheduleResourceID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _OTScheduleResourceID = OTScheduleResourceID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTScheduleResourceEntity.FLD_NAME_OTScheduleResourceID, OTScheduleResourceID.ToString(), SQLMatchType.Equal);

                        OTScheduleResourceEntity oTScheduleResourceEntity = new OTScheduleResourceEntity();


                        result = FCCOTScheduleResource.GetFacadeCreate().Delete(oTScheduleResourceEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _OTScheduleResourceID = 0;
                            _OTScheduleResourceEntity = new OTScheduleResourceEntity();
                            PrepareInitialView();
                            BindOTScheduleResourceList();

                            MiscUtil.ShowMessage(lblMessage, "O TSchedule Resource has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete O TSchedule Resource.", true);
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

        protected void odsOTScheduleResource_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveOTScheduleResourceEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _OTScheduleResourceID = 0;
            _OTScheduleResourceEntity = new OTScheduleResourceEntity();
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
