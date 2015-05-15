// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMMDAdvertiseWay
    {

        public FCCCRMMDAdvertiseWay()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMMDAdvertiseWayFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMMDAdvertiseWayFacade facade = context.Items["ICRMMDAdvertiseWayFacade"] as Bay.ERP.BusinessFacade.ICRMMDAdvertiseWayFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMMDAdvertiseWayFacade();
                context.Items["ICRMMDAdvertiseWayFacade"] = facade;
            }
            return facade;
        }


    }
}
