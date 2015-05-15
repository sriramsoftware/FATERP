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
    public class FCCCMMeasurementBookByBill_RPT
    {

        public FCCCMMeasurementBookByBill_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMMeasurementBookByBill_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMMeasurementBookByBill_RPTFacade facade = context.Items["ICMMeasurementBookByBill_RPTFacade"] as Bay.ERP.BusinessFacade.ICMMeasurementBookByBill_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMMeasurementBookByBill_RPTFacade();
                context.Items["ICMMeasurementBookByBill_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
