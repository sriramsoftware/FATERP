// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




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
    public partial class ACDimensionControl : BaseControl
    {       
        #region Properties

        public Int64 _DimensionID
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

        public ACDimensionEntity _ACDimensionEntity
        {
            get
            {
                ACDimensionEntity entity = new ACDimensionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACDimensionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACDimensionEntity CurrentACDimensionEntity
        {
            get
            {
                if (_DimensionID > 0)
                {
                    if (_ACDimensionEntity.DimensionID != _DimensionID)
                    {
                        _ACDimensionEntity = FCCACDimension.GetFacadeCreate().GetByID(_DimensionID);
                    }
                }

                return _ACDimensionEntity;
            }
            set
            {
                _ACDimensionEntity = value;
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
            chkIsInActive.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACDimensionEntity aCDimensionEntity = CurrentACDimensionEntity;


            if (!aCDimensionEntity.IsNew)
            {
                txtName.Text = aCDimensionEntity.Name.ToString();
                txtDescription.Text = aCDimensionEntity.Description.ToString();
                chkIsInActive.Checked = aCDimensionEntity.IsInActive;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACDimensionList();
        }

        private void BindACDimensionList()
        {
            lvACDimension.DataBind();
        }

        private ACDimensionEntity BuildACDimensionEntity()
        {
            ACDimensionEntity aCDimensionEntity = CurrentACDimensionEntity;

            aCDimensionEntity.Name = txtName.Text.Trim();
            aCDimensionEntity.Description = txtDescription.Text.Trim();
            aCDimensionEntity.IsInActive = chkIsInActive.Checked;


            return aCDimensionEntity;
        }

        private void SaveACDimensionEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACDimensionEntity aCDimensionEntity = BuildACDimensionEntity();

                    Int64 result = -1;

                    if (aCDimensionEntity.IsNew)
                    {
                        result = FCCACDimension.GetFacadeCreate().Add(aCDimensionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACDimensionEntity.FLD_NAME_DimensionID, aCDimensionEntity.DimensionID.ToString(), SQLMatchType.Equal);
                        result = FCCACDimension.GetFacadeCreate().Update(aCDimensionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DimensionID = 0;
                        _ACDimensionEntity = new ACDimensionEntity();
                        PrepareInitialView();
                        BindACDimensionList();

                        if (aCDimensionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CDimension Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CDimension Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCDimensionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CDimension Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CDimension Information.", false);
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

        protected void lvACDimension_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DimensionID;

            Int64.TryParse(e.CommandArgument.ToString(), out DimensionID);

            if (DimensionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DimensionID = DimensionID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACDimensionEntity.FLD_NAME_DimensionID, DimensionID.ToString(), SQLMatchType.Equal);

                        ACDimensionEntity aCDimensionEntity = new ACDimensionEntity();


                        result = FCCACDimension.GetFacadeCreate().Delete(aCDimensionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DimensionID = 0;
                            _ACDimensionEntity = new ACDimensionEntity();
                            PrepareInitialView();
                            BindACDimensionList();

                            MiscUtil.ShowMessage(lblMessage, "A CDimension has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CDimension.", true);
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

        protected void odsACDimension_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACDimensionEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DimensionID = 0;
            _ACDimensionEntity = new ACDimensionEntity();
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
