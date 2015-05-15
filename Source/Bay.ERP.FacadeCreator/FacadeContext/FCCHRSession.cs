// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHRSession
    {

        public FCCHRSession()
        {

        }

        public static Bay.ERP.BusinessFacade.IHRSessionFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHRSessionFacade facade = context.Items["IHRSessionFacade"] as Bay.ERP.BusinessFacade.IHRSessionFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HRSessionFacade();
                context.Items["IHRSessionFacade"] = facade;
            }
            return facade;
        }


    }
}
