// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 05:35:27




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
    public partial class ACMDTDSCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _TDSCategoryID
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

        public ACMDTDSCategoryEntity _ACMDTDSCategoryEntity
        {
            get
            {
                ACMDTDSCategoryEntity entity = new ACMDTDSCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACMDTDSCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACMDTDSCategoryEntity CurrentACMDTDSCategoryEntity
        {
            get
            {
                if (_TDSCategoryID > 0)
                {
                    if (_ACMDTDSCategoryEntity.TDSCategoryID != _TDSCategoryID)
                    {
                        _ACMDTDSCategoryEntity = FCCACMDTDSCategory.GetFacadeCreate().GetByID(_TDSCategoryID);
                    }
                }

                return _ACMDTDSCategoryEntity;
            }
            set
            {
                _ACMDTDSCategoryEntity = value;
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
            ACMDTDSCategoryEntity aCMDTDSCategoryEntity = CurrentACMDTDSCategoryEntity;


            if (!aCMDTDSCategoryEntity.IsNew)
            {
                txtName.Text = aCMDTDSCategoryEntity.Name.ToString();
                chkIsRemoved.Checked = aCMDTDSCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACMDTDSCategoryList();
        }

        private void BindACMDTDSCategoryList()
        {
            lvACMDTDSCategory.DataBind();
        }

        private ACMDTDSCategoryEntity BuildACMDTDSCategoryEntity()
        {
            ACMDTDSCategoryEntity aCMDTDSCategoryEntity = CurrentACMDTDSCategoryEntity;

            aCMDTDSCategoryEntity.Name = txtName.Text.Trim();
            aCMDTDSCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return aCMDTDSCategoryEntity;
        }

        private void SaveACMDTDSCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACMDTDSCategoryEntity aCMDTDSCategoryEntity = BuildACMDTDSCategoryEntity();

                    Int64 result = -1;

                    if (aCMDTDSCategoryEntity.IsNew)
                    {
                        result = FCCACMDTDSCategory.GetFacadeCreate().Add(aCMDTDSCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACMDTDSCategoryEntity.FLD_NAME_TDSCategoryID, aCMDTDSCategoryEntity.TDSCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCACMDTDSCategory.GetFacadeCreate().Update(aCMDTDSCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _TDSCategoryID = 0;
                        _ACMDTDSCategoryEntity = new ACMDTDSCategoryEntity();
                        PrepareInitialView();
                        BindACMDTDSCategoryList();

                        if (aCMDTDSCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CTDSCategory Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CTDSCategory Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCMDTDSCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CTDSCategory Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CTDSCategory Information.", false);
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

        protected void lvACMDTDSCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TDSCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out TDSCategoryID);

            if (TDSCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _TDSCategoryID = TDSCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDTDSCategoryEntity.FLD_NAME_TDSCategoryID, TDSCategoryID.ToString(), SQLMatchType.Equal);

                        ACMDTDSCategoryEntity aCMDTDSCategoryEntity = new ACMDTDSCategoryEntity();


                        result = FCCACMDTDSCategory.GetFacadeCreate().Delete(aCMDTDSCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _TDSCategoryID = 0;
                            _ACMDTDSCategoryEntity = new ACMDTDSCategoryEntity();
                            PrepareInitialView();
                            BindACMDTDSCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "A CTDSCategory has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CTDSCategory.", true);
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

        protected void odsACMDTDSCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACMDTDSCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _TDSCategoryID = 0;
            _ACMDTDSCategoryEntity = new ACMDTDSCategoryEntity();
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
