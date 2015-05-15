// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 03:28:28




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACClassType
    {

        public FCCACClassType()
        {

        }

        public static Bay.ERP.BusinessFacade.IACClassTypeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACClassTypeFacade facade = context.Items["IACClassTypeFacade"] as Bay.ERP.BusinessFacade.IACClassTypeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACClassTypeFacade();
                context.Items["IACClassTypeFacade"] = facade;
            }
            return facade;
        }


    }
}
