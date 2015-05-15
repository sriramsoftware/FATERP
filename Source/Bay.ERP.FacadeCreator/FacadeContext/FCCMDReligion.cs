// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDReligion
    {

        public FCCMDReligion()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDReligionFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDReligionFacade facade = context.Items["IMDReligionFacade"] as Bay.ERP.BusinessFacade.IMDReligionFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDReligionFacade();
                context.Items["IMDReligionFacade"] = facade;
            }
            return facade;
        }


    }
}
