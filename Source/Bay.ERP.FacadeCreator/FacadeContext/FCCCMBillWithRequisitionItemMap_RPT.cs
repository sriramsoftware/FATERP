// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 12:10:49




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMBillWithRequisitionItemMap_RPT
    {

        public FCCCMBillWithRequisitionItemMap_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMBillWithRequisitionItemMap_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMBillWithRequisitionItemMap_RPTFacade facade = context.Items["ICMBillWithRequisitionItemMap_RPTFacade"] as Bay.ERP.BusinessFacade.ICMBillWithRequisitionItemMap_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMBillWithRequisitionItemMap_RPTFacade();
                context.Items["ICMBillWithRequisitionItemMap_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
