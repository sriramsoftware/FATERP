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
    public class FCCHREmployeePassportInformation
    {

        public FCCHREmployeePassportInformation()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeePassportInformationFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeePassportInformationFacade facade = context.Items["IHREmployeePassportInformationFacade"] as Bay.ERP.BusinessFacade.IHREmployeePassportInformationFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeePassportInformationFacade();
                context.Items["IHREmployeePassportInformationFacade"] = facade;
            }
            return facade;
        }


    }
}
