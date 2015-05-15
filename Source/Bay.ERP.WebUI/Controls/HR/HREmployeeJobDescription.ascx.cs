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
    public partial class HREmployeeJobDescriptionControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeJobDescriptionID
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

        public HREmployeeJobDescriptionEntity _HREmployeeJobDescriptionEntity
        {
            get
            {
                HREmployeeJobDescriptionEntity entity = new HREmployeeJobDescriptionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeJobDescriptionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeJobDescriptionEntity CurrentHREmployeeJobDescriptionEntity
        {
            get
            {
                if (OverviewEmployeeID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeJobDescriptionEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
                    IList<HREmployeeJobDescriptionEntity> lst = FCCHREmployeeJobDescription.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    _HREmployeeJobDescriptionEntity = lst != null ? lst[0] : new HREmployeeJobDescriptionEntity();
                }

                return _HREmployeeJobDescriptionEntity;
            }
            set
            {
                _HREmployeeJobDescriptionEntity = value;
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

            txtDescription.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
        }

        private void PrepareEditView()
        {
            HREmployeeJobDescriptionEntity hREmployeeJobDescriptionEntity = CurrentHREmployeeJobDescriptionEntity;


            if (!hREmployeeJobDescriptionEntity.IsNew)
            {
                txtDescription.Text = hREmployeeJobDescriptionEntity.Description.ToString();
                txtRemarks.Text = hREmployeeJobDescriptionEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindHREmployeeJobDescriptionList();
        }

        private void BindHREmployeeJobDescriptionList()
        {
           
        }

        private HREmployeeJobDescriptionEntity BuildHREmployeeJobDescriptionEntity()
        {
            HREmployeeJobDescriptionEntity hREmployeeJobDescriptionEntity = CurrentHREmployeeJobDescriptionEntity;


            hREmployeeJobDescriptionEntity.EmployeeID = OverviewEmployeeID;

            hREmployeeJobDescriptionEntity.Description = txtDescription.Text.Trim();
            hREmployeeJobDescriptionEntity.Remarks = txtRemarks.Text.Trim();

            hREmployeeJobDescriptionEntity.CreateDate = System.DateTime.Now;


            return hREmployeeJobDescriptionEntity;
        }

        private void SaveHREmployeeJobDescriptionEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeJobDescriptionEntity hREmployeeJobDescriptionEntity = BuildHREmployeeJobDescriptionEntity();

                    Int64 result = -1;

                    if (hREmployeeJobDescriptionEntity.IsNew)
                    {
                        result = FCCHREmployeeJobDescription.GetFacadeCreate().Add(hREmployeeJobDescriptionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeJobDescriptionEntity.FLD_NAME_EmployeeJobDescriptionID, hREmployeeJobDescriptionEntity.EmployeeJobDescriptionID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeJobDescription.GetFacadeCreate().Update(hREmployeeJobDescriptionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeJobDescriptionID = result ;
                        _HREmployeeJobDescriptionEntity = CurrentHREmployeeJobDescriptionEntity;
                        PrepareEditView();
                        BindHREmployeeJobDescriptionList();

                        if (hREmployeeJobDescriptionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Job Description Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Job Description Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeJobDescriptionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Job Description Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Job Description Information.", false);
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
            SaveHREmployeeJobDescriptionEntity();
        }

        #endregion

        #endregion Event
    }
}
