// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2010, 01:40:09




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Web.Security;

namespace Bay.ERP.Web.UI
{
    public partial class ASCreateNewRoleControl : BaseControl
    {       
        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtRoleName.Text = "";
            }
        }

        #endregion

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!Roles.RoleExists(txtRoleName.Text))
            {
                Roles.CreateRole(txtRoleName.Text);

                //Helper.Url.Redirect("~/Security/ASApplicationAccess.aspx", string.Empty, "ASCurrentRole", txtRoleName.Text);
                MiscUtil.ShowMessage(lblMessage, "Role Information has been added successfully.", false);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Role Already Exists", true);
            }
        }

        #endregion Event
    }
}
