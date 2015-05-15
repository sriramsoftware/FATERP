// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




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
    public partial class ACDepreciationMethodControl : BaseControl
    {       
        #region Properties

        public Int64 _DepreciationMethodID
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

        public ACDepreciationMethodEntity _ACDepreciationMethodEntity
        {
            get
            {
                ACDepreciationMethodEntity entity = new ACDepreciationMethodEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACDepreciationMethodEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACDepreciationMethodEntity CurrentACDepreciationMethodEntity
        {
            get
            {
                if (_DepreciationMethodID > 0)
                {
                    if (_ACDepreciationMethodEntity.DepreciationMethodID != _DepreciationMethodID)
                    {
                        _ACDepreciationMethodEntity = FCCACDepreciationMethod.GetFacadeCreate().GetByID(_DepreciationMethodID);
                    }
                }

                return _ACDepreciationMethodEntity;
            }
            set
            {
                _ACDepreciationMethodEntity = value;
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
            ACDepreciationMethodEntity aCDepreciationMethodEntity = CurrentACDepreciationMethodEntity;


            if (!aCDepreciationMethodEntity.IsNew)
            {
                txtName.Text = aCDepreciationMethodEntity.Name.ToString();
                txtDescription.Text = aCDepreciationMethodEntity.Description.ToString();
                chkIsRemoved.Checked = aCDepreciationMethodEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACDepreciationMethodList();
        }

        private void BindACDepreciationMethodList()
        {
            lvACDepreciationMethod.DataBind();
        }

        private ACDepreciationMethodEntity BuildACDepreciationMethodEntity()
        {
            ACDepreciationMethodEntity aCDepreciationMethodEntity = CurrentACDepreciationMethodEntity;

            aCDepreciationMethodEntity.Name = txtName.Text.Trim();
            aCDepreciationMethodEntity.Description = txtDescription.Text.Trim();
            aCDepreciationMethodEntity.IsRemoved = chkIsRemoved.Checked;


            return aCDepreciationMethodEntity;
        }

        private void SaveACDepreciationMethodEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACDepreciationMethodEntity aCDepreciationMethodEntity = BuildACDepreciationMethodEntity();

                    Int64 result = -1;

                    if (aCDepreciationMethodEntity.IsNew)
                    {
                        result = FCCACDepreciationMethod.GetFacadeCreate().Add(aCDepreciationMethodEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACDepreciationMethodEntity.FLD_NAME_DepreciationMethodID, aCDepreciationMethodEntity.DepreciationMethodID.ToString(), SQLMatchType.Equal);
                        result = FCCACDepreciationMethod.GetFacadeCreate().Update(aCDepreciationMethodEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DepreciationMethodID = 0;
                        _ACDepreciationMethodEntity = new ACDepreciationMethodEntity();
                        PrepareInitialView();
                        BindACDepreciationMethodList();

                        if (aCDepreciationMethodEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CDepreciation Method Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CDepreciation Method Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCDepreciationMethodEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CDepreciation Method Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CDepreciation Method Information.", false);
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

        protected void lvACDepreciationMethod_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DepreciationMethodID;

            Int64.TryParse(e.CommandArgument.ToString(), out DepreciationMethodID);

            if (DepreciationMethodID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DepreciationMethodID = DepreciationMethodID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACDepreciationMethodEntity.FLD_NAME_DepreciationMethodID, DepreciationMethodID.ToString(), SQLMatchType.Equal);

                        ACDepreciationMethodEntity aCDepreciationMethodEntity = new ACDepreciationMethodEntity();


                        result = FCCACDepreciationMethod.GetFacadeCreate().Delete(aCDepreciationMethodEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DepreciationMethodID = 0;
                            _ACDepreciationMethodEntity = new ACDepreciationMethodEntity();
                            PrepareInitialView();
                            BindACDepreciationMethodList();

                            MiscUtil.ShowMessage(lblMessage, "A CDepreciation Method has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CDepreciation Method.", true);
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

        protected void odsACDepreciationMethod_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACDepreciationMethodEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DepreciationMethodID = 0;
            _ACDepreciationMethodEntity = new ACDepreciationMethodEntity();
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
