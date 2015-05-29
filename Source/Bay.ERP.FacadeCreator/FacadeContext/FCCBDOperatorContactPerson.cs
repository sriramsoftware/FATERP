// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:50:36




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDOperatorContactPerson
    {

        public FCCBDOperatorContactPerson()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDOperatorContactPersonFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDOperatorContactPersonFacade facade = context.Items["IBDOperatorContactPersonFacade"] as Bay.ERP.BusinessFacade.IBDOperatorContactPersonFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDOperatorContactPersonFacade();
                context.Items["IBDOperatorContactPersonFacade"] = facade;
            }
            return facade;
        }


    }
}
