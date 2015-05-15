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
    public class FCCHREmployeeVisaInfomation
    {

        public FCCHREmployeeVisaInfomation()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeVisaInfomationFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeVisaInfomationFacade facade = context.Items["IHREmployeeVisaInfomationFacade"] as Bay.ERP.BusinessFacade.IHREmployeeVisaInfomationFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeVisaInfomationFacade();
                context.Items["IHREmployeeVisaInfomationFacade"] = facade;
            }
            return facade;
        }


    }
}
