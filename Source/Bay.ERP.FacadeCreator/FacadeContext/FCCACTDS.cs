// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 05:35:27




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACTDS
    {

        public FCCACTDS()
        {

        }

        public static Bay.ERP.BusinessFacade.IACTDSFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACTDSFacade facade = context.Items["IACTDSFacade"] as Bay.ERP.BusinessFacade.IACTDSFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACTDSFacade();
                context.Items["IACTDSFacade"] = facade;
            }
            return facade;
        }


    }
}
