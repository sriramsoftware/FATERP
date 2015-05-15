// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployee
    {

        public FCCHREmployee()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeFacade facade = context.Items["IHREmployeeFacade"] as Bay.ERP.BusinessFacade.IHREmployeeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeFacade();
                context.Items["IHREmployeeFacade"] = facade;
            }
            return facade;
        }


    }
}
