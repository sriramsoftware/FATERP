// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jul-2012, 05:23:43




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDProjectAssignedPersonTeamRole
    {

        public FCCMDProjectAssignedPersonTeamRole()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDProjectAssignedPersonTeamRoleFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDProjectAssignedPersonTeamRoleFacade facade = context.Items["IMDProjectAssignedPersonTeamRoleFacade"] as Bay.ERP.BusinessFacade.IMDProjectAssignedPersonTeamRoleFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDProjectAssignedPersonTeamRoleFacade();
                context.Items["IMDProjectAssignedPersonTeamRoleFacade"] = facade;
            }
            return facade;
        }


    }
}
