// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




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
    public partial class CMConsultantWorkAreaControl : BaseControl
    {       
        #region Properties

        public Int64 _ConsultantWorkAreaID
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

        public CMConsultantWorkAreaEntity _CMConsultantWorkAreaEntity
        {
            get
            {
                CMConsultantWorkAreaEntity entity = new CMConsultantWorkAreaEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMConsultantWorkAreaEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMConsultantWorkAreaEntity CurrentCMConsultantWorkAreaEntity
        {
            get
            {
                if (_ConsultantWorkAreaID > 0)
                {
                    if (_CMConsultantWorkAreaEntity.ConsultantWorkAreaID != _ConsultantWorkAreaID)
                    {
                        _CMConsultantWorkAreaEntity = FCCCMConsultantWorkArea.GetFacadeCreate().GetByID(_ConsultantWorkAreaID);
                    }
                }

                return _CMConsultantWorkAreaEntity;
            }
            set
            {
                _CMConsultantWorkAreaEntity = value;
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
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMConsultantWorkAreaEntity cMConsultantWorkAreaEntity = CurrentCMConsultantWorkAreaEntity;


            if (!cMConsultantWorkAreaEntity.IsNew)
            {
                txtName.Text = cMConsultantWorkAreaEntity.Name.ToString();
                chkIsRemoved.Checked = cMConsultantWorkAreaEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMConsultantWorkAreaList();
        }

        private void BindCMConsultantWorkAreaList()
        {
            lvCMConsultantWorkArea.DataBind();
        }

        private CMConsultantWorkAreaEntity BuildCMConsultantWorkAreaEntity()
        {
            CMConsultantWorkAreaEntity cMConsultantWorkAreaEntity = CurrentCMConsultantWorkAreaEntity;

            cMConsultantWorkAreaEntity.Name = txtName.Text.Trim();
            cMConsultantWorkAreaEntity.IsRemoved = chkIsRemoved.Checked;


            return cMConsultantWorkAreaEntity;
        }

        private void SaveCMConsultantWorkAreaEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMConsultantWorkAreaEntity cMConsultantWorkAreaEntity = BuildCMConsultantWorkAreaEntity();

                    Int64 result = -1;

                    if (cMConsultantWorkAreaEntity.IsNew)
                    {
                        result = FCCCMConsultantWorkArea.GetFacadeCreate().Add(cMConsultantWorkAreaEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantWorkAreaEntity.FLD_NAME_ConsultantWorkAreaID, cMConsultantWorkAreaEntity.ConsultantWorkAreaID.ToString(), SQLMatchType.Equal);
                        result = FCCCMConsultantWorkArea.GetFacadeCreate().Update(cMConsultantWorkAreaEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ConsultantWorkAreaID = 0;
                        _CMConsultantWorkAreaEntity = new CMConsultantWorkAreaEntity();
                        PrepareInitialView();
                        BindCMConsultantWorkAreaList();

                        if (cMConsultantWorkAreaEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Consultant Work Area Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Consultant Work Area Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMConsultantWorkAreaEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Consultant Work Area Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Consultant Work Area Information.", false);
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

        protected void lvCMConsultantWorkArea_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ConsultantWorkAreaID;

            Int64.TryParse(e.CommandArgument.ToString(), out ConsultantWorkAreaID);

            if (ConsultantWorkAreaID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ConsultantWorkAreaID = ConsultantWorkAreaID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantWorkAreaEntity.FLD_NAME_ConsultantWorkAreaID, ConsultantWorkAreaID.ToString(), SQLMatchType.Equal);

                        CMConsultantWorkAreaEntity cMConsultantWorkAreaEntity = new CMConsultantWorkAreaEntity();


                        result = FCCCMConsultantWorkArea.GetFacadeCreate().Delete(cMConsultantWorkAreaEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ConsultantWorkAreaID = 0;
                            _CMConsultantWorkAreaEntity = new CMConsultantWorkAreaEntity();
                            PrepareInitialView();
                            BindCMConsultantWorkAreaList();

                            MiscUtil.ShowMessage(lblMessage, "Consultant Work Area has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Consultant Work Area.", true);
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

        protected void odsCMConsultantWorkArea_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMConsultantWorkAreaEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ConsultantWorkAreaID = 0;
            _CMConsultantWorkAreaEntity = new CMConsultantWorkAreaEntity();
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
