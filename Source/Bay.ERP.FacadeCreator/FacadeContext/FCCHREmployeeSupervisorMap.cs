// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 03:37:27




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeSupervisorMap
    {

        public FCCHREmployeeSupervisorMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeSupervisorMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeSupervisorMapFacade facade = context.Items["IHREmployeeSupervisorMapFacade"] as Bay.ERP.BusinessFacade.IHREmployeeSupervisorMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeSupervisorMapFacade();
                context.Items["IHREmployeeSupervisorMapFacade"] = facade;
            }
            return facade;
        }


    }
}
