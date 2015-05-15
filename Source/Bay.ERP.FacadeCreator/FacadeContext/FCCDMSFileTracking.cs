// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Sep-2012, 10:06:41




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCDMSFileTracking
    {

        public FCCDMSFileTracking()
        {

        }

        public static Bay.ERP.BusinessFacade.IDMSFileTrackingFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IDMSFileTrackingFacade facade = context.Items["IDMSFileTrackingFacade"] as Bay.ERP.BusinessFacade.IDMSFileTrackingFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.DMSFileTrackingFacade();
                context.Items["IDMSFileTrackingFacade"] = facade;
            }
            return facade;
        }


    }
}
