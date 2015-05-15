// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public partial class CRMMDAreaUnitControl : BaseControl
    {       
        #region Properties

        public Int64 _AreaUnitID
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

        public CRMMDAreaUnitEntity _CRMMDAreaUnitEntity
        {
            get
            {
                CRMMDAreaUnitEntity entity = new CRMMDAreaUnitEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDAreaUnitEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDAreaUnitEntity CurrentCRMMDAreaUnitEntity
        {
            get
            {
                if (_AreaUnitID > 0)
                {
                    if (_CRMMDAreaUnitEntity.AreaUnitID != _AreaUnitID)
                    {
                        _CRMMDAreaUnitEntity = FCCCRMMDAreaUnit.GetFacadeCreate().GetByID(_AreaUnitID);
                    }
                }

                return _CRMMDAreaUnitEntity;
            }
            set
            {
                _CRMMDAreaUnitEntity = value;
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
            CRMMDAreaUnitEntity cRMMDAreaUnitEntity = CurrentCRMMDAreaUnitEntity;


            if (!cRMMDAreaUnitEntity.IsNew)
            {
                txtName.Text = cRMMDAreaUnitEntity.Name.ToString();
                txtDescription.Text = cRMMDAreaUnitEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDAreaUnitEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDAreaUnitList();
        }

        private void BindCRMMDAreaUnitList()
        {
            lvCRMMDAreaUnit.DataBind();
        }

        private CRMMDAreaUnitEntity BuildCRMMDAreaUnitEntity()
        {
            CRMMDAreaUnitEntity cRMMDAreaUnitEntity = CurrentCRMMDAreaUnitEntity;

            cRMMDAreaUnitEntity.Name = txtName.Text.Trim();
            cRMMDAreaUnitEntity.Description = txtDescription.Text.Trim();
            cRMMDAreaUnitEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDAreaUnitEntity;
        }

        private void SaveCRMMDAreaUnitEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDAreaUnitEntity cRMMDAreaUnitEntity = BuildCRMMDAreaUnitEntity();

                    Int64 result = -1;

                    if (cRMMDAreaUnitEntity.IsNew)
                    {
                        result = FCCCRMMDAreaUnit.GetFacadeCreate().Add(cRMMDAreaUnitEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAreaUnitEntity.FLD_NAME_AreaUnitID, cRMMDAreaUnitEntity.AreaUnitID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDAreaUnit.GetFacadeCreate().Update(cRMMDAreaUnitEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AreaUnitID = 0;
                        _CRMMDAreaUnitEntity = new CRMMDAreaUnitEntity();
                        PrepareInitialView();
                        BindCRMMDAreaUnitList();

                        if (cRMMDAreaUnitEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMArea Unit Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMArea Unit Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDAreaUnitEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMArea Unit Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMArea Unit Information.", false);
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

        protected void lvCRMMDAreaUnit_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AreaUnitID;

            Int64.TryParse(e.CommandArgument.ToString(), out AreaUnitID);

            if (AreaUnitID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AreaUnitID = AreaUnitID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAreaUnitEntity.FLD_NAME_AreaUnitID, AreaUnitID.ToString(), SQLMatchType.Equal);

                        CRMMDAreaUnitEntity cRMMDAreaUnitEntity = new CRMMDAreaUnitEntity();


                        result = FCCCRMMDAreaUnit.GetFacadeCreate().Delete(cRMMDAreaUnitEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AreaUnitID = 0;
                            _CRMMDAreaUnitEntity = new CRMMDAreaUnitEntity();
                            PrepareInitialView();
                            BindCRMMDAreaUnitList();

                            MiscUtil.ShowMessage(lblMessage, "C RMArea Unit has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMArea Unit.", true);
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

        protected void odsCRMMDAreaUnit_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDAreaUnitEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AreaUnitID = 0;
            _CRMMDAreaUnitEntity = new CRMMDAreaUnitEntity();
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
