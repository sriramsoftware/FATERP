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
    public class FCCHREmployeeDrivingLicenseInformation
    {

        public FCCHREmployeeDrivingLicenseInformation()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeDrivingLicenseInformationFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeDrivingLicenseInformationFacade facade = context.Items["IHREmployeeDrivingLicenseInformationFacade"] as Bay.ERP.BusinessFacade.IHREmployeeDrivingLicenseInformationFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeDrivingLicenseInformationFacade();
                context.Items["IHREmployeeDrivingLicenseInformationFacade"] = facade;
            }
            return facade;
        }


    }
}
