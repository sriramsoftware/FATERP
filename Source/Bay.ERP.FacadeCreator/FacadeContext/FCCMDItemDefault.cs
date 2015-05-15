// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDItemDefault
    {

        public FCCMDItemDefault()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDItemDefaultFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDItemDefaultFacade facade = context.Items["IMDItemDefaultFacade"] as Bay.ERP.BusinessFacade.IMDItemDefaultFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDItemDefaultFacade();
                context.Items["IMDItemDefaultFacade"] = facade;
            }
            return facade;
        }


    }
}
