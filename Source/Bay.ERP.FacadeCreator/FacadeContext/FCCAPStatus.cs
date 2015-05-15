// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPStatus
    {

        public FCCAPStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPStatusFacade facade = context.Items["IAPStatusFacade"] as Bay.ERP.BusinessFacade.IAPStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APStatusFacade();
                context.Items["IAPStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
