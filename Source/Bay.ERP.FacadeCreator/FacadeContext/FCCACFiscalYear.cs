// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACFiscalYear
    {

        public FCCACFiscalYear()
        {

        }

        public static Bay.ERP.BusinessFacade.IACFiscalYearFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACFiscalYearFacade facade = context.Items["IACFiscalYearFacade"] as Bay.ERP.BusinessFacade.IACFiscalYearFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACFiscalYearFacade();
                context.Items["IACFiscalYearFacade"] = facade;
            }
            return facade;
        }


    }
}
