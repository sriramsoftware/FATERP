// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jan-2012, 09:58:11




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProject_RPT
    {

        public FCCBDProject_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProject_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProject_RPTFacade facade = context.Items["IBDProject_RPTFacade"] as Bay.ERP.BusinessFacade.IBDProject_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProject_RPTFacade();
                context.Items["IBDProject_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
