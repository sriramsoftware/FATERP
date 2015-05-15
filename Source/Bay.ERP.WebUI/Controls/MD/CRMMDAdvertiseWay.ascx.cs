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
    public partial class CRMMDAdvertiseWayControl : BaseControl
    {       
        #region Properties

        public Int64 _AdvertiseWayID
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

        public CRMMDAdvertiseWayEntity _CRMMDAdvertiseWayEntity
        {
            get
            {
                CRMMDAdvertiseWayEntity entity = new CRMMDAdvertiseWayEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDAdvertiseWayEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDAdvertiseWayEntity CurrentCRMMDAdvertiseWayEntity
        {
            get
            {
                if (_AdvertiseWayID > 0)
                {
                    if (_CRMMDAdvertiseWayEntity.AdvertiseWayID != _AdvertiseWayID)
                    {
                        _CRMMDAdvertiseWayEntity = FCCCRMMDAdvertiseWay.GetFacadeCreate().GetByID(_AdvertiseWayID);
                    }
                }

                return _CRMMDAdvertiseWayEntity;
            }
            set
            {
                _CRMMDAdvertiseWayEntity = value;
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
            CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity = CurrentCRMMDAdvertiseWayEntity;


            if (!cRMMDAdvertiseWayEntity.IsNew)
            {
                txtName.Text = cRMMDAdvertiseWayEntity.Name.ToString();
                txtDescription.Text = cRMMDAdvertiseWayEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDAdvertiseWayEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDAdvertiseWayList();
        }

        private void BindCRMMDAdvertiseWayList()
        {
            lvCRMMDAdvertiseWay.DataBind();
        }

        private CRMMDAdvertiseWayEntity BuildCRMMDAdvertiseWayEntity()
        {
            CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity = CurrentCRMMDAdvertiseWayEntity;

            cRMMDAdvertiseWayEntity.Name = txtName.Text.Trim();
            cRMMDAdvertiseWayEntity.Description = txtDescription.Text.Trim();
            cRMMDAdvertiseWayEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDAdvertiseWayEntity;
        }

        private void SaveCRMMDAdvertiseWayEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity = BuildCRMMDAdvertiseWayEntity();

                    Int64 result = -1;

                    if (cRMMDAdvertiseWayEntity.IsNew)
                    {
                        result = FCCCRMMDAdvertiseWay.GetFacadeCreate().Add(cRMMDAdvertiseWayEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAdvertiseWayEntity.FLD_NAME_AdvertiseWayID, cRMMDAdvertiseWayEntity.AdvertiseWayID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDAdvertiseWay.GetFacadeCreate().Update(cRMMDAdvertiseWayEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AdvertiseWayID = 0;
                        _CRMMDAdvertiseWayEntity = new CRMMDAdvertiseWayEntity();
                        PrepareInitialView();
                        BindCRMMDAdvertiseWayList();

                        if (cRMMDAdvertiseWayEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMAdvertise Way Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMAdvertise Way Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDAdvertiseWayEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMAdvertise Way Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMAdvertise Way Information.", false);
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

        protected void lvCRMMDAdvertiseWay_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AdvertiseWayID;

            Int64.TryParse(e.CommandArgument.ToString(), out AdvertiseWayID);

            if (AdvertiseWayID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AdvertiseWayID = AdvertiseWayID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAdvertiseWayEntity.FLD_NAME_AdvertiseWayID, AdvertiseWayID.ToString(), SQLMatchType.Equal);

                        CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity = new CRMMDAdvertiseWayEntity();


                        result = FCCCRMMDAdvertiseWay.GetFacadeCreate().Delete(cRMMDAdvertiseWayEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AdvertiseWayID = 0;
                            _CRMMDAdvertiseWayEntity = new CRMMDAdvertiseWayEntity();
                            PrepareInitialView();
                            BindCRMMDAdvertiseWayList();

                            MiscUtil.ShowMessage(lblMessage, "C RMAdvertise Way has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMAdvertise Way.", true);
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

        protected void odsCRMMDAdvertiseWay_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDAdvertiseWayEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AdvertiseWayID = 0;
            _CRMMDAdvertiseWayEntity = new CRMMDAdvertiseWayEntity();
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
