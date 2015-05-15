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
    public class FCCHREmployeeFamilyInfo
    {

        public FCCHREmployeeFamilyInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeFamilyInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeFamilyInfoFacade facade = context.Items["IHREmployeeFamilyInfoFacade"] as Bay.ERP.BusinessFacade.IHREmployeeFamilyInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeFamilyInfoFacade();
                context.Items["IHREmployeeFamilyInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
