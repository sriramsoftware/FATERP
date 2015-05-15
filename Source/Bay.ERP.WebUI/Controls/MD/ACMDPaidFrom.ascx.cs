// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




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
    public partial class ACMDPaidFromControl : BaseControl
    {       
        #region Properties

        public Int64 _PaidFromID
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

        public ACMDPaidFromEntity _ACMDPaidFromEntity
        {
            get
            {
                ACMDPaidFromEntity entity = new ACMDPaidFromEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACMDPaidFromEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACMDPaidFromEntity CurrentACMDPaidFromEntity
        {
            get
            {
                if (_PaidFromID > 0)
                {
                    if (_ACMDPaidFromEntity.PaidFromID != _PaidFromID)
                    {
                        _ACMDPaidFromEntity = FCCACMDPaidFrom.GetFacadeCreate().GetByID(_PaidFromID);
                    }
                }

                return _ACMDPaidFromEntity;
            }
            set
            {
                _ACMDPaidFromEntity = value;
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
            ACMDPaidFromEntity aCMDPaidFromEntity = CurrentACMDPaidFromEntity;


            if (!aCMDPaidFromEntity.IsNew)
            {
                txtName.Text = aCMDPaidFromEntity.Name.ToString();
                txtDescription.Text = aCMDPaidFromEntity.Description.ToString();
                chkIsRemoved.Checked = aCMDPaidFromEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACMDPaidFromList();
        }

        private void BindACMDPaidFromList()
        {
            lvACMDPaidFrom.DataBind();
        }

        private ACMDPaidFromEntity BuildACMDPaidFromEntity()
        {
            ACMDPaidFromEntity aCMDPaidFromEntity = CurrentACMDPaidFromEntity;

            aCMDPaidFromEntity.Name = txtName.Text.Trim();
            aCMDPaidFromEntity.Description = txtDescription.Text.Trim();
            aCMDPaidFromEntity.IsRemoved = chkIsRemoved.Checked;


            return aCMDPaidFromEntity;
        }

        private void SaveACMDPaidFromEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACMDPaidFromEntity aCMDPaidFromEntity = BuildACMDPaidFromEntity();

                    Int64 result = -1;

                    if (aCMDPaidFromEntity.IsNew)
                    {
                        result = FCCACMDPaidFrom.GetFacadeCreate().Add(aCMDPaidFromEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACMDPaidFromEntity.FLD_NAME_PaidFromID, aCMDPaidFromEntity.PaidFromID.ToString(), SQLMatchType.Equal);
                        result = FCCACMDPaidFrom.GetFacadeCreate().Update(aCMDPaidFromEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PaidFromID = 0;
                        _ACMDPaidFromEntity = new ACMDPaidFromEntity();
                        PrepareInitialView();
                        BindACMDPaidFromList();

                        if (aCMDPaidFromEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CPaid From Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CPaid From Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCMDPaidFromEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CPaid From Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CPaid From Information.", false);
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

        protected void lvACMDPaidFrom_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PaidFromID;

            Int64.TryParse(e.CommandArgument.ToString(), out PaidFromID);

            if (PaidFromID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PaidFromID = PaidFromID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDPaidFromEntity.FLD_NAME_PaidFromID, PaidFromID.ToString(), SQLMatchType.Equal);

                        ACMDPaidFromEntity aCMDPaidFromEntity = new ACMDPaidFromEntity();


                        result = FCCACMDPaidFrom.GetFacadeCreate().Delete(aCMDPaidFromEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PaidFromID = 0;
                            _ACMDPaidFromEntity = new ACMDPaidFromEntity();
                            PrepareInitialView();
                            BindACMDPaidFromList();

                            MiscUtil.ShowMessage(lblMessage, "A CPaid From has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CPaid From.", true);
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

        protected void odsACMDPaidFrom_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACMDPaidFromEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PaidFromID = 0;
            _ACMDPaidFromEntity = new ACMDPaidFromEntity();
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
