// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Feb-2012, 04:08:22




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
    public partial class MDStandardTimeUnitControl : BaseControl
    {       
        #region Properties

        public Int64 _StandardTimeUnitID
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

        public MDStandardTimeUnitEntity _MDStandardTimeUnitEntity
        {
            get
            {
                MDStandardTimeUnitEntity entity = new MDStandardTimeUnitEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDStandardTimeUnitEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDStandardTimeUnitEntity CurrentMDStandardTimeUnitEntity
        {
            get
            {
                if (_StandardTimeUnitID > 0)
                {
                    if (_MDStandardTimeUnitEntity.StandardTimeUnitID != _StandardTimeUnitID)
                    {
                        _MDStandardTimeUnitEntity = FCCMDStandardTimeUnit.GetFacadeCreate().GetByID(_StandardTimeUnitID);
                    }
                }

                return _MDStandardTimeUnitEntity;
            }
            set
            {
                _MDStandardTimeUnitEntity = value;
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
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDStandardTimeUnitEntity mDStandardTimeUnitEntity = CurrentMDStandardTimeUnitEntity;


            if (!mDStandardTimeUnitEntity.IsNew)
            {
                txtName.Text = mDStandardTimeUnitEntity.Name.ToString();
                chkIsRemoved.Checked = mDStandardTimeUnitEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDStandardTimeUnitList();
        }

        private void BindMDStandardTimeUnitList()
        {
            lvMDStandardTimeUnit.DataBind();
        }

        private MDStandardTimeUnitEntity BuildMDStandardTimeUnitEntity()
        {
            MDStandardTimeUnitEntity mDStandardTimeUnitEntity = CurrentMDStandardTimeUnitEntity;

            mDStandardTimeUnitEntity.Name = txtName.Text.Trim();
            mDStandardTimeUnitEntity.IsRemoved = chkIsRemoved.Checked;


            return mDStandardTimeUnitEntity;
        }

        private void SaveMDStandardTimeUnitEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDStandardTimeUnitEntity mDStandardTimeUnitEntity = BuildMDStandardTimeUnitEntity();

                    Int64 result = -1;

                    if (mDStandardTimeUnitEntity.IsNew)
                    {
                        result = FCCMDStandardTimeUnit.GetFacadeCreate().Add(mDStandardTimeUnitEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDStandardTimeUnitEntity.FLD_NAME_StandardTimeUnitID, mDStandardTimeUnitEntity.StandardTimeUnitID.ToString(), SQLMatchType.Equal);
                        result = FCCMDStandardTimeUnit.GetFacadeCreate().Update(mDStandardTimeUnitEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _StandardTimeUnitID = 0;
                        _MDStandardTimeUnitEntity = new MDStandardTimeUnitEntity();
                        PrepareInitialView();
                        BindMDStandardTimeUnitList();

                        if (mDStandardTimeUnitEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Standard Time Unit Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Standard Time Unit Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDStandardTimeUnitEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Standard Time Unit Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Standard Time Unit Information.", false);
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

        protected void lvMDStandardTimeUnit_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 StandardTimeUnitID;

            Int64.TryParse(e.CommandArgument.ToString(), out StandardTimeUnitID);

            if (StandardTimeUnitID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _StandardTimeUnitID = StandardTimeUnitID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDStandardTimeUnitEntity.FLD_NAME_StandardTimeUnitID, StandardTimeUnitID.ToString(), SQLMatchType.Equal);

                        MDStandardTimeUnitEntity mDStandardTimeUnitEntity = new MDStandardTimeUnitEntity();


                        result = FCCMDStandardTimeUnit.GetFacadeCreate().Delete(mDStandardTimeUnitEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _StandardTimeUnitID = 0;
                            _MDStandardTimeUnitEntity = new MDStandardTimeUnitEntity();
                            PrepareInitialView();
                            BindMDStandardTimeUnitList();

                            MiscUtil.ShowMessage(lblMessage, "Standard Time Unit has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Standard Time Unit.", true);
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

        protected void odsMDStandardTimeUnit_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDStandardTimeUnitEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _StandardTimeUnitID = 0;
            _MDStandardTimeUnitEntity = new MDStandardTimeUnitEntity();
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
