// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMConstructionToolDetail
    {

        public FCCCMConstructionToolDetail()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMConstructionToolDetailFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMConstructionToolDetailFacade facade = context.Items["ICMConstructionToolDetailFacade"] as Bay.ERP.BusinessFacade.ICMConstructionToolDetailFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMConstructionToolDetailFacade();
                context.Items["ICMConstructionToolDetailFacade"] = facade;
            }
            return facade;
        }


    }
}
