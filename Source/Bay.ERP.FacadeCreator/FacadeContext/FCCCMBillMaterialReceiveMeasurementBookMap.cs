// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Feb-2013, 04:16:42




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMBillMaterialReceiveMeasurementBookMap
    {

        public FCCCMBillMaterialReceiveMeasurementBookMap()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMBillMaterialReceiveMeasurementBookMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMBillMaterialReceiveMeasurementBookMapFacade facade = context.Items["ICMBillMaterialReceiveMeasurementBookMapFacade"] as Bay.ERP.BusinessFacade.ICMBillMaterialReceiveMeasurementBookMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMBillMaterialReceiveMeasurementBookMapFacade();
                context.Items["ICMBillMaterialReceiveMeasurementBookMapFacade"] = facade;
            }
            return facade;
        }


    }
}
