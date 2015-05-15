// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Dec-2011, 02:17:33




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDCity_Detailed
    {

        public FCCMDCity_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDCity_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDCity_DetailedFacade facade = context.Items["IMDCity_DetailedFacade"] as Bay.ERP.BusinessFacade.IMDCity_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDCity_DetailedFacade();
                context.Items["IMDCity_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
