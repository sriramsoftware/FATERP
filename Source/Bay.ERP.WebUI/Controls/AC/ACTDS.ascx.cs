// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 09:29:16




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
    public partial class ACTDSControl : BaseControl
    {       
        #region Properties

        public Int64 _TDSID
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

        public ACTDSEntity _ACTDSEntity
        {
            get
            {
                ACTDSEntity entity = new ACTDSEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACTDSEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACTDSEntity CurrentACTDSEntity
        {
            get
            {
                if (_TDSID > 0)
                {
                    if (_ACTDSEntity.TDSID != _TDSID)
                    {
                        _ACTDSEntity = FCCACTDS.GetFacadeCreate().GetByID(_TDSID);
                    }
                }

                return _ACTDSEntity;
            }
            set
            {
                _ACTDSEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACMDTDSCategory(ddlTDSCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtStartValue.Text = String.Empty;
            txtEndValue.Text = String.Empty;
            txtTax.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACTDSEntity aCTDSEntity = CurrentACTDSEntity;


            if (!aCTDSEntity.IsNew)
            {
                if (ddlTDSCategoryID.Items.Count > 0 && aCTDSEntity.TDSCategoryID != null)
                {
                    ddlTDSCategoryID.SelectedValue = aCTDSEntity.TDSCategoryID.ToString();
                }

                txtStartValue.Text = aCTDSEntity.StartValue.ToString();
                txtEndValue.Text = aCTDSEntity.EndValue.ToString();
                txtTax.Text = aCTDSEntity.Tax.ToString();
                txtRemarks.Text = aCTDSEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACTDSList();
        }

        private void BindACTDSList()
        {
            lvACTDS.DataBind();
        }

        private ACTDSEntity BuildACTDSEntity()
        {
            ACTDSEntity aCTDSEntity = CurrentACTDSEntity;

            if (ddlTDSCategoryID.Items.Count > 0)
            {
                if (ddlTDSCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    aCTDSEntity.TDSCategoryID = Int64.Parse(ddlTDSCategoryID.SelectedValue);
                }
            }

            if (!txtStartValue.Text.Trim().IsNullOrEmpty())
            {
                aCTDSEntity.StartValue = Decimal.Parse(txtStartValue.Text.Trim());
            }

            if (!txtEndValue.Text.Trim().IsNullOrEmpty())
            {
                aCTDSEntity.EndValue = Decimal.Parse(txtEndValue.Text.Trim());
            }

            if (!txtTax.Text.Trim().IsNullOrEmpty())
            {
                aCTDSEntity.Tax = Decimal.Parse(txtTax.Text.Trim());
            }

            aCTDSEntity.Remarks = txtRemarks.Text.Trim();

            return aCTDSEntity;
        }

        private void SaveACTDSEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACTDSEntity aCTDSEntity = BuildACTDSEntity();

                    Int64 result = -1;

                    if (aCTDSEntity.IsNew)
                    {
                        result = FCCACTDS.GetFacadeCreate().Add(aCTDSEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACTDSEntity.FLD_NAME_TDSID, aCTDSEntity.TDSID.ToString(), SQLMatchType.Equal);
                        result = FCCACTDS.GetFacadeCreate().Update(aCTDSEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _TDSID = 0;
                        _ACTDSEntity = new ACTDSEntity();
                        PrepareInitialView();
                        BindACTDSList();

                        if (aCTDSEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CTDS Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CTDS Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCTDSEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CTDS Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CTDS Information.", false);
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

        protected void lvACTDS_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TDSID;

            Int64.TryParse(e.CommandArgument.ToString(), out TDSID);

            if (TDSID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _TDSID = TDSID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACTDSEntity.FLD_NAME_TDSID, TDSID.ToString(), SQLMatchType.Equal);

                        ACTDSEntity aCTDSEntity = new ACTDSEntity();


                        result = FCCACTDS.GetFacadeCreate().Delete(aCTDSEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _TDSID = 0;
                            _ACTDSEntity = new ACTDSEntity();
                            PrepareInitialView();
                            BindACTDSList();

                            MiscUtil.ShowMessage(lblMessage, "A CTDS has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CTDS.", true);
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

        protected void odsACTDS_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACTDSEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _TDSID = 0;
            _ACTDSEntity = new ACTDSEntity();
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
