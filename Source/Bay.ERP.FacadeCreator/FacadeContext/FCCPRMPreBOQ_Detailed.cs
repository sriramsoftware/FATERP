// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2011, 02:42:27




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMPreBOQ_Detailed
    {

        public FCCPRMPreBOQ_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMPreBOQ_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMPreBOQ_DetailedFacade facade = context.Items["IPRMPreBOQ_DetailedFacade"] as Bay.ERP.BusinessFacade.IPRMPreBOQ_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMPreBOQ_DetailedFacade();
                context.Items["IPRMPreBOQ_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
