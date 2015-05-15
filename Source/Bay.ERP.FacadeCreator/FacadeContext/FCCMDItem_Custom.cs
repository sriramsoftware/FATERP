// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Jul-2013, 04:33:39




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDItem_Custom
    {

        public FCCMDItem_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDItem_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDItem_CustomFacade facade = context.Items["IMDItem_CustomFacade"] as Bay.ERP.BusinessFacade.IMDItem_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDItem_CustomFacade();
                context.Items["IMDItem_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
