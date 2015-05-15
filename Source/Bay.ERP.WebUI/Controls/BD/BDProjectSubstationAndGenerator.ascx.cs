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
    public partial class BDProjectSubstationAndGeneratorControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectSubstationAndGeneratorID
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

        public BDProjectSubstationAndGeneratorEntity _BDProjectSubstationAndGeneratorEntity
        {
            get
            {
                BDProjectSubstationAndGeneratorEntity entity = new BDProjectSubstationAndGeneratorEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectSubstationAndGeneratorEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectSubstationAndGeneratorEntity CurrentBDProjectSubstationAndGeneratorEntity
        {
            get
            {
                if (OverviewProjectID > 0)
                {

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectSubstationAndGeneratorEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                    IList<BDProjectSubstationAndGeneratorEntity> BDProjectSubstationAndGeneratorEntityList = FCCBDProjectSubstationAndGenerator.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (BDProjectSubstationAndGeneratorEntityList != null && BDProjectSubstationAndGeneratorEntityList.Count > 0)
                    {
                        _BDProjectSubstationAndGeneratorEntity = BDProjectSubstationAndGeneratorEntityList[0];
                    }
                    else
                    {
                        _BDProjectSubstationAndGeneratorEntity = new BDProjectSubstationAndGeneratorEntity();
                    }
                }

                return _BDProjectSubstationAndGeneratorEntity;
            }
            set
            {
                _BDProjectSubstationAndGeneratorEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            //43274 Generator
            MiscUtil.PopulateMDBrandByItemID(ddlBrandID, false, 43274);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtCapacityOfSubstation.Text = String.Empty;
            txtTotalNumberOfGenerator.Text = String.Empty;
            txtCapacityOfGenerator1.Text = String.Empty;
            txtCapacityOfGenerator2.Text = String.Empty;
            txtCapacityOfGenerator3.Text = String.Empty;
            txtCapacityOfGenerator4.Text = String.Empty;
            txtCapacityOfGenerator5.Text = String.Empty;

            btnSubmit.Text = "Add";
        }

        private void PrepareEditView()
        {
            BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity = CurrentBDProjectSubstationAndGeneratorEntity;


            if (!bDProjectSubstationAndGeneratorEntity.IsNew)
            {
            
                txtCapacityOfSubstation.Text = bDProjectSubstationAndGeneratorEntity.CapacityOfSubstation.ToString();
                txtTotalNumberOfGenerator.Text = bDProjectSubstationAndGeneratorEntity.TotalNumberOfGenerator.ToString();
                txtCapacityOfGenerator1.Text = bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator1.ToString();
                txtCapacityOfGenerator2.Text = bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator2.ToString();
                txtCapacityOfGenerator3.Text = bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator3.ToString();
                txtCapacityOfGenerator4.Text = bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator4.ToString();
                txtCapacityOfGenerator5.Text = bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator5.ToString();
                if (ddlBrandID.Items.Count > 0 && bDProjectSubstationAndGeneratorEntity.BrandID != null)
                {
                    ddlBrandID.SelectedValue = bDProjectSubstationAndGeneratorEntity.BrandID.ToString();
                }


                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindBDProjectSubstationAndGeneratorList();
        }

        private void BindBDProjectSubstationAndGeneratorList()
        {
           
        }

        private BDProjectSubstationAndGeneratorEntity BuildBDProjectSubstationAndGeneratorEntity()
        {
            BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity = CurrentBDProjectSubstationAndGeneratorEntity;

            bDProjectSubstationAndGeneratorEntity.ProjectID = OverviewProjectID;

            if (!txtCapacityOfSubstation.Text.Trim().IsNullOrEmpty())
            {
                bDProjectSubstationAndGeneratorEntity.CapacityOfSubstation = Decimal.Parse(txtCapacityOfSubstation.Text.Trim());
            }

            if (!txtTotalNumberOfGenerator.Text.Trim().IsNullOrEmpty())
            {
                bDProjectSubstationAndGeneratorEntity.TotalNumberOfGenerator = Decimal.Parse(txtTotalNumberOfGenerator.Text.Trim());
            }

            if (!txtCapacityOfGenerator1.Text.Trim().IsNullOrEmpty())
            {
                bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator1 = Decimal.Parse(txtCapacityOfGenerator1.Text.Trim());
            }

            if (!txtCapacityOfGenerator2.Text.Trim().IsNullOrEmpty())
            {
                bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator2 = Decimal.Parse(txtCapacityOfGenerator2.Text.Trim());
            }
            else
            {
                bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator2 = null;
            }

            if (!txtCapacityOfGenerator3.Text.Trim().IsNullOrEmpty())
            {
                bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator3 = Decimal.Parse(txtCapacityOfGenerator3.Text.Trim());
            }
            else
            {
                bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator3 = null;
            }

            if (!txtCapacityOfGenerator4.Text.Trim().IsNullOrEmpty())
            {
                bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator4 = Decimal.Parse(txtCapacityOfGenerator4.Text.Trim());
            }
            else
            {
                bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator4 = null;
            }

            if (!txtCapacityOfGenerator5.Text.Trim().IsNullOrEmpty())
            {
                bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator5 = Decimal.Parse(txtCapacityOfGenerator5.Text.Trim());
            }
            else
            {
                bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator5 = null;
            }

            if (ddlBrandID.Items.Count > 0)
            {
                if (ddlBrandID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectSubstationAndGeneratorEntity.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                }
            }


            return bDProjectSubstationAndGeneratorEntity;
        }

        private void SaveBDProjectSubstationAndGeneratorEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity = BuildBDProjectSubstationAndGeneratorEntity();

                    Int64 result = -1;

                    if (bDProjectSubstationAndGeneratorEntity.IsNew)
                    {
                        result = FCCBDProjectSubstationAndGenerator.GetFacadeCreate().Add(bDProjectSubstationAndGeneratorEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectSubstationAndGeneratorEntity.FLD_NAME_ProjectSubstationAndGeneratorID, bDProjectSubstationAndGeneratorEntity.ProjectSubstationAndGeneratorID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectSubstationAndGenerator.GetFacadeCreate().Update(bDProjectSubstationAndGeneratorEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectSubstationAndGeneratorID = 0;
                        _BDProjectSubstationAndGeneratorEntity = new BDProjectSubstationAndGeneratorEntity();
                        PrepareInitialView();
                        PrepareEditView();
                        BindBDProjectSubstationAndGeneratorList();

                        if (bDProjectSubstationAndGeneratorEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Substation And Generator Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Substation And Generator Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectSubstationAndGeneratorEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Substation And Generator Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Substation And Generator Information.", false);
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
            SaveBDProjectSubstationAndGeneratorEntity();
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
