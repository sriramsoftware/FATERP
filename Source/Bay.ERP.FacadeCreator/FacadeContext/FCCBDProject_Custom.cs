// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-May-2012, 03:43:24




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProject_Custom
    {

        public FCCBDProject_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProject_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProject_CustomFacade facade = context.Items["IBDProject_CustomFacade"] as Bay.ERP.BusinessFacade.IBDProject_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProject_CustomFacade();
                context.Items["IBDProject_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
