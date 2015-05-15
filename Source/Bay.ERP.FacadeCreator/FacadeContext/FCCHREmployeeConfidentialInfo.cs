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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeConfidentialInfo
    {

        public FCCHREmployeeConfidentialInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeConfidentialInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeConfidentialInfoFacade facade = context.Items["IHREmployeeConfidentialInfoFacade"] as Bay.ERP.BusinessFacade.IHREmployeeConfidentialInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeConfidentialInfoFacade();
                context.Items["IHREmployeeConfidentialInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
