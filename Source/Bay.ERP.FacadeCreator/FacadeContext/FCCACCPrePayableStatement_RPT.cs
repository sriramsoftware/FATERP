// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Dec-2012, 12:17:40




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCPrePayableStatement_RPT
    {

        public FCCACCPrePayableStatement_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCPrePayableStatement_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCPrePayableStatement_RPTFacade facade = context.Items["IACCPrePayableStatement_RPTFacade"] as Bay.ERP.BusinessFacade.IACCPrePayableStatement_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCPrePayableStatement_RPTFacade();
                context.Items["IACCPrePayableStatement_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
