// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeSalaryInfo
    {

        public FCCHREmployeeSalaryInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeSalaryInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeSalaryInfoFacade facade = context.Items["IHREmployeeSalaryInfoFacade"] as Bay.ERP.BusinessFacade.IHREmployeeSalaryInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeSalaryInfoFacade();
                context.Items["IHREmployeeSalaryInfoFacade"] = facade;
            }
            return facade;
        }


    }
}