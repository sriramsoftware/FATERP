// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMBillFloorDetail
    {

        public FCCCMBillFloorDetail()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMBillFloorDetailFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMBillFloorDetailFacade facade = context.Items["ICMBillFloorDetailFacade"] as Bay.ERP.BusinessFacade.ICMBillFloorDetailFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMBillFloorDetailFacade();
                context.Items["ICMBillFloorDetailFacade"] = facade;
            }
            return facade;
        }


    }
}
