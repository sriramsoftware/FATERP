// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 07:14:37




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDZone
    {

        public FCCMDZone()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDZoneFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDZoneFacade facade = context.Items["IMDZoneFacade"] as Bay.ERP.BusinessFacade.IMDZoneFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDZoneFacade();
                context.Items["IMDZoneFacade"] = facade;
            }
            return facade;
        }


    }
}
