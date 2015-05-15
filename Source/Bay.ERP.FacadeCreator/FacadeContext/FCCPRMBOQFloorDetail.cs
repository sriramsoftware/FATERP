// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2012, 01:00:46




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMBOQFloorDetail
    {

        public FCCPRMBOQFloorDetail()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMBOQFloorDetailFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMBOQFloorDetailFacade facade = context.Items["IPRMBOQFloorDetailFacade"] as Bay.ERP.BusinessFacade.IPRMBOQFloorDetailFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMBOQFloorDetailFacade();
                context.Items["IPRMBOQFloorDetailFacade"] = facade;
            }
            return facade;
        }


    }
}
