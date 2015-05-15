// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Jun-2013, 04:10:14




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectCutom_RPT
    {

        public FCCBDProjectCutom_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectCutom_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectCutom_RPTFacade facade = context.Items["IBDProjectCutom_RPTFacade"] as Bay.ERP.BusinessFacade.IBDProjectCutom_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectCutom_RPTFacade();
                context.Items["IBDProjectCutom_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
