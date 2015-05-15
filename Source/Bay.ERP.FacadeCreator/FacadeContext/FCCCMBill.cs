// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2012, 10:27:43




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMBill
    {

        public FCCCMBill()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMBillFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMBillFacade facade = context.Items["ICMBillFacade"] as Bay.ERP.BusinessFacade.ICMBillFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMBillFacade();
                context.Items["ICMBillFacade"] = facade;
            }
            return facade;
        }


    }
}
