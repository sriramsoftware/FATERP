// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jan-2013, 12:49:20




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCompanyInfo
    {

        public FCCACCompanyInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCompanyInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCompanyInfoFacade facade = context.Items["IACCompanyInfoFacade"] as Bay.ERP.BusinessFacade.IACCompanyInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCompanyInfoFacade();
                context.Items["IACCompanyInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
