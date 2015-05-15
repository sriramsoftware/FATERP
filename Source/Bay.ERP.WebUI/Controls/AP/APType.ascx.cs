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
    public partial class APTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _APTypeID
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

        public APTypeEntity _APTypeEntity
        {
            get
            {
                APTypeEntity entity = new APTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (APTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private APTypeEntity CurrentAPTypeEntity
        {
            get
            {
                if (_APTypeID > 0)
                {
                    if (_APTypeEntity.APTypeID != _APTypeID)
                    {
                        _APTypeEntity = FCCAPType.GetFacadeCreate().GetByID(_APTypeID);
                    }
                }

                return _APTypeEntity;
            }
            set
            {
                _APTypeEntity = value;
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
            APTypeEntity aPTypeEntity = CurrentAPTypeEntity;


            if (!aPTypeEntity.IsNew)
            {
                txtName.Text = aPTypeEntity.Name.ToString();
                txtDescription.Text = aPTypeEntity.Description.ToString();
                chkIsRemoved.Checked = aPTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindAPTypeList();
        }

        private void BindAPTypeList()
        {
            lvAPType.DataBind();
        }

        private APTypeEntity BuildAPTypeEntity()
        {
            APTypeEntity aPTypeEntity = CurrentAPTypeEntity;

            aPTypeEntity.Name = txtName.Text.Trim();
            aPTypeEntity.Description = txtDescription.Text.Trim();
            aPTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return aPTypeEntity;
        }

        private void SaveAPTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    APTypeEntity aPTypeEntity = BuildAPTypeEntity();

                    Int64 result = -1;

                    if (aPTypeEntity.IsNew)
                    {
                        result = FCCAPType.GetFacadeCreate().Add(aPTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(APTypeEntity.FLD_NAME_APTypeID, aPTypeEntity.APTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCAPType.GetFacadeCreate().Update(aPTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _APTypeID = 0;
                        _APTypeEntity = new APTypeEntity();
                        PrepareInitialView();
                        BindAPTypeList();

                        if (aPTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PType Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PType Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aPTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A PType Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A PType Information.", false);
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

        protected void lvAPType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 APTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out APTypeID);

            if (APTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _APTypeID = APTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(APTypeEntity.FLD_NAME_APTypeID, APTypeID.ToString(), SQLMatchType.Equal);

                        APTypeEntity aPTypeEntity = new APTypeEntity();


                        result = FCCAPType.GetFacadeCreate().Delete(aPTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _APTypeID = 0;
                            _APTypeEntity = new APTypeEntity();
                            PrepareInitialView();
                            BindAPTypeList();

                            MiscUtil.ShowMessage(lblMessage, "A PType has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A PType.", true);
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

        protected void odsAPType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveAPTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _APTypeID = 0;
            _APTypeEntity = new APTypeEntity();
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
