// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Jun-2013, 05:04:04




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACResourceBankAccountMap
    {

        public FCCACResourceBankAccountMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IACResourceBankAccountMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACResourceBankAccountMapFacade facade = context.Items["IACResourceBankAccountMapFacade"] as Bay.ERP.BusinessFacade.IACResourceBankAccountMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACResourceBankAccountMapFacade();
                context.Items["IACResourceBankAccountMapFacade"] = facade;
            }
            return facade;
        }


    }
}
