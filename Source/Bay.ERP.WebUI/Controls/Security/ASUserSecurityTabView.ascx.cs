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
using System.Web.UI;

namespace Bay.ERP.Web.UI
{
    public partial class ASUserSecurityTabViewControl : BaseControl
    {       
        #region Properties


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
          
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {

            Page.ClientScript.RegisterStartupScript(this.GetType(), "selecttab", "$('#tabs').tabs({ selected: " + hidLastTab.Value + " });", true);

            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
            }
        }

        #endregion

        #region Button Event

        #endregion

        #endregion Event
    }
}
