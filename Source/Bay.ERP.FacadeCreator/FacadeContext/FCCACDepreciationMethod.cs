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
    public class FCCACDepreciationMethod
    {

        public FCCACDepreciationMethod()
        {

        }

        public static Bay.ERP.BusinessFacade.IACDepreciationMethodFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACDepreciationMethodFacade facade = context.Items["IACDepreciationMethodFacade"] as Bay.ERP.BusinessFacade.IACDepreciationMethodFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACDepreciationMethodFacade();
                context.Items["IACDepreciationMethodFacade"] = facade;
            }
            return facade;
        }


    }
}
