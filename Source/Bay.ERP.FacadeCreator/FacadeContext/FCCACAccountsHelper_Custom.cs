// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Feb-2013, 02:12:00




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACAccountsHelper_Custom
    {

        public FCCACAccountsHelper_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IACAccountsHelper_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACAccountsHelper_CustomFacade facade = context.Items["IACAccountsHelper_CustomFacade"] as Bay.ERP.BusinessFacade.IACAccountsHelper_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACAccountsHelper_CustomFacade();
                context.Items["IACAccountsHelper_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
