// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Oct-2013, 12:17:51




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
    public partial class MDMailTextTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _MailTextTypeID
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

        public MDMailTextTypeEntity _MDMailTextTypeEntity
        {
            get
            {
                MDMailTextTypeEntity entity = new MDMailTextTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDMailTextTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDMailTextTypeEntity CurrentMDMailTextTypeEntity
        {
            get
            {
                if (_MailTextTypeID > 0)
                {
                    if (_MDMailTextTypeEntity.MailTextTypeID != _MailTextTypeID)
                    {
                        _MDMailTextTypeEntity = FCCMDMailTextType.GetFacadeCreate().GetByID(_MailTextTypeID);
                    }
                }

                return _MDMailTextTypeEntity;
            }
            set
            {
                _MDMailTextTypeEntity = value;
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
            MDMailTextTypeEntity mDMailTextTypeEntity = CurrentMDMailTextTypeEntity;


            if (!mDMailTextTypeEntity.IsNew)
            {
                txtName.Text = mDMailTextTypeEntity.Name.ToString();
                txtDescription.Text = mDMailTextTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDMailTextTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDMailTextTypeList();
        }

        private void BindMDMailTextTypeList()
        {
            lvMDMailTextType.DataBind();
        }

        private MDMailTextTypeEntity BuildMDMailTextTypeEntity()
        {
            MDMailTextTypeEntity mDMailTextTypeEntity = CurrentMDMailTextTypeEntity;

            mDMailTextTypeEntity.Name = txtName.Text.Trim();
            mDMailTextTypeEntity.Description = txtDescription.Text.Trim();
            mDMailTextTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDMailTextTypeEntity;
        }

        private void SaveMDMailTextTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDMailTextTypeEntity mDMailTextTypeEntity = BuildMDMailTextTypeEntity();

                    Int64 result = -1;

                    if (mDMailTextTypeEntity.IsNew)
                    {
                        result = FCCMDMailTextType.GetFacadeCreate().Add(mDMailTextTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDMailTextTypeEntity.FLD_NAME_MailTextTypeID, mDMailTextTypeEntity.MailTextTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDMailTextType.GetFacadeCreate().Update(mDMailTextTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MailTextTypeID = 0;
                        _MDMailTextTypeEntity = new MDMailTextTypeEntity();
                        PrepareInitialView();
                        BindMDMailTextTypeList();

                        if (mDMailTextTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Mail Text Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Mail Text Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDMailTextTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Mail Text Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Mail Text Type Information.", false);
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

        protected void lvMDMailTextType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MailTextTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out MailTextTypeID);

            if (MailTextTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MailTextTypeID = MailTextTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDMailTextTypeEntity.FLD_NAME_MailTextTypeID, MailTextTypeID.ToString(), SQLMatchType.Equal);

                        MDMailTextTypeEntity mDMailTextTypeEntity = new MDMailTextTypeEntity();


                        result = FCCMDMailTextType.GetFacadeCreate().Delete(mDMailTextTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MailTextTypeID = 0;
                            _MDMailTextTypeEntity = new MDMailTextTypeEntity();
                            PrepareInitialView();
                            BindMDMailTextTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Mail Text Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Mail Text Type.", true);
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

        protected void odsMDMailTextType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDMailTextTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MailTextTypeID = 0;
            _MDMailTextTypeEntity = new MDMailTextTypeEntity();
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
