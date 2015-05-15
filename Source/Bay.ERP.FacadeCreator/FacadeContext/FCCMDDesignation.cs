// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDDesignation
    {

        public FCCMDDesignation()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDDesignationFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDDesignationFacade facade = context.Items["IMDDesignationFacade"] as Bay.ERP.BusinessFacade.IMDDesignationFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDDesignationFacade();
                context.Items["IMDDesignationFacade"] = facade;
            }
            return facade;
        }


    }
}
