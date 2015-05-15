// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2012, 01:19:25




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMBOQFloorDetail_Detailed
    {

        public FCCPRMBOQFloorDetail_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMBOQFloorDetail_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMBOQFloorDetail_DetailedFacade facade = context.Items["IPRMBOQFloorDetail_DetailedFacade"] as Bay.ERP.BusinessFacade.IPRMBOQFloorDetail_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMBOQFloorDetail_DetailedFacade();
                context.Items["IPRMBOQFloorDetail_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
