// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




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
    public partial class BDProjectLiftControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectLiftID
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

        public BDProjectLiftEntity _BDProjectLiftEntity
        {
            get
            {
                BDProjectLiftEntity entity = new BDProjectLiftEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectLiftEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectLiftEntity CurrentBDProjectLiftEntity
        {
            get
            {
                if (OverviewProjectID > 0)
                {

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectLiftEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                    IList<BDProjectLiftEntity> BDProjectLiftList = FCCBDProjectLift.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (BDProjectLiftList != null && BDProjectLiftList.Count > 0)
                    {
                        _BDProjectLiftEntity = BDProjectLiftList[0];
                    }
                    else
                    {
                        _BDProjectLiftEntity = new BDProjectLiftEntity();
                    }
                }

                return _BDProjectLiftEntity;
            }
            set
            {
                _BDProjectLiftEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            //82 here is default brand name for Lift.
            MiscUtil.PopulateMDBrandByItemID(ddlLifBrandID, false,32774);
            MiscUtil.PopulateMDBrandByItemID(ddlPassengerLiftBrandID, false, 32774);
            MiscUtil.PopulateMDBrandByItemID(ddlServiceLiftBrandID, false, 32774);
            MiscUtil.PopulateMDBrandByItemID(ddlBrandID, false, 32774);
        }

        private void BuildLiftBrandSupplierByBrand()
        {
            if (ddlLifBrandID.Items.Count > 0 && ddlLifBrandID.SelectedValue != "0")
            {
                MiscUtil.PopulatePRMSupplierByBrandID(ddlLiftBrandSupplierID, false, Int64.Parse(ddlLifBrandID.SelectedValue));
            }
            else
            {
                ddlLiftBrandSupplierID.Items.Clear();
            }
        }

        private void BuildPassengerLiftBrandSupplierByBrand()
        {
            if (ddlPassengerLiftBrandID.Items.Count > 0 && ddlPassengerLiftBrandID.SelectedValue != "0")
            {
                MiscUtil.PopulatePRMSupplierByBrandID(ddlPassengerLiftBrandSupplierID, false, Int64.Parse(ddlPassengerLiftBrandID.SelectedValue));
            }
            else
            {
                ddlPassengerLiftBrandSupplierID.Items.Clear();
            }
        }

        private void BuildServiceLiftBrandSupplierByBrand()
        {
            if (ddlServiceLiftBrandID.Items.Count > 0 && ddlServiceLiftBrandID.SelectedValue != "0")
            {
                MiscUtil.PopulatePRMSupplierByBrandID(ddlServiceLiftBrandSupplierID, false, Int64.Parse(ddlServiceLiftBrandID.SelectedValue));
            }
            else
            {
                ddlServiceLiftBrandSupplierID.Items.Clear();
            }
        }

        private void BuildBrandSupplierByBrand()
        {
            if (ddlBrandID.Items.Count > 0 && ddlBrandID.SelectedValue != "0")
            {
                MiscUtil.PopulatePRMSupplierByBrandID(ddlBrandSupplierID, false, Int64.Parse(ddlBrandID.SelectedValue));
            }
            else
            {
                ddlBrandSupplierID.Items.Clear();
            }
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            //BuildLiftBrandSupplierByBrand();
            //BuildPassengerLiftBrandSupplierByBrand();
            //BuildServiceLiftBrandSupplierByBrand();
            //BuildBrandSupplierByBrand();

            txtNumberOfLift.Text = String.Empty;
            txtNumberOfPassengerLift.Text = String.Empty;
            txtCapacityOfPassengerLift.Text = String.Empty;
            txtNumberOfServiceLift.Text = String.Empty;
            txtCapacityOfServiceLift.Text = String.Empty;
            txtNumberOfFireFighterLift.Text = String.Empty;

            btnSubmit.Text = "Add";
        }

        private void PrepareEditView()
        {
            BDProjectLiftEntity bDProjectLiftEntity = CurrentBDProjectLiftEntity;


            if (!bDProjectLiftEntity.IsNew)
            {
                txtNumberOfLift.Text = bDProjectLiftEntity.NumberOfLift.ToString();
                txtNumberOfPassengerLift.Text = bDProjectLiftEntity.NumberOfPassengerLift.ToString();
                txtCapacityOfPassengerLift.Text = bDProjectLiftEntity.CapacityOfPassengerLift.ToString();
                txtNumberOfServiceLift.Text = bDProjectLiftEntity.NumberOfServiceLift.ToString();
                txtCapacityOfServiceLift.Text = bDProjectLiftEntity.CapacityOfServiceLift.ToString();
                txtNumberOfFireFighterLift.Text = bDProjectLiftEntity.NumberOfFireFighterLift.ToString();
                if (ddlLifBrandID.Items.Count > 0 && bDProjectLiftEntity.LiftBrandID != null)
                {
                    ddlLifBrandID.SelectedValue = bDProjectLiftEntity.LiftBrandID.ToString();
                }

                BuildLiftBrandSupplierByBrand();

                if (ddlLiftBrandSupplierID.Items.Count > 0 && bDProjectLiftEntity.LiftBrandSupplierID != null)
                {
                    ddlLiftBrandSupplierID.SelectedValue = bDProjectLiftEntity.LiftBrandSupplierID.ToString();
                }

                if (ddlPassengerLiftBrandID.Items.Count > 0 && bDProjectLiftEntity.PassengerLiftBrandID != null)
                {
                    ddlPassengerLiftBrandID.SelectedValue = bDProjectLiftEntity.PassengerLiftBrandID.ToString();
                }

                BuildPassengerLiftBrandSupplierByBrand();

                if (ddlPassengerLiftBrandSupplierID.Items.Count > 0 && bDProjectLiftEntity.PassengerLiftBrandSupplierID != null)
                {
                    ddlPassengerLiftBrandSupplierID.SelectedValue = bDProjectLiftEntity.PassengerLiftBrandSupplierID.ToString();
                }

                if (ddlServiceLiftBrandID.Items.Count > 0 && bDProjectLiftEntity.ServiceLiftBrandID != null)
                {
                    ddlServiceLiftBrandID.SelectedValue = bDProjectLiftEntity.ServiceLiftBrandID.ToString();
                }

                BuildServiceLiftBrandSupplierByBrand();

                if (ddlServiceLiftBrandSupplierID.Items.Count > 0 && bDProjectLiftEntity.ServiceLiftBrandSupplierID != null)
                {
                    ddlServiceLiftBrandSupplierID.SelectedValue = bDProjectLiftEntity.ServiceLiftBrandSupplierID.ToString();
                }

                if (ddlBrandID.Items.Count > 0 && bDProjectLiftEntity.BrandID != null)
                {
                    ddlBrandID.SelectedValue = bDProjectLiftEntity.BrandID.ToString();
                }

                BuildBrandSupplierByBrand();

                if (ddlBrandSupplierID.Items.Count > 0 && bDProjectLiftEntity.BrandSupplierID != null)
                {
                    ddlBrandSupplierID.SelectedValue = bDProjectLiftEntity.BrandSupplierID.ToString();
                }

                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindBDProjectLiftList();
        }

        private void BindBDProjectLiftList()
        {
          
        }

        private BDProjectLiftEntity BuildBDProjectLiftEntity()
        {
            BDProjectLiftEntity bDProjectLiftEntity = CurrentBDProjectLiftEntity;

            bDProjectLiftEntity.ProjectID = OverviewProjectID;

            if (!txtNumberOfLift.Text.Trim().IsNullOrEmpty())
            {
                bDProjectLiftEntity.NumberOfLift = Decimal.Parse(txtNumberOfLift.Text.Trim());
            }

            if (!txtNumberOfPassengerLift.Text.Trim().IsNullOrEmpty())
            {
                bDProjectLiftEntity.NumberOfPassengerLift = Decimal.Parse(txtNumberOfPassengerLift.Text.Trim());
            }

            if (!txtCapacityOfPassengerLift.Text.Trim().IsNullOrEmpty())
            {
                bDProjectLiftEntity.CapacityOfPassengerLift = Decimal.Parse(txtCapacityOfPassengerLift.Text.Trim());
            }
            else
            {
                bDProjectLiftEntity.CapacityOfPassengerLift = null;
            }

            if (!txtNumberOfServiceLift.Text.Trim().IsNullOrEmpty())
            {
                bDProjectLiftEntity.NumberOfServiceLift = Decimal.Parse(txtNumberOfServiceLift.Text.Trim());
            }
            else
            {
                bDProjectLiftEntity.NumberOfServiceLift = null;
            }

            if (!txtCapacityOfServiceLift.Text.Trim().IsNullOrEmpty())
            {
                bDProjectLiftEntity.CapacityOfServiceLift = Decimal.Parse(txtCapacityOfServiceLift.Text.Trim());
            }
            else
            {
                bDProjectLiftEntity.CapacityOfServiceLift = null;
            }

            if (!txtNumberOfFireFighterLift.Text.Trim().IsNullOrEmpty())
            {
                bDProjectLiftEntity.NumberOfFireFighterLift = Decimal.Parse(txtNumberOfFireFighterLift.Text.Trim());
            }
            else
            {
                bDProjectLiftEntity.NumberOfFireFighterLift = null;
            }

            if (ddlLifBrandID.Items.Count > 0)
            {
                if (ddlLifBrandID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectLiftEntity.LiftBrandID = Int64.Parse(ddlLifBrandID.SelectedValue);
                }
            }

            if (ddlLiftBrandSupplierID.Items.Count > 0)
            {
                if (ddlLiftBrandSupplierID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectLiftEntity.LiftBrandSupplierID = Int64.Parse(ddlLiftBrandSupplierID.SelectedValue);
                }
            }

            if (ddlPassengerLiftBrandID.Items.Count > 0)
            {
                if (ddlPassengerLiftBrandID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectLiftEntity.PassengerLiftBrandID = Int64.Parse(ddlPassengerLiftBrandID.SelectedValue);
                }
            }

            if (ddlPassengerLiftBrandSupplierID.Items.Count > 0)
            {
                if (ddlPassengerLiftBrandSupplierID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectLiftEntity.PassengerLiftBrandSupplierID = Int64.Parse(ddlPassengerLiftBrandSupplierID.SelectedValue);
                }
            }

            if (ddlServiceLiftBrandID.Items.Count > 0)
            {
                if (ddlServiceLiftBrandID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectLiftEntity.ServiceLiftBrandID = Int64.Parse(ddlServiceLiftBrandID.SelectedValue);
                }
            }

            if (ddlServiceLiftBrandSupplierID.Items.Count > 0)
            {
                if (ddlServiceLiftBrandSupplierID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectLiftEntity.ServiceLiftBrandSupplierID = Int64.Parse(ddlServiceLiftBrandSupplierID.SelectedValue);
                }
            }

            if (ddlBrandID.Items.Count > 0)
            {
                if (ddlBrandID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectLiftEntity.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                }
            }

            if (ddlBrandSupplierID.Items.Count > 0)
            {
                if (ddlBrandSupplierID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectLiftEntity.BrandSupplierID = Int64.Parse(ddlBrandSupplierID.SelectedValue);
                }
            }


            return bDProjectLiftEntity;
        }

        private void SaveBDProjectLiftEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectLiftEntity bDProjectLiftEntity = BuildBDProjectLiftEntity();

                    Int64 result = -1;

                    if (bDProjectLiftEntity.IsNew)
                    {
                        result = FCCBDProjectLift.GetFacadeCreate().Add(bDProjectLiftEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectLiftEntity.FLD_NAME_ProjectLiftID, bDProjectLiftEntity.ProjectLiftID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectLift.GetFacadeCreate().Update(bDProjectLiftEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectLiftID = 0;
                        _BDProjectLiftEntity = new BDProjectLiftEntity();
                        PrepareInitialView();
                        PrepareEditView();
                        BindBDProjectLiftList();

                        if (bDProjectLiftEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Lift Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Lift Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectLiftEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Lift Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Lift Information.", false);
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
            SaveBDProjectLiftEntity();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlLifBrandID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildLiftBrandSupplierByBrand();
        }

        protected void ddlPassengerLiftBrandID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildPassengerLiftBrandSupplierByBrand();
        }

        protected void ddlServiceLiftBrandID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildServiceLiftBrandSupplierByBrand();
        }

        protected void ddlBrandID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildBrandSupplierByBrand();
        }

        #endregion

        #endregion Event
    }
}
