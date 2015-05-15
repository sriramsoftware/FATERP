// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jan-2014, 04:20:23




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeLeaveStatus_RPT
    {

        public FCCHREmployeeLeaveStatus_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeLeaveStatus_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeLeaveStatus_RPTFacade facade = context.Items["IHREmployeeLeaveStatus_RPTFacade"] as Bay.ERP.BusinessFacade.IHREmployeeLeaveStatus_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeLeaveStatus_RPTFacade();
                context.Items["IHREmployeeLeaveStatus_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
