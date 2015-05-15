// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2014, 11:58:51




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDDivision
    {

        public FCCMDDivision()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDDivisionFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDDivisionFacade facade = context.Items["IMDDivisionFacade"] as Bay.ERP.BusinessFacade.IMDDivisionFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDDivisionFacade();
                context.Items["IMDDivisionFacade"] = facade;
            }
            return facade;
        }


    }
}
