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
    public partial class BDProjectWaterReserviorControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectWaterReserviorID
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

        public BDProjectWaterReserviorEntity _BDProjectWaterReserviorEntity
        {
            get
            {
                BDProjectWaterReserviorEntity entity = new BDProjectWaterReserviorEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectWaterReserviorEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectWaterReserviorEntity CurrentBDProjectWaterReserviorEntity
        {
            get
            {
                if (OverviewProjectID > 0)
                {

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectWaterReserviorEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                    IList<BDProjectWaterReserviorEntity> BDProjectWaterReserviorList = FCCBDProjectWaterReservior.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (BDProjectWaterReserviorList != null && BDProjectWaterReserviorList.Count > 0)
                    {
                        _BDProjectWaterReserviorEntity = BDProjectWaterReserviorList[0];
                    }
                    else
                    {
                        _BDProjectWaterReserviorEntity = new BDProjectWaterReserviorEntity();
                    }
                }

                return _BDProjectWaterReserviorEntity;
            }
            set
            {
                _BDProjectWaterReserviorEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            //82 here is default brand name for Lift.
            MiscUtil.PopulateMDUnitWaterIS(ddlUndergroundReserviorUnitID, false);
            MiscUtil.PopulateMDUnitWaterIS(ddlOverheadReserviorUnitID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtCapacityOfUndergroundReservior.Text = String.Empty;
            txtCapacityOfOverheadReservior.Text = String.Empty;

            btnSubmit.Text = "Add";
        }

        private void PrepareEditView()
        {
            BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity = CurrentBDProjectWaterReserviorEntity;


            if (!bDProjectWaterReserviorEntity.IsNew)
            {
                txtCapacityOfUndergroundReservior.Text = bDProjectWaterReserviorEntity.CapacityOfUndergroundReservior.ToString();
                txtCapacityOfOverheadReservior.Text = bDProjectWaterReserviorEntity.CapacityOfOverheadReservior.ToString();
                if (ddlUndergroundReserviorUnitID.Items.Count > 0 && bDProjectWaterReserviorEntity.UndergroundReserviorUnitID != null)
                {
                    ddlUndergroundReserviorUnitID.SelectedValue = bDProjectWaterReserviorEntity.UndergroundReserviorUnitID.ToString();
                }

                if (ddlOverheadReserviorUnitID.Items.Count > 0 && bDProjectWaterReserviorEntity.OverheadReserviorUnitID != null)
                {
                    ddlOverheadReserviorUnitID.SelectedValue = bDProjectWaterReserviorEntity.OverheadReserviorUnitID.ToString();
                }

                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindBDProjectWaterReserviorList();
        }

        private void BindBDProjectWaterReserviorList()
        {
          
        }

        private BDProjectWaterReserviorEntity BuildBDProjectWaterReserviorEntity()
        {
            BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity = CurrentBDProjectWaterReserviorEntity;

            bDProjectWaterReserviorEntity.ProjectID = OverviewProjectID;

            if (!txtCapacityOfUndergroundReservior.Text.Trim().IsNullOrEmpty())
            {
                bDProjectWaterReserviorEntity.CapacityOfUndergroundReservior = Decimal.Parse(txtCapacityOfUndergroundReservior.Text.Trim());
            }
            else
            {
                bDProjectWaterReserviorEntity.CapacityOfUndergroundReservior = null;
            }

            if (!txtCapacityOfOverheadReservior.Text.Trim().IsNullOrEmpty())
            {
                bDProjectWaterReserviorEntity.CapacityOfOverheadReservior = Decimal.Parse(txtCapacityOfOverheadReservior.Text.Trim());
            }
            else
            {
                bDProjectWaterReserviorEntity.CapacityOfOverheadReservior = null;
            }

            if (ddlUndergroundReserviorUnitID.Items.Count > 0)
            {
                if (ddlUndergroundReserviorUnitID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectWaterReserviorEntity.UndergroundReserviorUnitID = Int64.Parse(ddlUndergroundReserviorUnitID.SelectedValue);
                }
            }

            if (ddlOverheadReserviorUnitID.Items.Count > 0)
            {
                if (ddlOverheadReserviorUnitID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectWaterReserviorEntity.OverheadReserviorUnitID = Int64.Parse(ddlOverheadReserviorUnitID.SelectedValue);
                }
            }


            return bDProjectWaterReserviorEntity;
        }

        private void SaveBDProjectWaterReserviorEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity = BuildBDProjectWaterReserviorEntity();

                    Int64 result = -1;

                    if (bDProjectWaterReserviorEntity.IsNew)
                    {
                        result = FCCBDProjectWaterReservior.GetFacadeCreate().Add(bDProjectWaterReserviorEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectWaterReserviorEntity.FLD_NAME_ProjectWaterReserviorID, bDProjectWaterReserviorEntity.ProjectWaterReserviorID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectWaterReservior.GetFacadeCreate().Update(bDProjectWaterReserviorEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectWaterReserviorID = 0;
                        _BDProjectWaterReserviorEntity = new BDProjectWaterReserviorEntity();
                        PrepareInitialView();
                        PrepareEditView();
                        BindBDProjectWaterReserviorList();

                        if (bDProjectWaterReserviorEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Water Reservior Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Water Reservior Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectWaterReserviorEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Water Reservior  Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Water Reservior  Information.", false);
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
            SaveBDProjectWaterReserviorEntity();
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
