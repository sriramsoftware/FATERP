// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 01:23:18




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
    public partial class CMConsultantEnlistedWorkAreaControl : ConsultantBaseControl
    {       
        #region Properties

        public Int64 _ConsultantEnlistedWorkAreaID
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

        public CMConsultantEnlistedWorkAreaEntity _CMConsultantEnlistedWorkAreaEntity
        {
            get
            {
                CMConsultantEnlistedWorkAreaEntity entity = new CMConsultantEnlistedWorkAreaEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMConsultantEnlistedWorkAreaEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMConsultantEnlistedWorkAreaEntity CurrentCMConsultantEnlistedWorkAreaEntity
        {
            get
            {
                if (_ConsultantEnlistedWorkAreaID > 0)
                {
                    if (_CMConsultantEnlistedWorkAreaEntity.ConsultantEnlistedWorkAreaID != _ConsultantEnlistedWorkAreaID)
                    {
                        _CMConsultantEnlistedWorkAreaEntity = FCCCMConsultantEnlistedWorkArea.GetFacadeCreate().GetByID(_ConsultantEnlistedWorkAreaID);
                    }
                }

                return _CMConsultantEnlistedWorkAreaEntity;
            }
            set
            {
                _CMConsultantEnlistedWorkAreaEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            
            MiscUtil.PopulateCMConsultantWorkArea(ddlConsultantWorkAreaID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();


            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity = CurrentCMConsultantEnlistedWorkAreaEntity;


            if (!cMConsultantEnlistedWorkAreaEntity.IsNew)
            {
                
                if (ddlConsultantWorkAreaID.Items.Count > 0 && cMConsultantEnlistedWorkAreaEntity.ConsultantWorkAreaID != null)
                {
                    ddlConsultantWorkAreaID.SelectedValue = cMConsultantEnlistedWorkAreaEntity.ConsultantWorkAreaID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMConsultantEnlistedWorkAreaList();
        }

        private void BindCMConsultantEnlistedWorkAreaList()
        {
            lvCMConsultantEnlistedWorkArea.DataBind();
        }

        private CMConsultantEnlistedWorkAreaEntity BuildCMConsultantEnlistedWorkAreaEntity()
        {
            CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity = CurrentCMConsultantEnlistedWorkAreaEntity;

            cMConsultantEnlistedWorkAreaEntity.ConsultantID = this.OverviewConsultantID;

            if (ddlConsultantWorkAreaID.Items.Count > 0)
            {
                if (ddlConsultantWorkAreaID.SelectedValue == "0")
                {
                }
                else
                {
                    cMConsultantEnlistedWorkAreaEntity.ConsultantWorkAreaID = Int64.Parse(ddlConsultantWorkAreaID.SelectedValue);
                }
            }


            return cMConsultantEnlistedWorkAreaEntity;
        }

        private void SaveCMConsultantEnlistedWorkAreaEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity = BuildCMConsultantEnlistedWorkAreaEntity();

                    Int64 result = -1;

                    if (cMConsultantEnlistedWorkAreaEntity.IsNew)
                    {
                        result = FCCCMConsultantEnlistedWorkArea.GetFacadeCreate().Add(cMConsultantEnlistedWorkAreaEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantEnlistedWorkAreaEntity.FLD_NAME_ConsultantEnlistedWorkAreaID, cMConsultantEnlistedWorkAreaEntity.ConsultantEnlistedWorkAreaID.ToString(), SQLMatchType.Equal);
                        result = FCCCMConsultantEnlistedWorkArea.GetFacadeCreate().Update(cMConsultantEnlistedWorkAreaEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ConsultantEnlistedWorkAreaID = 0;
                        _CMConsultantEnlistedWorkAreaEntity = new CMConsultantEnlistedWorkAreaEntity();
                        PrepareInitialView();
                        BindCMConsultantEnlistedWorkAreaList();

                        if (cMConsultantEnlistedWorkAreaEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Consultant Enlisted Work Area Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Consultant Enlisted Work Area Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMConsultantEnlistedWorkAreaEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Consultant Enlisted Work Area Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Consultant Enlisted Work Area Information.", false);
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

        protected void lvCMConsultantEnlistedWorkArea_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ConsultantEnlistedWorkAreaID;

            Int64.TryParse(e.CommandArgument.ToString(), out ConsultantEnlistedWorkAreaID);

            if (ConsultantEnlistedWorkAreaID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ConsultantEnlistedWorkAreaID = ConsultantEnlistedWorkAreaID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantEnlistedWorkAreaEntity.FLD_NAME_ConsultantEnlistedWorkAreaID, ConsultantEnlistedWorkAreaID.ToString(), SQLMatchType.Equal);

                        CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity = new CMConsultantEnlistedWorkAreaEntity();


                        result = FCCCMConsultantEnlistedWorkArea.GetFacadeCreate().Delete(cMConsultantEnlistedWorkAreaEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ConsultantEnlistedWorkAreaID = 0;
                            _CMConsultantEnlistedWorkAreaEntity = new CMConsultantEnlistedWorkAreaEntity();
                            PrepareInitialView();
                            BindCMConsultantEnlistedWorkAreaList();

                            MiscUtil.ShowMessage(lblMessage, "Consultant Enlisted Work Area has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Consultant Enlisted Work Area.", true);
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

        protected void odsCMConsultantEnlistedWorkArea_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CMConsultantEnlistedWorkArea." + CMConsultantEnlistedWorkAreaEntity.FLD_NAME_ConsultantID, this.OverviewConsultantID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMConsultantEnlistedWorkAreaEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ConsultantEnlistedWorkAreaID = 0;
            _CMConsultantEnlistedWorkAreaEntity = new CMConsultantEnlistedWorkAreaEntity();
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
