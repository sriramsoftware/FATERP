// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 03:28:28




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
    public partial class ACAccountOverviewControl : BaseControl
    {       
        #region Properties

        public Int64 _AccountID
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

        public ACAccountEntity _ACAccountEntity
        {
            get
            {
                ACAccountEntity entity = new ACAccountEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACAccountEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACAccountEntity CurrentACAccountEntity
        {
            get
            {
                if (_AccountID > 0)
                {
                    if (_ACAccountEntity.AccountID != _AccountID)
                    {
                        _ACAccountEntity = FCCACAccount.GetFacadeCreate().GetByID(_AccountID);
                    }
                }

                return _ACAccountEntity;
            }
            set
            {
                _ACAccountEntity = value;
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
           
         
        }

        private void BindList()
        {
            BindACAccountList();
        }

        private void BindACAccountList()
        {
            
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

        #region ObjectDataSource Event

      

        #endregion

        #region Button Event

     

        #endregion

        #endregion Event
    }
}
