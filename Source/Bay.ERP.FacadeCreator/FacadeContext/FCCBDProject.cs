// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-May-2015, 10:52:28




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProject
    {

        public FCCBDProject()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectFacade facade = context.Items["IBDProjectFacade"] as Bay.ERP.BusinessFacade.IBDProjectFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectFacade();
                context.Items["IBDProjectFacade"] = facade;
            }
            return facade;
        }


    }
}
