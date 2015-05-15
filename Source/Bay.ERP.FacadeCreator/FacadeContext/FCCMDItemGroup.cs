// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDItemGroup
    {

        public FCCMDItemGroup()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDItemGroupFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDItemGroupFacade facade = context.Items["IMDItemGroupFacade"] as Bay.ERP.BusinessFacade.IMDItemGroupFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDItemGroupFacade();
                context.Items["IMDItemGroupFacade"] = facade;
            }
            return facade;
        }


    }
}
