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
    public class FCCHREmployeeEducation
    {

        public FCCHREmployeeEducation()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeEducationFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeEducationFacade facade = context.Items["IHREmployeeEducationFacade"] as Bay.ERP.BusinessFacade.IHREmployeeEducationFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeEducationFacade();
                context.Items["IHREmployeeEducationFacade"] = facade;
            }
            return facade;
        }


    }
}
