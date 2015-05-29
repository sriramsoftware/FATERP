// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 11:33:13




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDOperator
    {

        public FCCBDOperator()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDOperatorFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDOperatorFacade facade = context.Items["IBDOperatorFacade"] as Bay.ERP.BusinessFacade.IBDOperatorFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDOperatorFacade();
                context.Items["IBDOperatorFacade"] = facade;
            }
            return facade;
        }


    }
}
