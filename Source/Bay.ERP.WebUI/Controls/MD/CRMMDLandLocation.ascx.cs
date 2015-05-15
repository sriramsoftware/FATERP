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
    public partial class CRMMDLandLocationControl : BaseControl
    {       
        #region Properties

        public Int64 _LandLocationID
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

        public CRMMDLandLocationEntity _CRMMDLandLocationEntity
        {
            get
            {
                CRMMDLandLocationEntity entity = new CRMMDLandLocationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDLandLocationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDLandLocationEntity CurrentCRMMDLandLocationEntity
        {
            get
            {
                if (_LandLocationID > 0)
                {
                    if (_CRMMDLandLocationEntity.LandLocationID != _LandLocationID)
                    {
                        _CRMMDLandLocationEntity = FCCCRMMDLandLocation.GetFacadeCreate().GetByID(_LandLocationID);
                    }
                }

                return _CRMMDLandLocationEntity;
            }
            set
            {
                _CRMMDLandLocationEntity = value;
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
            CRMMDLandLocationEntity cRMMDLandLocationEntity = CurrentCRMMDLandLocationEntity;


            if (!cRMMDLandLocationEntity.IsNew)
            {
                txtName.Text = cRMMDLandLocationEntity.Name.ToString();
                txtDescription.Text = cRMMDLandLocationEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDLandLocationEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDLandLocationList();
        }

        private void BindCRMMDLandLocationList()
        {
            lvCRMMDLandLocation.DataBind();
        }

        private CRMMDLandLocationEntity BuildCRMMDLandLocationEntity()
        {
            CRMMDLandLocationEntity cRMMDLandLocationEntity = CurrentCRMMDLandLocationEntity;

            cRMMDLandLocationEntity.Name = txtName.Text.Trim();
            cRMMDLandLocationEntity.Description = txtDescription.Text.Trim();
            cRMMDLandLocationEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDLandLocationEntity;
        }

        private void SaveCRMMDLandLocationEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDLandLocationEntity cRMMDLandLocationEntity = BuildCRMMDLandLocationEntity();

                    Int64 result = -1;

                    if (cRMMDLandLocationEntity.IsNew)
                    {
                        result = FCCCRMMDLandLocation.GetFacadeCreate().Add(cRMMDLandLocationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDLandLocationEntity.FLD_NAME_LandLocationID, cRMMDLandLocationEntity.LandLocationID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDLandLocation.GetFacadeCreate().Update(cRMMDLandLocationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _LandLocationID = 0;
                        _CRMMDLandLocationEntity = new CRMMDLandLocationEntity();
                        PrepareInitialView();
                        BindCRMMDLandLocationList();

                        if (cRMMDLandLocationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMLand Location Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMLand Location Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDLandLocationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMLand Location Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMLand Location Information.", false);
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

        protected void lvCRMMDLandLocation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 LandLocationID;

            Int64.TryParse(e.CommandArgument.ToString(), out LandLocationID);

            if (LandLocationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _LandLocationID = LandLocationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDLandLocationEntity.FLD_NAME_LandLocationID, LandLocationID.ToString(), SQLMatchType.Equal);

                        CRMMDLandLocationEntity cRMMDLandLocationEntity = new CRMMDLandLocationEntity();


                        result = FCCCRMMDLandLocation.GetFacadeCreate().Delete(cRMMDLandLocationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _LandLocationID = 0;
                            _CRMMDLandLocationEntity = new CRMMDLandLocationEntity();
                            PrepareInitialView();
                            BindCRMMDLandLocationList();

                            MiscUtil.ShowMessage(lblMessage, "C RMLand Location has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMLand Location.", true);
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

        protected void odsCRMMDLandLocation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDLandLocationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _LandLocationID = 0;
            _CRMMDLandLocationEntity = new CRMMDLandLocationEntity();
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
