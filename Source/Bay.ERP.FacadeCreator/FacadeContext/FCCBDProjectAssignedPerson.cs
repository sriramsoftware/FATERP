// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jul-2012, 05:23:43




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectAssignedPerson
    {

        public FCCBDProjectAssignedPerson()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectAssignedPersonFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectAssignedPersonFacade facade = context.Items["IBDProjectAssignedPersonFacade"] as Bay.ERP.BusinessFacade.IBDProjectAssignedPersonFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectAssignedPersonFacade();
                context.Items["IBDProjectAssignedPersonFacade"] = facade;
            }
            return facade;
        }


    }
}
