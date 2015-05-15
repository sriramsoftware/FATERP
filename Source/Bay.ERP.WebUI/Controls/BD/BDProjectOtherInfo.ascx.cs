// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




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
    public partial class BDProjectOtherInfoControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectOtherInfoID
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

        public BDProjectOtherInfoEntity _BDProjectOtherInfoEntity
        {
            get
            {
                BDProjectOtherInfoEntity entity = new BDProjectOtherInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectOtherInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectOtherInfoEntity CurrentBDProjectOtherInfoEntity
        {
            get
            {
                if (this.OverviewProjectID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectOtherInfoEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                   IList<BDProjectOtherInfoEntity> BDProjectOtherInfoList = FCCBDProjectOtherInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                   if (BDProjectOtherInfoList != null && BDProjectOtherInfoList.Count > 0)
                   {
                       _BDProjectOtherInfoEntity = BDProjectOtherInfoList[0];
                   }
                   else
                   {
                       _BDProjectOtherInfoEntity = new BDProjectOtherInfoEntity();
                   }
                }

                return _BDProjectOtherInfoEntity;
            }
            set
            {
                _BDProjectOtherInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDUnit(ddlTBAUnitID, true);
            MiscUtil.PopulateMDUnit(ddlFIAUnitID, true);
            MiscUtil.PopulateMDUnit(ddlFIAAchievedUnitID, true);
            MiscUtil.PopulateMDUnit(ddlGSAUnitID, true);
            MiscUtil.PopulateMDUnit(ddlMGCAreaUnitID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtTBA.Text = String.Empty;
            txtFAR.Text = String.Empty;
            txtFARBonus.Text = String.Empty;
            txtFIA.Text = String.Empty;
            txtFIAAchieved.Text = String.Empty;
            txtGSA.Text = String.Empty;
            txtMGCPercentages.Text = String.Empty;
            txtMGCArea.Text = String.Empty;
            txtGroundCoverage.Text = String.Empty;
            txtDateOfAgreement.Text = String.Empty;
            txtDateOfHandover.Text = String.Empty;
            txtDelayClause.Text = String.Empty;

        }

        private void PrepareEditView()
        {
            BDProjectOtherInfoEntity bDProjectOtherInfoEntity = CurrentBDProjectOtherInfoEntity;


            if (!bDProjectOtherInfoEntity.IsNew)
            {

                txtTBA.Text = bDProjectOtherInfoEntity.TBA.ToString();
                if (ddlTBAUnitID.Items.Count > 0 && bDProjectOtherInfoEntity.TBAUnitID != null)
                {
                    ddlTBAUnitID.SelectedValue = bDProjectOtherInfoEntity.TBAUnitID.ToString();
                }

                txtFAR.Text = bDProjectOtherInfoEntity.FAR.ToString();
                txtFARBonus.Text = bDProjectOtherInfoEntity.FARBonus.ToString();
                txtFIA.Text = bDProjectOtherInfoEntity.FIA.ToString();
                if (ddlFIAUnitID.Items.Count > 0 && bDProjectOtherInfoEntity.FIAUnitID != null)
                {
                    ddlFIAUnitID.SelectedValue = bDProjectOtherInfoEntity.FIAUnitID.ToString();
                }

                txtFIAAchieved.Text = bDProjectOtherInfoEntity.FIAAchieved.ToString();
                if (ddlFIAAchievedUnitID.Items.Count > 0 && bDProjectOtherInfoEntity.FIAAchievedUnitID != null)
                {
                    ddlFIAAchievedUnitID.SelectedValue = bDProjectOtherInfoEntity.FIAAchievedUnitID.ToString();
                }

                txtGSA.Text = bDProjectOtherInfoEntity.GSA.ToString();
                if (ddlGSAUnitID.Items.Count > 0 && bDProjectOtherInfoEntity.GSAUnitID != null)
                {
                    ddlGSAUnitID.SelectedValue = bDProjectOtherInfoEntity.GSAUnitID.ToString();
                }

                txtMGCPercentages.Text = bDProjectOtherInfoEntity.MGCPercentages.ToString();
                txtMGCArea.Text = bDProjectOtherInfoEntity.MGCArea.ToString();
                if (ddlMGCAreaUnitID.Items.Count > 0 && bDProjectOtherInfoEntity.MGCAreaUnitID != null)
                {
                    ddlMGCAreaUnitID.SelectedValue = bDProjectOtherInfoEntity.MGCAreaUnitID.ToString();
                }

                txtGroundCoverage.Text = bDProjectOtherInfoEntity.GroundCoverage.ToString();
                txtDateOfAgreement.Text = bDProjectOtherInfoEntity.DateOfAgreement.ToStringDefault();
                txtDateOfHandover.Text = bDProjectOtherInfoEntity.DateOfHandover.ToStringDefault();
                txtDelayClause.Text = bDProjectOtherInfoEntity.DelayClause.ToString();

                btnSubmit.Text = "Update";
            }
        }

        private BDProjectOtherInfoEntity BuildBDProjectOtherInfoEntity()
        {
            BDProjectOtherInfoEntity bDProjectOtherInfoEntity = CurrentBDProjectOtherInfoEntity;

            bDProjectOtherInfoEntity.ProjectID = this.OverviewProjectID;

            if (!txtTBA.Text.Trim().IsNullOrEmpty())
            {
                bDProjectOtherInfoEntity.TBA = Decimal.Parse(txtTBA.Text.Trim());
            }
            else
            {
                bDProjectOtherInfoEntity.TBA = null;
            }

            if (ddlTBAUnitID.Items.Count > 0)
            {
                if (ddlTBAUnitID.SelectedValue == "0")
                {
                    bDProjectOtherInfoEntity.TBAUnitID = null;
                }
                else
                {
                    bDProjectOtherInfoEntity.TBAUnitID = Int64.Parse(ddlTBAUnitID.SelectedValue);
                }
            }

            if (!txtFAR.Text.Trim().IsNullOrEmpty())
            {
                bDProjectOtherInfoEntity.FAR = Decimal.Parse(txtFAR.Text.Trim());
            }
            else
            {
                bDProjectOtherInfoEntity.FAR = null;
            }

            if (!txtFARBonus.Text.Trim().IsNullOrEmpty())
            {
                bDProjectOtherInfoEntity.FARBonus = Decimal.Parse(txtFARBonus.Text.Trim());
            }
            else
            {
                bDProjectOtherInfoEntity.FARBonus = null;
            }

            if (!txtFIA.Text.Trim().IsNullOrEmpty())
            {
                bDProjectOtherInfoEntity.FIA = Decimal.Parse(txtFIA.Text.Trim());
            }
            else
            {
                bDProjectOtherInfoEntity.FIA = null;
            }

            if (ddlFIAUnitID.Items.Count > 0)
            {
                if (ddlFIAUnitID.SelectedValue == "0")
                {
                    bDProjectOtherInfoEntity.FIAUnitID = null;
                }
                else
                {
                    bDProjectOtherInfoEntity.FIAUnitID = Int64.Parse(ddlFIAUnitID.SelectedValue);
                }
            }

            if (!txtFIAAchieved.Text.Trim().IsNullOrEmpty())
            {
                bDProjectOtherInfoEntity.FIAAchieved = Decimal.Parse(txtFIAAchieved.Text.Trim());
            }
            else
            {
                bDProjectOtherInfoEntity.FIAAchieved = null;
            }

            if (ddlFIAAchievedUnitID.Items.Count > 0)
            {
                if (ddlFIAAchievedUnitID.SelectedValue == "0")
                {
                    bDProjectOtherInfoEntity.FIAAchievedUnitID = null;
                }
                else
                {
                    bDProjectOtherInfoEntity.FIAAchievedUnitID = Int64.Parse(ddlFIAAchievedUnitID.SelectedValue);
                }
            }

            if (!txtGSA.Text.Trim().IsNullOrEmpty())
            {
                bDProjectOtherInfoEntity.GSA = Decimal.Parse(txtGSA.Text.Trim());
            }
            else
            {
                bDProjectOtherInfoEntity.GSA = null;
            }

            if (ddlGSAUnitID.Items.Count > 0)
            {
                if (ddlGSAUnitID.SelectedValue == "0")
                {
                    bDProjectOtherInfoEntity.GSAUnitID = null;
                }
                else
                {
                    bDProjectOtherInfoEntity.GSAUnitID = Int64.Parse(ddlGSAUnitID.SelectedValue);
                }
            }

            if (!txtMGCPercentages.Text.Trim().IsNullOrEmpty())
            {
                bDProjectOtherInfoEntity.MGCPercentages = Decimal.Parse(txtMGCPercentages.Text.Trim());
            }
            else
            {
                bDProjectOtherInfoEntity.MGCPercentages = null;
            }

            if (!txtMGCArea.Text.Trim().IsNullOrEmpty())
            {
                bDProjectOtherInfoEntity.MGCArea = Decimal.Parse(txtMGCArea.Text.Trim());
            }
            else
            {
                bDProjectOtherInfoEntity.MGCArea = null;
            }

            if (ddlMGCAreaUnitID.Items.Count > 0)
            {
                if (ddlMGCAreaUnitID.SelectedValue == "0")
                {
                    bDProjectOtherInfoEntity.MGCAreaUnitID = null;
                }
                else
                {
                    bDProjectOtherInfoEntity.MGCAreaUnitID = Int64.Parse(ddlMGCAreaUnitID.SelectedValue);
                }
            }

            bDProjectOtherInfoEntity.GroundCoverage = txtGroundCoverage.Text.Trim();
            if (txtDateOfAgreement.Text.Trim().IsNotNullOrEmpty())
            {
                bDProjectOtherInfoEntity.DateOfAgreement = MiscUtil.ParseToDateTime(txtDateOfAgreement.Text);
            }
            else
            {
                bDProjectOtherInfoEntity.DateOfAgreement = null;
            }

            if (txtDateOfHandover.Text.Trim().IsNotNullOrEmpty())
            {
                bDProjectOtherInfoEntity.DateOfHandover = MiscUtil.ParseToDateTime(txtDateOfHandover.Text);
            }
            else
            {
                bDProjectOtherInfoEntity.DateOfHandover = null;
            }

            bDProjectOtherInfoEntity.DelayClause = txtDelayClause.Text.Trim();

            return bDProjectOtherInfoEntity;
        }

        private void SaveBDProjectOtherInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectOtherInfoEntity bDProjectOtherInfoEntity = BuildBDProjectOtherInfoEntity();

                    Int64 result = -1;

                    if (bDProjectOtherInfoEntity.IsNew)
                    {
                        result = FCCBDProjectOtherInfo.GetFacadeCreate().Add(bDProjectOtherInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectOtherInfoEntity.FLD_NAME_ProjectOtherInfoID, bDProjectOtherInfoEntity.ProjectOtherInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectOtherInfo.GetFacadeCreate().Update(bDProjectOtherInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectOtherInfoID = 0;
                        _BDProjectOtherInfoEntity = new BDProjectOtherInfoEntity();
                        PrepareInitialView();

                        if (bDProjectOtherInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Other Info Information has been Updated successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Other Info Information has been updated successfully.", false);
                        }

                        PrepareEditView();
                    }
                    else
                    {
                        if (bDProjectOtherInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Other Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Other Info Information.", false);
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
            SaveBDProjectOtherInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectOtherInfoID = 0;
            _BDProjectOtherInfoEntity = new BDProjectOtherInfoEntity();
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
