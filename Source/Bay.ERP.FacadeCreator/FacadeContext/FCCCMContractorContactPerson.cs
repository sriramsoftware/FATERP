// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMContractorContactPerson
    {

        public FCCCMContractorContactPerson()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMContractorContactPersonFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMContractorContactPersonFacade facade = context.Items["ICMContractorContactPersonFacade"] as Bay.ERP.BusinessFacade.ICMContractorContactPersonFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMContractorContactPersonFacade();
                context.Items["ICMContractorContactPersonFacade"] = facade;
            }
            return facade;
        }


    }
}
