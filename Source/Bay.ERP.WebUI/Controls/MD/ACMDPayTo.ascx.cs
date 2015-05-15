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
    public partial class ACMDPayToControl : BaseControl
    {       
        #region Properties

        public Int64 _PayToID
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

        public ACMDPayToEntity _ACMDPayToEntity
        {
            get
            {
                ACMDPayToEntity entity = new ACMDPayToEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACMDPayToEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACMDPayToEntity CurrentACMDPayToEntity
        {
            get
            {
                if (_PayToID > 0)
                {
                    if (_ACMDPayToEntity.PayToID != _PayToID)
                    {
                        _ACMDPayToEntity = FCCACMDPayTo.GetFacadeCreate().GetByID(_PayToID);
                    }
                }

                return _ACMDPayToEntity;
            }
            set
            {
                _ACMDPayToEntity = value;
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
            ACMDPayToEntity aCMDPayToEntity = CurrentACMDPayToEntity;


            if (!aCMDPayToEntity.IsNew)
            {
                txtName.Text = aCMDPayToEntity.Name.ToString();
                txtDescription.Text = aCMDPayToEntity.Description.ToString();
                chkIsRemoved.Checked = aCMDPayToEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACMDPayToList();
        }

        private void BindACMDPayToList()
        {
            lvACMDPayTo.DataBind();
        }

        private ACMDPayToEntity BuildACMDPayToEntity()
        {
            ACMDPayToEntity aCMDPayToEntity = CurrentACMDPayToEntity;

            aCMDPayToEntity.Name = txtName.Text.Trim();
            aCMDPayToEntity.Description = txtDescription.Text.Trim();
            aCMDPayToEntity.IsRemoved = chkIsRemoved.Checked;


            return aCMDPayToEntity;
        }

        private void SaveACMDPayToEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACMDPayToEntity aCMDPayToEntity = BuildACMDPayToEntity();

                    Int64 result = -1;

                    if (aCMDPayToEntity.IsNew)
                    {
                        result = FCCACMDPayTo.GetFacadeCreate().Add(aCMDPayToEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACMDPayToEntity.FLD_NAME_PayToID, aCMDPayToEntity.PayToID.ToString(), SQLMatchType.Equal);
                        result = FCCACMDPayTo.GetFacadeCreate().Update(aCMDPayToEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PayToID = 0;
                        _ACMDPayToEntity = new ACMDPayToEntity();
                        PrepareInitialView();
                        BindACMDPayToList();

                        if (aCMDPayToEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CPay To Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CPay To Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCMDPayToEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CPay To Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CPay To Information.", false);
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

        protected void lvACMDPayTo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PayToID;

            Int64.TryParse(e.CommandArgument.ToString(), out PayToID);

            if (PayToID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PayToID = PayToID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDPayToEntity.FLD_NAME_PayToID, PayToID.ToString(), SQLMatchType.Equal);

                        ACMDPayToEntity aCMDPayToEntity = new ACMDPayToEntity();


                        result = FCCACMDPayTo.GetFacadeCreate().Delete(aCMDPayToEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PayToID = 0;
                            _ACMDPayToEntity = new ACMDPayToEntity();
                            PrepareInitialView();
                            BindACMDPayToList();

                            MiscUtil.ShowMessage(lblMessage, "A CPay To has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CPay To.", true);
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

        protected void odsACMDPayTo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACMDPayToEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PayToID = 0;
            _ACMDPayToEntity = new ACMDPayToEntity();
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
