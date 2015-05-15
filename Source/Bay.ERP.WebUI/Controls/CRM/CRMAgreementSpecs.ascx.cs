// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Apr-2013, 01:26:57




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
    public partial class CRMAgreementSpecsControl : BaseControl
    {       
        #region Properties

        public Int64 _AgreementSpecsID
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

        public CRMAgreementSpecsEntity _CRMAgreementSpecsEntity
        {
            get
            {
                CRMAgreementSpecsEntity entity = new CRMAgreementSpecsEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMAgreementSpecsEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMAgreementSpecsEntity CurrentCRMAgreementSpecsEntity
        {
            get
            {
                if (_AgreementSpecsID > 0)
                {
                    if (_CRMAgreementSpecsEntity.AgreementSpecsID != _AgreementSpecsID)
                    {
                        _CRMAgreementSpecsEntity = FCCCRMAgreementSpecs.GetFacadeCreate().GetByID(_AgreementSpecsID);
                    }
                }

                return _CRMAgreementSpecsEntity;
            }
            set
            {
                _CRMAgreementSpecsEntity = value;
            }
        }

        public Int64 OverviewAgreementID
        {
            get
            {
                Int64 cRMAgreementID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_AGREEMENT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_AGREEMENT_ID], out cRMAgreementID);
                }

                return cRMAgreementID;
            }
        }

        private CRMAgreementEntity CurrentAgreementEntity
        {
            get
            {
                CRMAgreementEntity AgreementEntity = new CRMAgreementEntity();

                if (OverviewAgreementID > 0)
                {
                    AgreementEntity = FCCCRMAgreement.GetFacadeCreate().GetByID(OverviewAgreementID);
                }

                return AgreementEntity;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {   
            MiscUtil.PopulateMDBrand(ddlBrandID, false);
            MiscUtil.PopulateMDUnit(ddlUnitID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtItemName.Text = String.Empty;
            txtBayQty.Text = String.Empty;
            txtBayPrice.Text = String.Empty;
            txtCustomerQty.Text = String.Empty;
            txtCustomerPrice.Text = String.Empty;
            txtField2.Text = String.Empty;
            txtvar0.Text = String.Empty;
            txtvar1.Text = String.Empty;
            txtvar2.Text = String.Empty;
            txtvar3.Text = String.Empty;
            txtvar4.Text = String.Empty;
            txtvar5.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtAgreementSpecsType.Text = String.Empty;

            hypProjectID.Value = CurrentAgreementEntity.ProjectID.ToString();

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMAgreementSpecsEntity cRMAgreementSpecsEntity = CurrentCRMAgreementSpecsEntity;


            if (!cRMAgreementSpecsEntity.IsNew)
            {
                txtItemName.Text = cRMAgreementSpecsEntity.Item.ToString();
                if (ddlBrandID.Items.Count > 0 && cRMAgreementSpecsEntity.BrandID != null)
                {
                    ddlBrandID.SelectedValue = cRMAgreementSpecsEntity.BrandID.ToString();
                }

                if (ddlUnitID.Items.Count > 0 && cRMAgreementSpecsEntity.Field1 != null)
                {
                   // ddlUnitID.Text = cRMAgreementSpecsEntity.Field1;
                }

                txtBayQty.Text = cRMAgreementSpecsEntity.BayQty.ToString();
                txtBayPrice.Text = cRMAgreementSpecsEntity.BayPrice.ToString();
                txtCustomerQty.Text = cRMAgreementSpecsEntity.CustomerQty.ToString();
                txtCustomerPrice.Text = cRMAgreementSpecsEntity.CustomerPrice.ToString();
                txtField2.Text = cRMAgreementSpecsEntity.Field2.ToString();
                txtvar0.Text = cRMAgreementSpecsEntity.var0.ToString();
                txtvar1.Text = cRMAgreementSpecsEntity.var1.ToString();
                txtvar2.Text = cRMAgreementSpecsEntity.var2.ToString();
                txtvar3.Text = cRMAgreementSpecsEntity.var3.ToString();
                txtvar4.Text = cRMAgreementSpecsEntity.var4.ToString();
                txtvar5.Text = cRMAgreementSpecsEntity.var5.ToString();
                txtRemarks.Text = cRMAgreementSpecsEntity.Remarks.ToString();
                txtAgreementSpecsType.Text = cRMAgreementSpecsEntity.AgreementSpecsType.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMAgreementSpecsList();
            BindCRMAgreementVariableMap();
        }

        private void BindCRMAgreementSpecsList()
        {
            lvCRMAgreementSpecs.DataBind();
        }

        private void BindCRMAgreementVariableMap()
        {
            lvCRMAgreementVariableMap.DataBind();
        }

        private CRMAgreementSpecsEntity BuildCRMAgreementSpecsEntity()
        {
            CRMAgreementSpecsEntity cRMAgreementSpecsEntity = CurrentCRMAgreementSpecsEntity;

            cRMAgreementSpecsEntity.AgreementID = OverviewAgreementID;

            cRMAgreementSpecsEntity.Item = txtItemName.Text.Trim();
            if (ddlBrandID.Items.Count > 0)
            {
                if (ddlBrandID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementSpecsEntity.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                }
            }

            if (!txtBayQty.Text.Trim().IsNullOrEmpty())
            {
                cRMAgreementSpecsEntity.BayQty = Decimal.Parse(txtBayQty.Text.Trim());
            }
            else
            {
                cRMAgreementSpecsEntity.BayQty = null;
            }

            if (!txtBayPrice.Text.Trim().IsNullOrEmpty())
            {
                cRMAgreementSpecsEntity.BayPrice = Decimal.Parse(txtBayPrice.Text.Trim());
            }
            else
            {
                cRMAgreementSpecsEntity.BayPrice = null;
            }

            if (!txtCustomerQty.Text.Trim().IsNullOrEmpty())
            {
                cRMAgreementSpecsEntity.CustomerQty = Decimal.Parse(txtCustomerQty.Text.Trim());
            }
            else
            {
                cRMAgreementSpecsEntity.CustomerQty = null;
            }

            if (!txtCustomerPrice.Text.Trim().IsNullOrEmpty())
            {
                cRMAgreementSpecsEntity.CustomerPrice = Decimal.Parse(txtCustomerPrice.Text.Trim());
            }
            else
            {
                cRMAgreementSpecsEntity.CustomerPrice = null;
            }

            if (ddlUnitID.Items.Count > 0)
            {
                if (ddlUnitID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementSpecsEntity.Field1 = ddlUnitID.SelectedItem.ToString();
                }
            }

            cRMAgreementSpecsEntity.Field2 = txtField2.Text.Trim();
            cRMAgreementSpecsEntity.var0 = txtvar0.Text.Trim();
            cRMAgreementSpecsEntity.var1 = txtvar1.Text.Trim();
            cRMAgreementSpecsEntity.var2 = txtvar2.Text.Trim();
            cRMAgreementSpecsEntity.var3 = txtvar3.Text.Trim();
            cRMAgreementSpecsEntity.var4 = txtvar4.Text.Trim();
            cRMAgreementSpecsEntity.var5 = txtvar5.Text.Trim();
            cRMAgreementSpecsEntity.Remarks = txtRemarks.Text.Trim();
            cRMAgreementSpecsEntity.AgreementSpecsType = txtAgreementSpecsType.Text.Trim();

            return cRMAgreementSpecsEntity;
        }

        private void SaveCRMAgreementSpecsEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMAgreementSpecsEntity cRMAgreementSpecsEntity = BuildCRMAgreementSpecsEntity();

                    Int64 result = -1;

                    if (cRMAgreementSpecsEntity.IsNew)
                    {
                        result = FCCCRMAgreementSpecs.GetFacadeCreate().Add(cRMAgreementSpecsEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementSpecsEntity.FLD_NAME_AgreementSpecsID, cRMAgreementSpecsEntity.AgreementSpecsID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMAgreementSpecs.GetFacadeCreate().Update(cRMAgreementSpecsEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        if (cRMAgreementSpecsEntity.IsNew)
                        {
                            for (Int32 i = 1; i <= 5; i++)
                            {
                                CRMAgreementVariableMapEntity ent = new CRMAgreementVariableMapEntity();
                                switch(i)
                                {
                                    //case 1:
                                    //    ent.Name = "&lt;%$$" + cRMAgreementSpecsEntity.AgreementSpecsType+"_"+cRMAgreementSpecsEntity.Item +"_IName"+ result.ToString() + "%&gt;";
                                    //    ent.Value = cRMAgreementSpecsEntity.Item;
                                    //    break;
                                    //case 2:
                                    //    ent.Name = "&lt;%$$" + cRMAgreementSpecsEntity.AgreementSpecsType + "_" + ddlBrandID.SelectedItem + "_IBrand_" + result.ToString() + "%&gt;";
                                    //    ent.Value = ddlBrandID.SelectedItem.ToString();
                                    //    break;
                                    //case 3:
                                    //    ent.Name = "&lt;%$$" + cRMAgreementSpecsEntity.AgreementSpecsType + "_" + cRMAgreementSpecsEntity.Item+"_IQty_"+ result.ToString()+ "%&gt;";
                                    //    ent.Value = cRMAgreementSpecsEntity.BayQty.ToString();
                                    //    break;
                                    //case 4:
                                    //    ent.Name = "&lt;%$$" + cRMAgreementSpecsEntity.AgreementSpecsType + "_" + cRMAgreementSpecsEntity.Item+"_IPrice_"+ result.ToString()+"%&gt;";
                                    //    ent.Value = cRMAgreementSpecsEntity.BayPrice.ToString();
                                    //    break;
                                    //case 5:
                                    //    ent.Name = "&lt;%$$" + cRMAgreementSpecsEntity.AgreementSpecsType + "_" + cRMAgreementSpecsEntity.Field1+ "_IUnit_"+ result.ToString() + "%&gt;";
                                    //    ent.Value = cRMAgreementSpecsEntity.Field1.ToString();
                                    //    break;

                                    case 1:
                                        ent.Name = "&lt;%$$" + cRMAgreementSpecsEntity.AgreementSpecsType + "_IName" + result.ToString() + "%&gt;";
                                        ent.Value = cRMAgreementSpecsEntity.Item;
                                        break;
                                    case 2:
                                        ent.Name = "&lt;%$$" + cRMAgreementSpecsEntity.AgreementSpecsType +"_IBrand_" + result.ToString() + "%&gt;";
                                        ent.Value = ddlBrandID.SelectedItem.ToString();
                                        break;
                                    case 3:
                                        ent.Name = "&lt;%$$" + cRMAgreementSpecsEntity.AgreementSpecsType + "_IQty_" + result.ToString() + "%&gt;";
                                        ent.Value = cRMAgreementSpecsEntity.BayQty.ToString();
                                        break;
                                    case 4:
                                        ent.Name = "&lt;%$$" + cRMAgreementSpecsEntity.AgreementSpecsType + "_IPrice_" + result.ToString() + "%&gt;";
                                        ent.Value = cRMAgreementSpecsEntity.BayPrice.ToString();
                                        break;
                                    case 5:
                                        ent.Name = "&lt;%$$" + cRMAgreementSpecsEntity.AgreementSpecsType + "_IUnit_" + result.ToString() + "%&gt;";
                                        ent.Value = cRMAgreementSpecsEntity.Field1.ToString();
                                        break;
                                }

                                ent.CreateDate = System.DateTime.Now;
                                ent.CreatedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                                ent.IP = MiscUtil.GetLocalIP();
                                ent.Remarks = "Auto Generated";
                                ent.AgreementID = OverviewAgreementID;

                                FCCCRMAgreementVariableMap.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                            }
                        }
                        _AgreementSpecsID = 0;
                        _CRMAgreementSpecsEntity = new CRMAgreementSpecsEntity();
                        PrepareInitialView();
                        BindCRMAgreementSpecsList();

                        if (cRMAgreementSpecsEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Specs Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Specs Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMAgreementSpecsEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Agreement Specs Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Agreement Specs Information.", false);
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

        protected void lvCRMAgreementSpecs_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AgreementSpecsID;

            Int64.TryParse(e.CommandArgument.ToString(), out AgreementSpecsID);

            if (AgreementSpecsID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AgreementSpecsID = AgreementSpecsID;

                    PrepareEditView();

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementSpecsEntity.FLD_NAME_AgreementSpecsID, AgreementSpecsID.ToString(), SQLMatchType.Equal);

                        CRMAgreementSpecsEntity cRMAgreementSpecsEntity = new CRMAgreementSpecsEntity();


                        result = FCCCRMAgreementSpecs.GetFacadeCreate().Delete(cRMAgreementSpecsEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AgreementSpecsID = 0;
                            _CRMAgreementSpecsEntity = new CRMAgreementSpecsEntity();
                            PrepareInitialView();
                            BindCRMAgreementSpecsList();

                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Specs has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMAgreement Specs.", true);
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

        protected void odsCRMAgreementSpecs_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementSpecsEntity.FLD_NAME_AgreementID, OverviewAgreementID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region ObjectDataSource Event

        protected void odsCRMAgreementVariableMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_AgreementID, OverviewAgreementID.ToString(), SQLMatchType.Equal);

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_Name, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_Value, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMAgreementSpecsEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AgreementSpecsID = 0;
            _CRMAgreementSpecsEntity = new CRMAgreementSpecsEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
