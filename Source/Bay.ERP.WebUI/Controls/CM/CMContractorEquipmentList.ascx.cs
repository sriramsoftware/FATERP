// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public partial class CMContractorEquipmentListControl : ContractorBaseControl
    {       
        #region Properties

        public Int64 _ContractorEquipmentID
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

        public CMContractorEquipmentListEntity _CMContractorEquipmentListEntity
        {
            get
            {
                CMContractorEquipmentListEntity entity = new CMContractorEquipmentListEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMContractorEquipmentListEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMContractorEquipmentListEntity CurrentCMContractorEquipmentListEntity
        {
            get
            {
                if (_ContractorEquipmentID > 0)
                {
                    if (_CMContractorEquipmentListEntity.ContractorEquipmentID != _ContractorEquipmentID)
                    {
                        _CMContractorEquipmentListEntity = FCCCMContractorEquipmentList.GetFacadeCreate().GetByID(_ContractorEquipmentID);
                    }
                }

                return _CMContractorEquipmentListEntity;
            }
            set
            {
                _CMContractorEquipmentListEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMConstructionTool(ddlConstructionToolID, false);
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
            CMContractorEquipmentListEntity cMContractorEquipmentListEntity = CurrentCMContractorEquipmentListEntity;


            if (!cMContractorEquipmentListEntity.IsNew)
            {
                
                if (ddlConstructionToolID.Items.Count > 0 && cMContractorEquipmentListEntity.ConstructionToolID != null)
                {
                    ddlConstructionToolID.SelectedValue = cMContractorEquipmentListEntity.ConstructionToolID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMContractorEquipmentListList();
        }

        private void BindCMContractorEquipmentListList()
        {
            lvCMContractorEquipmentList.DataBind();
        }

        private CMContractorEquipmentListEntity BuildCMContractorEquipmentListEntity()
        {
            CMContractorEquipmentListEntity cMContractorEquipmentListEntity = CurrentCMContractorEquipmentListEntity;

            cMContractorEquipmentListEntity.ContractorID = this.OverviewContractorID;

            if (ddlConstructionToolID.Items.Count > 0)
            {
                if (ddlConstructionToolID.SelectedValue == "0")
                {
                }
                else
                {
                    cMContractorEquipmentListEntity.ConstructionToolID = Int64.Parse(ddlConstructionToolID.SelectedValue);
                }
            }


            return cMContractorEquipmentListEntity;
        }

        private void SaveCMContractorEquipmentListEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMContractorEquipmentListEntity cMContractorEquipmentListEntity = BuildCMContractorEquipmentListEntity();

                    Int64 result = -1;

                    if (cMContractorEquipmentListEntity.IsNew)
                    {
                        result = FCCCMContractorEquipmentList.GetFacadeCreate().Add(cMContractorEquipmentListEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMContractorEquipmentListEntity.FLD_NAME_ContractorEquipmentID, cMContractorEquipmentListEntity.ContractorEquipmentID.ToString(), SQLMatchType.Equal);
                        result = FCCCMContractorEquipmentList.GetFacadeCreate().Update(cMContractorEquipmentListEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ContractorEquipmentID = 0;
                        _CMContractorEquipmentListEntity = new CMContractorEquipmentListEntity();
                        PrepareInitialView();
                        BindCMContractorEquipmentListList();

                        if (cMContractorEquipmentListEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Equipment Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Equipment Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMContractorEquipmentListEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Contractor Equipment Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Contractor Equipment Information.", false);
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

        protected void lvCMContractorEquipmentList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ContractorEquipmentID;

            Int64.TryParse(e.CommandArgument.ToString(), out ContractorEquipmentID);

            if (ContractorEquipmentID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ContractorEquipmentID = ContractorEquipmentID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMContractorEquipmentListEntity.FLD_NAME_ContractorEquipmentID, ContractorEquipmentID.ToString(), SQLMatchType.Equal);

                        CMContractorEquipmentListEntity cMContractorEquipmentListEntity = new CMContractorEquipmentListEntity();


                        result = FCCCMContractorEquipmentList.GetFacadeCreate().Delete(cMContractorEquipmentListEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ContractorEquipmentID = 0;
                            _CMContractorEquipmentListEntity = new CMContractorEquipmentListEntity();
                            PrepareInitialView();
                            BindCMContractorEquipmentListList();

                            MiscUtil.ShowMessage(lblMessage, "Contractor Equipment has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Contractor Equipment.", true);
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

        protected void odsCMContractorEquipmentList_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CMContractorEquipmentList."+CMContractorEquipmentListEntity.FLD_NAME_ContractorID, this.OverviewContractorID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMContractorEquipmentListEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ContractorEquipmentID = 0;
            _CMContractorEquipmentListEntity = new CMContractorEquipmentListEntity();
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
