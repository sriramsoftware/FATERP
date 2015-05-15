// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jan-2013, 05:19:48




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCPrePayableStatementDistinct_Custom
    {

        public FCCACCPrePayableStatementDistinct_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCPrePayableStatementDistinct_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCPrePayableStatementDistinct_CustomFacade facade = context.Items["IACCPrePayableStatementDistinct_CustomFacade"] as Bay.ERP.BusinessFacade.IACCPrePayableStatementDistinct_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCPrePayableStatementDistinct_CustomFacade();
                context.Items["IACCPrePayableStatementDistinct_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
