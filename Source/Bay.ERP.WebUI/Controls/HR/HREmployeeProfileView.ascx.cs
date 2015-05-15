// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    public partial class HREmployeeProfileViewControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _AdditonalInformationID
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

        public HRAdditonalInformationEntity _HRAdditonalInformationEntity
        {
            get
            {
                HRAdditonalInformationEntity entity = new HRAdditonalInformationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HRAdditonalInformationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HRAdditonalInformationEntity CurrentHRAdditonalInformationEntity
        {
            get
            {
                if (_AdditonalInformationID > 0)
                {
                    if (_HRAdditonalInformationEntity.AdditonalInformationID != _AdditonalInformationID)
                    {
                        _HRAdditonalInformationEntity = FCCHRAdditonalInformation.GetFacadeCreate().GetByID(_AdditonalInformationID);
                    }
                }

                return _HRAdditonalInformationEntity;
            }
            set
            {
                _HRAdditonalInformationEntity = value;
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
        }

        private void PrepareEditView()
        {
            HRAdditonalInformationEntity hRAdditonalInformationEntity = CurrentHRAdditonalInformationEntity;


            if (!hRAdditonalInformationEntity.IsNew)
            {
               
            }
        }

        private void BindList()
        {
            BindHRAdditonalInformationList();
        }

        private void BindHRAdditonalInformationList()
        {
           
        }

        private HRAdditonalInformationEntity BuildHRAdditonalInformationEntity()
        {
            HRAdditonalInformationEntity hRAdditonalInformationEntity = CurrentHRAdditonalInformationEntity;

            hRAdditonalInformationEntity.EmployeeID = OverviewEmployeeID;

            return hRAdditonalInformationEntity;
        }

        private void SaveHRAdditonalInformationEntity()
        {
            if (IsValid)
            {
                try
                {
                    HRAdditonalInformationEntity hRAdditonalInformationEntity = BuildHRAdditonalInformationEntity();

                    Int64 result = -1;

                    if (hRAdditonalInformationEntity.IsNew)
                    {
                        result = FCCHRAdditonalInformation.GetFacadeCreate().Add(hRAdditonalInformationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRAdditonalInformationEntity.FLD_NAME_AdditonalInformationID, hRAdditonalInformationEntity.AdditonalInformationID.ToString(), SQLMatchType.Equal);
                        result = FCCHRAdditonalInformation.GetFacadeCreate().Update(hRAdditonalInformationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AdditonalInformationID = 0;
                        _HRAdditonalInformationEntity = new HRAdditonalInformationEntity();
                        PrepareInitialView();
                        BindHRAdditonalInformationList();

                        if (hRAdditonalInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Additonal Information Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Additonal Information Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hRAdditonalInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Additonal Information Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Additonal Information Information.", false);
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

        #endregion List View Event

        #region Button Event

        #endregion

        #endregion Event
    }
}
