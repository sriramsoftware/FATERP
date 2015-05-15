// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-May-2012, 02:36:46




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProject_Detailed
    {

        public FCCBDProject_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProject_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProject_DetailedFacade facade = context.Items["IBDProject_DetailedFacade"] as Bay.ERP.BusinessFacade.IBDProject_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProject_DetailedFacade();
                context.Items["IBDProject_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
