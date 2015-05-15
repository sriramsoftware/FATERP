// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2014, 04:10:32




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeDetails_RPT
    {

        public FCCHREmployeeDetails_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeDetails_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeDetails_RPTFacade facade = context.Items["IHREmployeeDetails_RPTFacade"] as Bay.ERP.BusinessFacade.IHREmployeeDetails_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeDetails_RPTFacade();
                context.Items["IHREmployeeDetails_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
