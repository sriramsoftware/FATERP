// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 04:58:29




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCRequisitionWorkOrderMRRDetail_Detailed
    {

        public FCCACCRequisitionWorkOrderMRRDetail_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCRequisitionWorkOrderMRRDetail_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCRequisitionWorkOrderMRRDetail_DetailedFacade facade = context.Items["IACCRequisitionWorkOrderMRRDetail_DetailedFacade"] as Bay.ERP.BusinessFacade.IACCRequisitionWorkOrderMRRDetail_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCRequisitionWorkOrderMRRDetail_DetailedFacade();
                context.Items["IACCRequisitionWorkOrderMRRDetail_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
