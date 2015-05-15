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
    public class FCCHREmployeeResume
    {

        public FCCHREmployeeResume()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeResumeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeResumeFacade facade = context.Items["IHREmployeeResumeFacade"] as Bay.ERP.BusinessFacade.IHREmployeeResumeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeResumeFacade();
                context.Items["IHREmployeeResumeFacade"] = facade;
            }
            return facade;
        }


    }
}
