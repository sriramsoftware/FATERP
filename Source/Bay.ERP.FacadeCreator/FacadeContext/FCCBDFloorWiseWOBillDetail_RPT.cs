// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Aug-2013, 01:19:26




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDFloorWiseWOBillDetail_RPT
    {

        public FCCBDFloorWiseWOBillDetail_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDFloorWiseWOBillDetail_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDFloorWiseWOBillDetail_RPTFacade facade = context.Items["IBDFloorWiseWOBillDetail_RPTFacade"] as Bay.ERP.BusinessFacade.IBDFloorWiseWOBillDetail_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDFloorWiseWOBillDetail_RPTFacade();
                context.Items["IBDFloorWiseWOBillDetail_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
