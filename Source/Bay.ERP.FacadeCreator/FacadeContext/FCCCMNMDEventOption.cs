// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 05:27:25




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMNMDEventOption
    {

        public FCCCMNMDEventOption()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMNMDEventOptionFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMNMDEventOptionFacade facade = context.Items["ICMNMDEventOptionFacade"] as Bay.ERP.BusinessFacade.ICMNMDEventOptionFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMNMDEventOptionFacade();
                context.Items["ICMNMDEventOptionFacade"] = facade;
            }
            return facade;
        }


    }
}
