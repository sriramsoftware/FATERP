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
    public class FCCHREmployeeAddressInfo
    {

        public FCCHREmployeeAddressInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeAddressInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeAddressInfoFacade facade = context.Items["IHREmployeeAddressInfoFacade"] as Bay.ERP.BusinessFacade.IHREmployeeAddressInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeAddressInfoFacade();
                context.Items["IHREmployeeAddressInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
