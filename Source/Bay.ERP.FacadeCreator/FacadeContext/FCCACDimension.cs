// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACDimension
    {

        public FCCACDimension()
        {

        }

        public static Bay.ERP.BusinessFacade.IACDimensionFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACDimensionFacade facade = context.Items["IACDimensionFacade"] as Bay.ERP.BusinessFacade.IACDimensionFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACDimensionFacade();
                context.Items["IACDimensionFacade"] = facade;
            }
            return facade;
        }


    }
}
