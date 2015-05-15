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
    public partial class CRMMDBookingStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _BookingStatusID
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

        public CRMMDBookingStatusEntity _CRMMDBookingStatusEntity
        {
            get
            {
                CRMMDBookingStatusEntity entity = new CRMMDBookingStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDBookingStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDBookingStatusEntity CurrentCRMMDBookingStatusEntity
        {
            get
            {
                if (_BookingStatusID > 0)
                {
                    if (_CRMMDBookingStatusEntity.BookingStatusID != _BookingStatusID)
                    {
                        _CRMMDBookingStatusEntity = FCCCRMMDBookingStatus.GetFacadeCreate().GetByID(_BookingStatusID);
                    }
                }

                return _CRMMDBookingStatusEntity;
            }
            set
            {
                _CRMMDBookingStatusEntity = value;
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
            CRMMDBookingStatusEntity cRMMDBookingStatusEntity = CurrentCRMMDBookingStatusEntity;


            if (!cRMMDBookingStatusEntity.IsNew)
            {
                txtName.Text = cRMMDBookingStatusEntity.Name.ToString();
                txtDescription.Text = cRMMDBookingStatusEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDBookingStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDBookingStatusList();
        }

        private void BindCRMMDBookingStatusList()
        {
            lvCRMMDBookingStatus.DataBind();
        }

        private CRMMDBookingStatusEntity BuildCRMMDBookingStatusEntity()
        {
            CRMMDBookingStatusEntity cRMMDBookingStatusEntity = CurrentCRMMDBookingStatusEntity;

            cRMMDBookingStatusEntity.Name = txtName.Text.Trim();
            cRMMDBookingStatusEntity.Description = txtDescription.Text.Trim();
            cRMMDBookingStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDBookingStatusEntity;
        }

        private void SaveCRMMDBookingStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDBookingStatusEntity cRMMDBookingStatusEntity = BuildCRMMDBookingStatusEntity();

                    Int64 result = -1;

                    if (cRMMDBookingStatusEntity.IsNew)
                    {
                        result = FCCCRMMDBookingStatus.GetFacadeCreate().Add(cRMMDBookingStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDBookingStatusEntity.FLD_NAME_BookingStatusID, cRMMDBookingStatusEntity.BookingStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDBookingStatus.GetFacadeCreate().Update(cRMMDBookingStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BookingStatusID = 0;
                        _CRMMDBookingStatusEntity = new CRMMDBookingStatusEntity();
                        PrepareInitialView();
                        BindCRMMDBookingStatusList();

                        if (cRMMDBookingStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMBooking Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMBooking Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDBookingStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMBooking Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMBooking Status Information.", false);
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

        protected void lvCRMMDBookingStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BookingStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out BookingStatusID);

            if (BookingStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BookingStatusID = BookingStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDBookingStatusEntity.FLD_NAME_BookingStatusID, BookingStatusID.ToString(), SQLMatchType.Equal);

                        CRMMDBookingStatusEntity cRMMDBookingStatusEntity = new CRMMDBookingStatusEntity();


                        result = FCCCRMMDBookingStatus.GetFacadeCreate().Delete(cRMMDBookingStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BookingStatusID = 0;
                            _CRMMDBookingStatusEntity = new CRMMDBookingStatusEntity();
                            PrepareInitialView();
                            BindCRMMDBookingStatusList();

                            MiscUtil.ShowMessage(lblMessage, "C RMBooking Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMBooking Status.", true);
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

        protected void odsCRMMDBookingStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDBookingStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BookingStatusID = 0;
            _CRMMDBookingStatusEntity = new CRMMDBookingStatusEntity();
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
