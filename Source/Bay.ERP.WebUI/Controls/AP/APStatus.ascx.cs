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
    public partial class APStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _APStatusID
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

        public APStatusEntity _APStatusEntity
        {
            get
            {
                APStatusEntity entity = new APStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (APStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private APStatusEntity CurrentAPStatusEntity
        {
            get
            {
                if (_APStatusID > 0)
                {
                    if (_APStatusEntity.APStatusID != _APStatusID)
                    {
                        _APStatusEntity = FCCAPStatus.GetFacadeCreate().GetByID(_APStatusID);
                    }
                }

                return _APStatusEntity;
            }
            set
            {
                _APStatusEntity = value;
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
            APStatusEntity aPStatusEntity = CurrentAPStatusEntity;


            if (!aPStatusEntity.IsNew)
            {
                txtName.Text = aPStatusEntity.Name.ToString();
                txtDescription.Text = aPStatusEntity.Description.ToString();
                chkIsRemoved.Checked = aPStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindAPStatusList();
        }

        private void BindAPStatusList()
        {
            lvAPStatus.DataBind();
        }

        private APStatusEntity BuildAPStatusEntity()
        {
            APStatusEntity aPStatusEntity = CurrentAPStatusEntity;

            aPStatusEntity.Name = txtName.Text.Trim();
            aPStatusEntity.Description = txtDescription.Text.Trim();
            aPStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return aPStatusEntity;
        }

        private void SaveAPStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    APStatusEntity aPStatusEntity = BuildAPStatusEntity();

                    Int64 result = -1;

                    if (aPStatusEntity.IsNew)
                    {
                        result = FCCAPStatus.GetFacadeCreate().Add(aPStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(APStatusEntity.FLD_NAME_APStatusID, aPStatusEntity.APStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCAPStatus.GetFacadeCreate().Update(aPStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _APStatusID = 0;
                        _APStatusEntity = new APStatusEntity();
                        PrepareInitialView();
                        BindAPStatusList();

                        if (aPStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PStatus Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PStatus Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aPStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A PStatus Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A PStatus Information.", false);
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

        protected void lvAPStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 APStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out APStatusID);

            if (APStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _APStatusID = APStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(APStatusEntity.FLD_NAME_APStatusID, APStatusID.ToString(), SQLMatchType.Equal);

                        APStatusEntity aPStatusEntity = new APStatusEntity();


                        result = FCCAPStatus.GetFacadeCreate().Delete(aPStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _APStatusID = 0;
                            _APStatusEntity = new APStatusEntity();
                            PrepareInitialView();
                            BindAPStatusList();

                            MiscUtil.ShowMessage(lblMessage, "A PStatus has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A PStatus.", true);
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

        protected void odsAPStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveAPStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _APStatusID = 0;
            _APStatusEntity = new APStatusEntity();
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
