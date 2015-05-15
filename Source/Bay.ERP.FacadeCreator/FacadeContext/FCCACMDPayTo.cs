// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACMDPayTo
    {

        public FCCACMDPayTo()
        {

        }

        public static Bay.ERP.BusinessFacade.IACMDPayToFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACMDPayToFacade facade = context.Items["IACMDPayToFacade"] as Bay.ERP.BusinessFacade.IACMDPayToFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACMDPayToFacade();
                context.Items["IACMDPayToFacade"] = facade;
            }
            return facade;
        }


    }
}
