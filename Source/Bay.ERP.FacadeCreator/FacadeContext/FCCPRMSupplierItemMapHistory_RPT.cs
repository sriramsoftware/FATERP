// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Apr-2012, 10:30:24




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMSupplierItemMapHistory_RPT
    {

        public FCCPRMSupplierItemMapHistory_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMSupplierItemMapHistory_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMSupplierItemMapHistory_RPTFacade facade = context.Items["IPRMSupplierItemMapHistory_RPTFacade"] as Bay.ERP.BusinessFacade.IPRMSupplierItemMapHistory_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMSupplierItemMapHistory_RPTFacade();
                context.Items["IPRMSupplierItemMapHistory_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
