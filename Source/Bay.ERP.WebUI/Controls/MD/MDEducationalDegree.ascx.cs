// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDEducationalDegreeControl : BaseControl
    {       
        #region Properties

        public Int64 _EducationalDegreeID
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

        public MDEducationalDegreeEntity _MDEducationalDegreeEntity
        {
            get
            {
                MDEducationalDegreeEntity entity = new MDEducationalDegreeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEducationalDegreeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEducationalDegreeEntity CurrentMDEducationalDegreeEntity
        {
            get
            {
                if (_EducationalDegreeID > 0)
                {
                    if (_MDEducationalDegreeEntity.EducationalDegreeID != _EducationalDegreeID)
                    {
                        _MDEducationalDegreeEntity = FCCMDEducationalDegree.GetFacadeCreate().GetByID(_EducationalDegreeID);
                    }
                }

                return _MDEducationalDegreeEntity;
            }
            set
            {
                _MDEducationalDegreeEntity = value;
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
            MDEducationalDegreeEntity mDEducationalDegreeEntity = CurrentMDEducationalDegreeEntity;


            if (!mDEducationalDegreeEntity.IsNew)
            {
                txtName.Text = mDEducationalDegreeEntity.Name.ToString();
                txtDescription.Text = mDEducationalDegreeEntity.Description.ToString();
                chkIsRemoved.Checked = mDEducationalDegreeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEducationalDegreeList();
        }

        private void BindMDEducationalDegreeList()
        {
            lvMDEducationalDegree.DataBind();
        }

        private MDEducationalDegreeEntity BuildMDEducationalDegreeEntity()
        {
            MDEducationalDegreeEntity mDEducationalDegreeEntity = CurrentMDEducationalDegreeEntity;

            mDEducationalDegreeEntity.Name = txtName.Text.Trim();
            mDEducationalDegreeEntity.Description = txtDescription.Text.Trim();
            mDEducationalDegreeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEducationalDegreeEntity;
        }

        private void SaveMDEducationalDegreeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEducationalDegreeEntity mDEducationalDegreeEntity = BuildMDEducationalDegreeEntity();

                    Int64 result = -1;

                    if (mDEducationalDegreeEntity.IsNew)
                    {
                        result = FCCMDEducationalDegree.GetFacadeCreate().Add(mDEducationalDegreeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEducationalDegreeEntity.FLD_NAME_EducationalDegreeID, mDEducationalDegreeEntity.EducationalDegreeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEducationalDegree.GetFacadeCreate().Update(mDEducationalDegreeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EducationalDegreeID = 0;
                        _MDEducationalDegreeEntity = new MDEducationalDegreeEntity();
                        PrepareInitialView();
                        BindMDEducationalDegreeList();

                        if (mDEducationalDegreeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Educational Degree Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Educational Degree Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEducationalDegreeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Educational Degree Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Educational Degree Information.", false);
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

        protected void lvMDEducationalDegree_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EducationalDegreeID;

            Int64.TryParse(e.CommandArgument.ToString(), out EducationalDegreeID);

            if (EducationalDegreeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EducationalDegreeID = EducationalDegreeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEducationalDegreeEntity.FLD_NAME_EducationalDegreeID, EducationalDegreeID.ToString(), SQLMatchType.Equal);

                        MDEducationalDegreeEntity mDEducationalDegreeEntity = new MDEducationalDegreeEntity();


                        result = FCCMDEducationalDegree.GetFacadeCreate().Delete(mDEducationalDegreeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EducationalDegreeID = 0;
                            _MDEducationalDegreeEntity = new MDEducationalDegreeEntity();
                            PrepareInitialView();
                            BindMDEducationalDegreeList();

                            MiscUtil.ShowMessage(lblMessage, "Educational Degree has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Educational Degree.", true);
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

        protected void odsMDEducationalDegree_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEducationalDegreeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EducationalDegreeID = 0;
            _MDEducationalDegreeEntity = new MDEducationalDegreeEntity();
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
