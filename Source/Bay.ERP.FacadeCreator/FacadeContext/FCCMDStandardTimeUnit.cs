// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Feb-2012, 04:08:22




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDStandardTimeUnit
    {

        public FCCMDStandardTimeUnit()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDStandardTimeUnitFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDStandardTimeUnitFacade facade = context.Items["IMDStandardTimeUnitFacade"] as Bay.ERP.BusinessFacade.IMDStandardTimeUnitFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDStandardTimeUnitFacade();
                context.Items["IMDStandardTimeUnitFacade"] = facade;
            }
            return facade;
        }


    }
}
