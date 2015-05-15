// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 05:23:47




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeLeaveStatus_Detailed
    {

        public FCCHREmployeeLeaveStatus_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeLeaveStatus_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeLeaveStatus_DetailedFacade facade = context.Items["IHREmployeeLeaveStatus_DetailedFacade"] as Bay.ERP.BusinessFacade.IHREmployeeLeaveStatus_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeLeaveStatus_DetailedFacade();
                context.Items["IHREmployeeLeaveStatus_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
