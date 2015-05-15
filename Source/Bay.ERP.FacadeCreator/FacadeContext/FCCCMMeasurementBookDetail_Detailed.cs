// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Oct-2012, 03:40:52




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMMeasurementBookDetail_Detailed
    {

        public FCCCMMeasurementBookDetail_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMMeasurementBookDetail_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMMeasurementBookDetail_DetailedFacade facade = context.Items["ICMMeasurementBookDetail_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMMeasurementBookDetail_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMMeasurementBookDetail_DetailedFacade();
                context.Items["ICMMeasurementBookDetail_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
