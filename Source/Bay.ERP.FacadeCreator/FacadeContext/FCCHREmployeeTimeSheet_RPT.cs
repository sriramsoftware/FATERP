// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 06:16:34




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeTimeSheet_RPT
    {

        public FCCHREmployeeTimeSheet_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeTimeSheet_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeTimeSheet_RPTFacade facade = context.Items["IHREmployeeTimeSheet_RPTFacade"] as Bay.ERP.BusinessFacade.IHREmployeeTimeSheet_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeTimeSheet_RPTFacade();
                context.Items["IHREmployeeTimeSheet_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
