// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Oct-2012, 04:30:09




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMAbstractMeasurementBookHelper_Custom
    {

        public FCCCMAbstractMeasurementBookHelper_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMAbstractMeasurementBookHelper_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMAbstractMeasurementBookHelper_CustomFacade facade = context.Items["ICMAbstractMeasurementBookHelper_CustomFacade"] as Bay.ERP.BusinessFacade.ICMAbstractMeasurementBookHelper_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMAbstractMeasurementBookHelper_CustomFacade();
                context.Items["ICMAbstractMeasurementBookHelper_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}