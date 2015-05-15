// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 11:49:03




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMBillRequisitionItemMap_Detailed
    {

        public FCCCMBillRequisitionItemMap_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMBillRequisitionItemMap_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMBillRequisitionItemMap_DetailedFacade facade = context.Items["ICMBillRequisitionItemMap_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMBillRequisitionItemMap_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMBillRequisitionItemMap_DetailedFacade();
                context.Items["ICMBillRequisitionItemMap_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
