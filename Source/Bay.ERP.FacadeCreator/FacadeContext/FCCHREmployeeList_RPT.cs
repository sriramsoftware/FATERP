// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2014, 01:58:57




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeList_RPT
    {

        public FCCHREmployeeList_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeList_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeList_RPTFacade facade = context.Items["IHREmployeeList_RPTFacade"] as Bay.ERP.BusinessFacade.IHREmployeeList_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeList_RPTFacade();
                context.Items["IHREmployeeList_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
