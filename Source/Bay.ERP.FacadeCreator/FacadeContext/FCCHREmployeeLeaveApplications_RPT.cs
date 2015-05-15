// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeLeaveApplications_RPT
    {

        public FCCHREmployeeLeaveApplications_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeLeaveApplications_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeLeaveApplications_RPTFacade facade = context.Items["IHREmployeeLeaveApplications_RPTFacade"] as Bay.ERP.BusinessFacade.IHREmployeeLeaveApplications_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeLeaveApplications_RPTFacade();
                context.Items["IHREmployeeLeaveApplications_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
