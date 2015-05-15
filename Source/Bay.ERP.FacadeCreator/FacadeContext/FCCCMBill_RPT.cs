// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Oct-2012, 01:00:56




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMBill_RPT
    {

        public FCCCMBill_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMBill_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMBill_RPTFacade facade = context.Items["ICMBill_RPTFacade"] as Bay.ERP.BusinessFacade.ICMBill_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMBill_RPTFacade();
                context.Items["ICMBill_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
