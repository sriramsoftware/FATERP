// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHRDepartmentEmployeeMap
    {

        public FCCHRDepartmentEmployeeMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IHRDepartmentEmployeeMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHRDepartmentEmployeeMapFacade facade = context.Items["IHRDepartmentEmployeeMapFacade"] as Bay.ERP.BusinessFacade.IHRDepartmentEmployeeMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HRDepartmentEmployeeMapFacade();
                context.Items["IHRDepartmentEmployeeMapFacade"] = facade;
            }
            return facade;
        }


    }
}
