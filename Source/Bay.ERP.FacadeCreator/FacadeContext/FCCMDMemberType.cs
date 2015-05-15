// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDMemberType
    {

        public FCCMDMemberType()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDMemberTypeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDMemberTypeFacade facade = context.Items["IMDMemberTypeFacade"] as Bay.ERP.BusinessFacade.IMDMemberTypeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDMemberTypeFacade();
                context.Items["IMDMemberTypeFacade"] = facade;
            }
            return facade;
        }


    }
}
