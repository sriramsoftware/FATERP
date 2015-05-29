// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 08:31:04




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDOperatorAddressInfo
    {

        public FCCBDOperatorAddressInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDOperatorAddressInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDOperatorAddressInfoFacade facade = context.Items["IBDOperatorAddressInfoFacade"] as Bay.ERP.BusinessFacade.IBDOperatorAddressInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDOperatorAddressInfoFacade();
                context.Items["IBDOperatorAddressInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
