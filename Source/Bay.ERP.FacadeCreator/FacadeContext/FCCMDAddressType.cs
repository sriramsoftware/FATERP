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
    public class FCCMDAddressType
    {

        public FCCMDAddressType()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDAddressTypeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDAddressTypeFacade facade = context.Items["IMDAddressTypeFacade"] as Bay.ERP.BusinessFacade.IMDAddressTypeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDAddressTypeFacade();
                context.Items["IMDAddressTypeFacade"] = facade;
            }
            return facade;
        }


    }
}
