// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 03:28:28




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
    public partial class ACClassTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _ClassTypeID
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

        public ACClassTypeEntity _ACClassTypeEntity
        {
            get
            {
                ACClassTypeEntity entity = new ACClassTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACClassTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACClassTypeEntity CurrentACClassTypeEntity
        {
            get
            {
                if (_ClassTypeID > 0)
                {
                    if (_ACClassTypeEntity.ClassTypeID != _ClassTypeID)
                    {
                        _ACClassTypeEntity = FCCACClassType.GetFacadeCreate().GetByID(_ClassTypeID);
                    }
                }

                return _ACClassTypeEntity;
            }
            set
            {
                _ACClassTypeEntity = value;
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
            ACClassTypeEntity aCClassTypeEntity = CurrentACClassTypeEntity;


            if (!aCClassTypeEntity.IsNew)
            {
                txtName.Text = aCClassTypeEntity.Name.ToString();
                txtDescription.Text = aCClassTypeEntity.Description.ToString();
                chkIsRemoved.Checked = aCClassTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACClassTypeList();
        }

        private void BindACClassTypeList()
        {
            lvACClassType.DataBind();
        }

        private ACClassTypeEntity BuildACClassTypeEntity()
        {
            ACClassTypeEntity aCClassTypeEntity = CurrentACClassTypeEntity;

            aCClassTypeEntity.Name = txtName.Text.Trim();
            aCClassTypeEntity.Description = txtDescription.Text.Trim();
            aCClassTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return aCClassTypeEntity;
        }

        private void SaveACClassTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACClassTypeEntity aCClassTypeEntity = BuildACClassTypeEntity();

                    Int64 result = -1;

                    if (aCClassTypeEntity.IsNew)
                    {
                        result = FCCACClassType.GetFacadeCreate().Add(aCClassTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACClassTypeEntity.FLD_NAME_ClassTypeID, aCClassTypeEntity.ClassTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCACClassType.GetFacadeCreate().Update(aCClassTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ClassTypeID = 0;
                        _ACClassTypeEntity = new ACClassTypeEntity();
                        PrepareInitialView();
                        BindACClassTypeList();

                        if (aCClassTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CClass Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CClass Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCClassTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CClass Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CClass Type Information.", false);
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

        protected void lvACClassType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ClassTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out ClassTypeID);

            if (ClassTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ClassTypeID = ClassTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACClassTypeEntity.FLD_NAME_ClassTypeID, ClassTypeID.ToString(), SQLMatchType.Equal);

                        ACClassTypeEntity aCClassTypeEntity = new ACClassTypeEntity();


                        result = FCCACClassType.GetFacadeCreate().Delete(aCClassTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ClassTypeID = 0;
                            _ACClassTypeEntity = new ACClassTypeEntity();
                            PrepareInitialView();
                            BindACClassTypeList();

                            MiscUtil.ShowMessage(lblMessage, "A CClass Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CClass Type.", true);
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

        protected void odsACClassType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACClassTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ClassTypeID = 0;
            _ACClassTypeEntity = new ACClassTypeEntity();
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
