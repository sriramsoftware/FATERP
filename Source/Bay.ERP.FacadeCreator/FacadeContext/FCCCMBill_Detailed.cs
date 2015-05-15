// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Nov-2012, 05:21:50




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMBill_Detailed
    {

        public FCCCMBill_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMBill_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMBill_DetailedFacade facade = context.Items["ICMBill_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMBill_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMBill_DetailedFacade();
                context.Items["ICMBill_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
