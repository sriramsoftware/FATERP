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
    public class FCCBDProjectHistory_RPT
    {

        public FCCBDProjectHistory_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectHistory_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectHistory_RPTFacade facade = context.Items["IBDProjectHistory_RPTFacade"] as Bay.ERP.BusinessFacade.IBDProjectHistory_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectHistory_RPTFacade();
                context.Items["IBDProjectHistory_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
