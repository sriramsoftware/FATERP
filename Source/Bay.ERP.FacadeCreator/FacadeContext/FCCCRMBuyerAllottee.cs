// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMBuyerAllottee
    {

        public FCCCRMBuyerAllottee()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMBuyerAllotteeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMBuyerAllotteeFacade facade = context.Items["ICRMBuyerAllotteeFacade"] as Bay.ERP.BusinessFacade.ICRMBuyerAllotteeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMBuyerAllotteeFacade();
                context.Items["ICRMBuyerAllotteeFacade"] = facade;
            }
            return facade;
        }


    }
}
