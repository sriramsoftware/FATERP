// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jan-2012, 09:58:11




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeResume_RPT
    {

        public FCCHREmployeeResume_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeResume_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeResume_RPTFacade facade = context.Items["IHREmployeeResume_RPTFacade"] as Bay.ERP.BusinessFacade.IHREmployeeResume_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeResume_RPTFacade();
                context.Items["IHREmployeeResume_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
