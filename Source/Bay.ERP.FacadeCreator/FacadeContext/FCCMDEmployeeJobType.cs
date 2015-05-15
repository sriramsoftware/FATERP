// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDEmployeeJobType
    {

        public FCCMDEmployeeJobType()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDEmployeeJobTypeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDEmployeeJobTypeFacade facade = context.Items["IMDEmployeeJobTypeFacade"] as Bay.ERP.BusinessFacade.IMDEmployeeJobTypeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDEmployeeJobTypeFacade();
                context.Items["IMDEmployeeJobTypeFacade"] = facade;
            }
            return facade;
        }


    }
}
