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
    public partial class BDProjectParkingControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectParkingID
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

        public BDProjectParkingEntity _BDProjectParkingEntity
        {
            get
            {
                BDProjectParkingEntity entity = new BDProjectParkingEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectParkingEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectParkingEntity CurrentBDProjectParkingEntity
        {
            get
            {
                if (OverviewProjectID > 0)
                {

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectParkingEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                    IList<BDProjectParkingEntity> BDProjectParkingList = FCCBDProjectParking.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (BDProjectParkingList != null && BDProjectParkingList.Count > 0)
                    {
                        _BDProjectParkingEntity = BDProjectParkingList[0];
                    }
                    else
                    {
                        _BDProjectParkingEntity = new BDProjectParkingEntity();
                    }
                }

                return _BDProjectParkingEntity;
            }
            set
            {
                _BDProjectParkingEntity = value;
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

            txtGround.Text = String.Empty;
            txtLowerGround.Text = String.Empty;
            txtBasement1.Text = String.Empty;
            txtBasement2.Text = String.Empty;
            txtBasement3.Text = String.Empty;
            txtBasement4.Text = String.Empty;
            txtBasement5.Text = String.Empty;
            txtBasement6.Text = String.Empty;
            txtOutdoor.Text = String.Empty;
            txtTotal.Text = String.Empty;
            txtGuestParking.Text = String.Empty;
            txtDisableParking.Text = String.Empty;

            btnSubmit.Text = "Add";
        }

        private void PrepareEditView()
        {
            BDProjectParkingEntity bDProjectParkingEntity = CurrentBDProjectParkingEntity;


            if (!bDProjectParkingEntity.IsNew)
            {
                txtGround.Text = bDProjectParkingEntity.Ground.ToString();
                txtLowerGround.Text = bDProjectParkingEntity.LowerGround.ToString();
                txtBasement1.Text = bDProjectParkingEntity.Basement1.ToString();
                txtBasement2.Text = bDProjectParkingEntity.Basement2.ToString();
                txtBasement3.Text = bDProjectParkingEntity.Basement3.ToString();
                txtBasement4.Text = bDProjectParkingEntity.Basement4.ToString();
                txtBasement5.Text = bDProjectParkingEntity.Basement5.ToString();
                txtBasement6.Text = bDProjectParkingEntity.Basement6.ToString();
                txtOutdoor.Text = bDProjectParkingEntity.Outdoor.ToString();
                txtTotal.Text = bDProjectParkingEntity.Total.ToString();
                txtGuestParking.Text = bDProjectParkingEntity.GuestParking.ToString();
                txtDisableParking.Text = bDProjectParkingEntity.DisableParking.ToString();

                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindBDProjectParkingList();
        }

        private void BindBDProjectParkingList()
        {
           
        }

        private BDProjectParkingEntity BuildBDProjectParkingEntity()
        {
            BDProjectParkingEntity bDProjectParkingEntity = CurrentBDProjectParkingEntity;
            bDProjectParkingEntity.ProjectID = OverviewProjectID;

            if (!txtGround.Text.Trim().IsNullOrEmpty())
            {
                bDProjectParkingEntity.Ground = Decimal.Parse(txtGround.Text.Trim());
            }

            if (!txtLowerGround.Text.Trim().IsNullOrEmpty())
            {
                bDProjectParkingEntity.LowerGround = Decimal.Parse(txtLowerGround.Text.Trim());
            }
            else
            {
                bDProjectParkingEntity.LowerGround = null;
            }

            if (!txtBasement1.Text.Trim().IsNullOrEmpty())
            {
                bDProjectParkingEntity.Basement1 = Decimal.Parse(txtBasement1.Text.Trim());
            }
            else
            {
                bDProjectParkingEntity.Basement1 = null;
            }

            if (!txtBasement2.Text.Trim().IsNullOrEmpty())
            {
                bDProjectParkingEntity.Basement2 = Decimal.Parse(txtBasement2.Text.Trim());
            }
            else
            {
                bDProjectParkingEntity.Basement2 = null;
            }

            if (!txtBasement3.Text.Trim().IsNullOrEmpty())
            {
                bDProjectParkingEntity.Basement3 = Decimal.Parse(txtBasement3.Text.Trim());
            }
            else
            {
                bDProjectParkingEntity.Basement3 = null;
            }

            if (!txtBasement4.Text.Trim().IsNullOrEmpty())
            {
                bDProjectParkingEntity.Basement4 = Decimal.Parse(txtBasement4.Text.Trim());
            }
            else
            {
                bDProjectParkingEntity.Basement4 = null;
            }

            if (!txtBasement5.Text.Trim().IsNullOrEmpty())
            {
                bDProjectParkingEntity.Basement5 = Decimal.Parse(txtBasement5.Text.Trim());
            }
            else
            {
                bDProjectParkingEntity.Basement5 = null;
            }

            if (!txtBasement6.Text.Trim().IsNullOrEmpty())
            {
                bDProjectParkingEntity.Basement6 = Decimal.Parse(txtBasement6.Text.Trim());
            }
            else
            {
                bDProjectParkingEntity.Basement6 = null;
            }

            if (!txtOutdoor.Text.Trim().IsNullOrEmpty())
            {
                bDProjectParkingEntity.Outdoor = Decimal.Parse(txtOutdoor.Text.Trim());
            }
            else
            {
                bDProjectParkingEntity.Outdoor = null;
            }

            if (!txtTotal.Text.Trim().IsNullOrEmpty())
            {
                bDProjectParkingEntity.Total = Decimal.Parse(txtTotal.Text.Trim());
            }

            if (!txtGuestParking.Text.Trim().IsNullOrEmpty())
            {
                bDProjectParkingEntity.GuestParking = Decimal.Parse(txtGuestParking.Text.Trim());
            }

            if (!txtDisableParking.Text.Trim().IsNullOrEmpty())
            {
                bDProjectParkingEntity.DisableParking = Decimal.Parse(txtDisableParking.Text.Trim());
            }
            else
            {
                bDProjectParkingEntity.DisableParking = null;
            }


            return bDProjectParkingEntity;
        }

        private void SaveBDProjectParkingEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectParkingEntity bDProjectParkingEntity = BuildBDProjectParkingEntity();

                    Int64 result = -1;

                    if (bDProjectParkingEntity.IsNew)
                    {
                        result = FCCBDProjectParking.GetFacadeCreate().Add(bDProjectParkingEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectParkingEntity.FLD_NAME_ProjectParkingID, bDProjectParkingEntity.ProjectParkingID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectParking.GetFacadeCreate().Update(bDProjectParkingEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectParkingID = 0;
                        _BDProjectParkingEntity = new BDProjectParkingEntity();
                        PrepareInitialView();
                        PrepareEditView();
                        BindBDProjectParkingList();

                        if (bDProjectParkingEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Parking Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Parking Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectParkingEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Parking Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Parking Information.", false);
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
            SaveBDProjectParkingEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectParkingID = 0;
            _BDProjectParkingEntity = new BDProjectParkingEntity();
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
