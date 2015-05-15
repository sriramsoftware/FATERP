// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDSupervisorType
    {

        public FCCMDSupervisorType()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDSupervisorTypeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDSupervisorTypeFacade facade = context.Items["IMDSupervisorTypeFacade"] as Bay.ERP.BusinessFacade.IMDSupervisorTypeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDSupervisorTypeFacade();
                context.Items["IMDSupervisorTypeFacade"] = facade;
            }
            return facade;
        }


    }
}
