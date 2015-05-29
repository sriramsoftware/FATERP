// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2015, 10:30:28




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDZoneDesignation
    {

        public FCCMDZoneDesignation()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDZoneDesignationFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDZoneDesignationFacade facade = context.Items["IMDZoneDesignationFacade"] as Bay.ERP.BusinessFacade.IMDZoneDesignationFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDZoneDesignationFacade();
                context.Items["IMDZoneDesignationFacade"] = facade;
            }
            return facade;
        }


    }
}
