// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class PRMSupplierItemMapAddControl : BaseControl
    {
        
        #region Properties

        public Int64 _SupplierItemMapID
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

        public PRMSupplierItemMapEntity _PRMSupplierItemMapEntity
        {
            get
            {
                PRMSupplierItemMapEntity entity = new PRMSupplierItemMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMSupplierItemMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMSupplierItemMapEntity CurrentPRMSupplierItemMapEntity
        {
            get
            {
                if (_SupplierItemMapID > 0)
                {
                    if (_PRMSupplierItemMapEntity.SupplierItemMapID != _SupplierItemMapID)
                    {
                        _PRMSupplierItemMapEntity = FCCPRMSupplierItemMap.GetFacadeCreate().GetByID(_SupplierItemMapID);
                    }
                }

                return _PRMSupplierItemMapEntity;
            }
            set
            {
                _PRMSupplierItemMapEntity = value;
            }
        }

       public Int64 SupplierID
       {
            get
            {
                Int64 _supplierID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[PRMSupplierItemMapEntity.FLD_NAME_SupplierID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[PRMSupplierItemMapEntity.FLD_NAME_SupplierID], out _supplierID);
                }

                return _supplierID;
            }
       }

       private PRMSupplierEntity CurrentPRMSupplierEntity
       {
           get
           {
               PRMSupplierEntity pmrSupplierEnitity = new PRMSupplierEntity();

               if (SupplierID > 0)
               {
                   pmrSupplierEnitity = FCCPRMSupplier.GetFacadeCreate().GetByID(SupplierID);
               }

               return pmrSupplierEnitity;
           }
       }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {  
            MiscUtil.PopulateMDRegion(ddlOriginRegionID, false);
            BuildCountryByRegion();
        }

        private void BuildCountryByRegion()
        {
            if (ddlOriginRegionID.SelectedValue != "0")
            {
                MiscUtil.PopulateMDCountryByRegionID(ddlOriginCountryID, false, Int64.Parse(ddlOriginRegionID.SelectedValue));
            }
        }

        private void PrepareValidator()
        {
        }

        private void BuildModelLabel()
        {
            PRMSupplierEntity pmrSupplierEntity = CurrentPRMSupplierEntity;

            if(pmrSupplierEntity!=null && pmrSupplierEntity.SupplierID>0)
            {
                switch (pmrSupplierEntity.SupplierTypeID)
                {
                    case MasterDataConstants.MDSupplierType.CONTRACTOR:
                    case MasterDataConstants.MDSupplierType.CONSULTANT:
                        lblModel.Text = "Experties";
                        break;
                    default:
                        lblModel.Text = "Model";
                        break;
                }
            }
        }

        private void PrepareInitialView()
        {
            treeBrandItemMap.SupplierID = SupplierID;
            treeBrandItemMap.ReBuildTree();

            BuildDropDownList();

            txtActualPrice.Text = String.Empty;
            txtDiscountPercentage.Text = "0";
            txtPrice.Text = String.Empty;
            txtModel.Text = String.Empty;
            txtWarrantyPeriod.Text = String.Empty;
            txtEntryDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            chkIsRemoved.Checked = false;

            BuildModelLabel();

            btnSubmit.Text = "Add";
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            String fe = String.Empty;
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_ItemID, treeBrandItemMap.SelectedValue.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_BrandID, treeBrandItemMap.SelectedNode.Parent.Value.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            String feSupplier = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_SupplierID, SupplierID.ToString(), SQLMatchType.Equal);

            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, feSupplier);
            if (ddlOriginRegionID.SelectedValue != "0")
            {
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_OriginRegionID, ddlOriginRegionID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            }

            if (ddlOriginCountryID.SelectedValue != "0")
            {
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_OriginCountryID, ddlOriginCountryID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe4);
            }

            IList<PRMSupplierItemMapEntity> supplierItemMapList = FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (supplierItemMapList!=null && supplierItemMapList.Count> 0)
            {
                MiscUtil.ShowMessage(lblMessage, "Already entered the Item Price.", true);
                validationResult = false;
            }

            return validationResult;
        }

        private void PrepareEditView()
        {
            PRMSupplierItemMapEntity pRMSupplierItemMapEntity = CurrentPRMSupplierItemMapEntity;


            if (!pRMSupplierItemMapEntity.IsNew)
            {

                if (ddlOriginRegionID.Items.Count > 0 && pRMSupplierItemMapEntity.OriginRegionID != null)
                {
                    ddlOriginRegionID.SelectedValue = pRMSupplierItemMapEntity.OriginRegionID.ToString();
                }

                if (ddlOriginCountryID.Items.Count > 0 && pRMSupplierItemMapEntity.OriginCountryID != null)
                {
                    ddlOriginCountryID.SelectedValue = pRMSupplierItemMapEntity.OriginCountryID.ToString();
                }

                txtActualPrice.Text = pRMSupplierItemMapEntity.ActualPrice.ToString();
                txtDiscountPercentage.Text = pRMSupplierItemMapEntity.DiscountPercentage.ToString();
                txtPrice.Text = pRMSupplierItemMapEntity.Price.ToString();
                txtModel.Text = pRMSupplierItemMapEntity.Model.ToString();
                txtWarrantyPeriod.Text = pRMSupplierItemMapEntity.WarrantyPeriod.ToString();
                txtEntryDate.Text = pRMSupplierItemMapEntity.EntryDate.ToStringDefault();
                chkIsRemoved.Checked = pRMSupplierItemMapEntity.IsRemoved;

                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindPRMSupplierItemMapList();
        }

        private void BindPRMSupplierItemMapList()
        {
       
        }

        private PRMSupplierItemMapEntity BuildPRMSupplierItemMapEntity()
        {
            PRMSupplierItemMapEntity pRMSupplierItemMapEntity = CurrentPRMSupplierItemMapEntity;

            pRMSupplierItemMapEntity.SupplierID = SupplierID;
            pRMSupplierItemMapEntity.BrandID = Int64.Parse(treeBrandItemMap.SelectedNode.Parent.Value.ToString());
            pRMSupplierItemMapEntity.ItemID =Int64.Parse(treeBrandItemMap.SelectedValue);

            if (ddlOriginRegionID.Items.Count > 0)
            {
                if (ddlOriginRegionID.SelectedValue == "0")
                {
                    pRMSupplierItemMapEntity.OriginRegionID = null;
                }
                else
                {
                    pRMSupplierItemMapEntity.OriginRegionID = Int64.Parse(ddlOriginRegionID.SelectedValue);
                }
            }

            if (ddlOriginCountryID.Items.Count > 0)
            {
                if (ddlOriginCountryID.SelectedValue == "0")
                {
                    pRMSupplierItemMapEntity.OriginCountryID = null;
                }
                else
                {
                    pRMSupplierItemMapEntity.OriginCountryID = Int64.Parse(ddlOriginCountryID.SelectedValue);
                }
            }

            Decimal actualPrice, discountPercentages, price;

            Decimal.TryParse(txtActualPrice.Text.Trim(), out actualPrice);
            Decimal.TryParse(txtDiscountPercentage.Text.Trim(),out discountPercentages);

            price = actualPrice - (actualPrice * (discountPercentages / 100));


            if (!txtActualPrice.Text.Trim().IsNullOrEmpty())
            {
                pRMSupplierItemMapEntity.ActualPrice = Decimal.Parse(txtActualPrice.Text.Trim());

            }

            if (!txtDiscountPercentage.Text.Trim().IsNullOrEmpty())
            {
                pRMSupplierItemMapEntity.DiscountPercentage = Decimal.Parse(txtDiscountPercentage.Text.Trim());
            }

             pRMSupplierItemMapEntity.Price = price;

            pRMSupplierItemMapEntity.Model = txtModel.Text.Trim();
            if (!txtWarrantyPeriod.Text.Trim().IsNullOrEmpty())
            {
                pRMSupplierItemMapEntity.WarrantyPeriod = Int64.Parse(txtWarrantyPeriod.Text.Trim());
            }
            else
            {
                pRMSupplierItemMapEntity.WarrantyPeriod = null;
            }

            if (txtEntryDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMSupplierItemMapEntity.EntryDate = MiscUtil.ParseToDateTime(txtEntryDate.Text);
            }

            pRMSupplierItemMapEntity.IsRemoved = chkIsRemoved.Checked;


            return pRMSupplierItemMapEntity;
        }

        private void SavePRMSupplierItemMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMSupplierItemMapEntity pRMSupplierItemMapEntity = BuildPRMSupplierItemMapEntity();

                    Int64 result = -1;

                    if (pRMSupplierItemMapEntity.IsNew)
                    {
                        result = FCCPRMSupplierItemMap.GetFacadeCreate().Add(pRMSupplierItemMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_SupplierItemMapID, pRMSupplierItemMapEntity.SupplierItemMapID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMSupplierItemMap.GetFacadeCreate().Update(pRMSupplierItemMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SupplierItemMapID = 0;
                        _PRMSupplierItemMapEntity = new PRMSupplierItemMapEntity();
                        PrepareInitialView();
                        BindPRMSupplierItemMapList();

                        if (pRMSupplierItemMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Item Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Item Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMSupplierItemMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Vendor Item Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Vendor Item Map Information.", false);
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SavePRMSupplierItemMapEntity();
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlOriginRegionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildCountryByRegion();
        }

        #endregion

        #region Tree Events

        protected void treeBrandItemMap_SelectedNodeChanged(object sender, EventArgs e)
        {

            if (treeBrandItemMap.SelectedNode.Depth == 2)
            {
                divUpdatePanel.Visible = true;
            }
            else
            {
                divUpdatePanel.Visible = false;
            }
        }

        #endregion

        #endregion Event
    }
}
