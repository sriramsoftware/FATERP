// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2012, 10:26:53




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDFloor_Detailed
    {

        public FCCMDFloor_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDFloor_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDFloor_DetailedFacade facade = context.Items["IMDFloor_DetailedFacade"] as Bay.ERP.BusinessFacade.IMDFloor_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDFloor_DetailedFacade();
                context.Items["IMDFloor_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
