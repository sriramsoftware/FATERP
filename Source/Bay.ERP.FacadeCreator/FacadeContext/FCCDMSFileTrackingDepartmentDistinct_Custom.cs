// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Sep-2012, 02:08:47




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCDMSFileTrackingDepartmentDistinct_Custom
    {

        public FCCDMSFileTrackingDepartmentDistinct_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IDMSFileTrackingDepartmentDistinct_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IDMSFileTrackingDepartmentDistinct_CustomFacade facade = context.Items["IDMSFileTrackingDepartmentDistinct_CustomFacade"] as Bay.ERP.BusinessFacade.IDMSFileTrackingDepartmentDistinct_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.DMSFileTrackingDepartmentDistinct_CustomFacade();
                context.Items["IDMSFileTrackingDepartmentDistinct_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
