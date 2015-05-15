// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public partial class CRMMDCommuicationDiscussionTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _CommuicationDiscussionTypeID
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

        public CRMMDCommuicationDiscussionTypeEntity _CRMMDCommuicationDiscussionTypeEntity
        {
            get
            {
                CRMMDCommuicationDiscussionTypeEntity entity = new CRMMDCommuicationDiscussionTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDCommuicationDiscussionTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDCommuicationDiscussionTypeEntity CurrentCRMMDCommuicationDiscussionTypeEntity
        {
            get
            {
                if (_CommuicationDiscussionTypeID > 0)
                {
                    if (_CRMMDCommuicationDiscussionTypeEntity.CommuicationDiscussionTypeID != _CommuicationDiscussionTypeID)
                    {
                        _CRMMDCommuicationDiscussionTypeEntity = FCCCRMMDCommuicationDiscussionType.GetFacadeCreate().GetByID(_CommuicationDiscussionTypeID);
                    }
                }

                return _CRMMDCommuicationDiscussionTypeEntity;
            }
            set
            {
                _CRMMDCommuicationDiscussionTypeEntity = value;
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

            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMMDCommuicationDiscussionTypeEntity cRMMDCommuicationDiscussionTypeEntity = CurrentCRMMDCommuicationDiscussionTypeEntity;


            if (!cRMMDCommuicationDiscussionTypeEntity.IsNew)
            {
                txtName.Text = cRMMDCommuicationDiscussionTypeEntity.Name.ToString();
                txtDescription.Text = cRMMDCommuicationDiscussionTypeEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDCommuicationDiscussionTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDCommuicationDiscussionTypeList();
        }

        private void BindCRMMDCommuicationDiscussionTypeList()
        {
            lvCRMMDCommuicationDiscussionType.DataBind();
        }

        private CRMMDCommuicationDiscussionTypeEntity BuildCRMMDCommuicationDiscussionTypeEntity()
        {
            CRMMDCommuicationDiscussionTypeEntity cRMMDCommuicationDiscussionTypeEntity = CurrentCRMMDCommuicationDiscussionTypeEntity;

            cRMMDCommuicationDiscussionTypeEntity.Name = txtName.Text.Trim();
            cRMMDCommuicationDiscussionTypeEntity.Description = txtDescription.Text.Trim();
            cRMMDCommuicationDiscussionTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDCommuicationDiscussionTypeEntity;
        }

        private void SaveCRMMDCommuicationDiscussionTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDCommuicationDiscussionTypeEntity cRMMDCommuicationDiscussionTypeEntity = BuildCRMMDCommuicationDiscussionTypeEntity();

                    Int64 result = -1;

                    if (cRMMDCommuicationDiscussionTypeEntity.IsNew)
                    {
                        result = FCCCRMMDCommuicationDiscussionType.GetFacadeCreate().Add(cRMMDCommuicationDiscussionTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDCommuicationDiscussionTypeEntity.FLD_NAME_CommuicationDiscussionTypeID, cRMMDCommuicationDiscussionTypeEntity.CommuicationDiscussionTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDCommuicationDiscussionType.GetFacadeCreate().Update(cRMMDCommuicationDiscussionTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CommuicationDiscussionTypeID = 0;
                        _CRMMDCommuicationDiscussionTypeEntity = new CRMMDCommuicationDiscussionTypeEntity();
                        PrepareInitialView();
                        BindCRMMDCommuicationDiscussionTypeList();

                        if (cRMMDCommuicationDiscussionTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMCommuication Discussion Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMCommuication Discussion Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDCommuicationDiscussionTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMCommuication Discussion Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMCommuication Discussion Type Information.", false);
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

        protected void lvCRMMDCommuicationDiscussionType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CommuicationDiscussionTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out CommuicationDiscussionTypeID);

            if (CommuicationDiscussionTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CommuicationDiscussionTypeID = CommuicationDiscussionTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDCommuicationDiscussionTypeEntity.FLD_NAME_CommuicationDiscussionTypeID, CommuicationDiscussionTypeID.ToString(), SQLMatchType.Equal);

                        CRMMDCommuicationDiscussionTypeEntity cRMMDCommuicationDiscussionTypeEntity = new CRMMDCommuicationDiscussionTypeEntity();


                        result = FCCCRMMDCommuicationDiscussionType.GetFacadeCreate().Delete(cRMMDCommuicationDiscussionTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CommuicationDiscussionTypeID = 0;
                            _CRMMDCommuicationDiscussionTypeEntity = new CRMMDCommuicationDiscussionTypeEntity();
                            PrepareInitialView();
                            BindCRMMDCommuicationDiscussionTypeList();

                            MiscUtil.ShowMessage(lblMessage, "C RMCommuication Discussion Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMCommuication Discussion Type.", true);
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

        protected void odsCRMMDCommuicationDiscussionType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDCommuicationDiscussionTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CommuicationDiscussionTypeID = 0;
            _CRMMDCommuicationDiscussionTypeEntity = new CRMMDCommuicationDiscussionTypeEntity();
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
