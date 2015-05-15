// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Dec-2012, 11:48:21




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCPostPayableStatement_RPT
    {

        public FCCACCPostPayableStatement_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCPostPayableStatement_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCPostPayableStatement_RPTFacade facade = context.Items["IACCPostPayableStatement_RPTFacade"] as Bay.ERP.BusinessFacade.IACCPostPayableStatement_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCPostPayableStatement_RPTFacade();
                context.Items["IACCPostPayableStatement_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
