// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDMDTask
    {

        public FCCBDMDTask()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDMDTaskFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDMDTaskFacade facade = context.Items["IBDMDTaskFacade"] as Bay.ERP.BusinessFacade.IBDMDTaskFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDMDTaskFacade();
                context.Items["IBDMDTaskFacade"] = facade;
            }
            return facade;
        }


    }
}
