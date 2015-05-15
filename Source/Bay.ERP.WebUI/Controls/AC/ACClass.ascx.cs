// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 04:27:49




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
    public partial class ACClassControl : BaseControl
    {       
        #region Properties

        public Int64 _ClassID
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

        public ACClassEntity _ACClassEntity
        {
            get
            {
                ACClassEntity entity = new ACClassEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACClassEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACClassEntity CurrentACClassEntity
        {
            get
            {
                if (_ClassID > 0)
                {
                    if (_ACClassEntity.ClassID != _ClassID)
                    {
                        _ACClassEntity = FCCACClass.GetFacadeCreate().GetByID(_ClassID);
                    }
                }

                return _ACClassEntity;
            }
            set
            {
                _ACClassEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACClassType(ddlClassTypeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsInActive.Checked = false;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACClassEntity aCClassEntity = CurrentACClassEntity;


            if (!aCClassEntity.IsNew)
            {
                if (ddlClassTypeID.Items.Count > 0 && aCClassEntity.ClassTypeID != null)
                {
                    ddlClassTypeID.SelectedValue = aCClassEntity.ClassTypeID.ToString();
                }

                txtName.Text = aCClassEntity.Name.ToString();
                txtDescription.Text = aCClassEntity.Description.ToString();
                chkIsInActive.Checked = aCClassEntity.IsInActive;
                chkIsRemoved.Checked = aCClassEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACClassList();
        }

        private void BindACClassList()
        {
            lvACClass.DataBind();
        }

        private ACClassEntity BuildACClassEntity()
        {
            ACClassEntity aCClassEntity = CurrentACClassEntity;

            if (ddlClassTypeID.Items.Count > 0)
            {
                if (ddlClassTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    aCClassEntity.ClassTypeID = Int64.Parse(ddlClassTypeID.SelectedValue);
                }
            }

            aCClassEntity.Name = txtName.Text.Trim();
            aCClassEntity.Description = txtDescription.Text.Trim();
            aCClassEntity.IsInActive = chkIsInActive.Checked;

            aCClassEntity.IsRemoved = chkIsRemoved.Checked;


            return aCClassEntity;
        }

        private void SaveACClassEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACClassEntity aCClassEntity = BuildACClassEntity();

                    Int64 result = -1;

                    if (aCClassEntity.IsNew)
                    {
                        result = FCCACClass.GetFacadeCreate().Add(aCClassEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACClassEntity.FLD_NAME_ClassID, aCClassEntity.ClassID.ToString(), SQLMatchType.Equal);
                        result = FCCACClass.GetFacadeCreate().Update(aCClassEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ClassID = 0;
                        _ACClassEntity = new ACClassEntity();
                        PrepareInitialView();
                        BindACClassList();

                        if (aCClassEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CClass Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CClass Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCClassEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CClass Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CClass Information.", false);
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

        protected void lvACClass_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ClassID;

            Int64.TryParse(e.CommandArgument.ToString(), out ClassID);

            if (ClassID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ClassID = ClassID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACClassEntity.FLD_NAME_ClassID, ClassID.ToString(), SQLMatchType.Equal);

                        ACClassEntity aCClassEntity = new ACClassEntity();


                        result = FCCACClass.GetFacadeCreate().Delete(aCClassEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ClassID = 0;
                            _ACClassEntity = new ACClassEntity();
                            PrepareInitialView();
                            BindACClassList();

                            MiscUtil.ShowMessage(lblMessage, "A CClass has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CClass.", true);
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

        protected void odsACClass_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACClassEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ClassID = 0;
            _ACClassEntity = new ACClassEntity();
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
