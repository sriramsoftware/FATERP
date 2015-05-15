// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2012, 10:35:09




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectAssignedPerson_Detailed
    {

        public FCCBDProjectAssignedPerson_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectAssignedPerson_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectAssignedPerson_DetailedFacade facade = context.Items["IBDProjectAssignedPerson_DetailedFacade"] as Bay.ERP.BusinessFacade.IBDProjectAssignedPerson_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectAssignedPerson_DetailedFacade();
                context.Items["IBDProjectAssignedPerson_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
