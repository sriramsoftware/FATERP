// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMMDLandLocation
    {

        public FCCCRMMDLandLocation()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMMDLandLocationFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMMDLandLocationFacade facade = context.Items["ICRMMDLandLocationFacade"] as Bay.ERP.BusinessFacade.ICRMMDLandLocationFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMMDLandLocationFacade();
                context.Items["ICRMMDLandLocationFacade"] = facade;
            }
            return facade;
        }


    }
}
