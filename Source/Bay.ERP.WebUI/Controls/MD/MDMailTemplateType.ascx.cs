// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Nov-2012, 10:24:47




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
    public partial class MDMailTemplateTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _MailTemplateTypeID
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

        public MDMailTemplateTypeEntity _MDMailTemplateTypeEntity
        {
            get
            {
                MDMailTemplateTypeEntity entity = new MDMailTemplateTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDMailTemplateTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDMailTemplateTypeEntity CurrentMDMailTemplateTypeEntity
        {
            get
            {
                if (_MailTemplateTypeID > 0)
                {
                    if (_MDMailTemplateTypeEntity.MailTemplateTypeID != _MailTemplateTypeID)
                    {
                        _MDMailTemplateTypeEntity = FCCMDMailTemplateType.GetFacadeCreate().GetByID(_MailTemplateTypeID);
                    }
                }

                return _MDMailTemplateTypeEntity;
            }
            set
            {
                _MDMailTemplateTypeEntity = value;
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
            MDMailTemplateTypeEntity mDMailTemplateTypeEntity = CurrentMDMailTemplateTypeEntity;


            if (!mDMailTemplateTypeEntity.IsNew)
            {
                txtName.Text = mDMailTemplateTypeEntity.Name.ToString();
                txtDescription.Text = mDMailTemplateTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDMailTemplateTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDMailTemplateTypeList();
        }

        private void BindMDMailTemplateTypeList()
        {
            lvMDMailTemplateType.DataBind();
        }

        private MDMailTemplateTypeEntity BuildMDMailTemplateTypeEntity()
        {
            MDMailTemplateTypeEntity mDMailTemplateTypeEntity = CurrentMDMailTemplateTypeEntity;

            mDMailTemplateTypeEntity.Name = txtName.Text.Trim();
            mDMailTemplateTypeEntity.Description = txtDescription.Text.Trim();
            mDMailTemplateTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDMailTemplateTypeEntity;
        }

        private void SaveMDMailTemplateTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDMailTemplateTypeEntity mDMailTemplateTypeEntity = BuildMDMailTemplateTypeEntity();

                    Int64 result = -1;

                    if (mDMailTemplateTypeEntity.IsNew)
                    {
                        result = FCCMDMailTemplateType.GetFacadeCreate().Add(mDMailTemplateTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDMailTemplateTypeEntity.FLD_NAME_MailTemplateTypeID, mDMailTemplateTypeEntity.MailTemplateTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDMailTemplateType.GetFacadeCreate().Update(mDMailTemplateTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MailTemplateTypeID = 0;
                        _MDMailTemplateTypeEntity = new MDMailTemplateTypeEntity();
                        PrepareInitialView();
                        BindMDMailTemplateTypeList();

                        if (mDMailTemplateTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Mail Template Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Mail Template Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDMailTemplateTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Mail Template Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Mail Template Type Information.", false);
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

        protected void lvMDMailTemplateType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MailTemplateTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out MailTemplateTypeID);

            if (MailTemplateTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MailTemplateTypeID = MailTemplateTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDMailTemplateTypeEntity.FLD_NAME_MailTemplateTypeID, MailTemplateTypeID.ToString(), SQLMatchType.Equal);

                        MDMailTemplateTypeEntity mDMailTemplateTypeEntity = new MDMailTemplateTypeEntity();


                        result = FCCMDMailTemplateType.GetFacadeCreate().Delete(mDMailTemplateTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MailTemplateTypeID = 0;
                            _MDMailTemplateTypeEntity = new MDMailTemplateTypeEntity();
                            PrepareInitialView();
                            BindMDMailTemplateTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Mail Template Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Mail Template Type.", true);
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

        protected void odsMDMailTemplateType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDMailTemplateTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MailTemplateTypeID = 0;
            _MDMailTemplateTypeEntity = new MDMailTemplateTypeEntity();
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
