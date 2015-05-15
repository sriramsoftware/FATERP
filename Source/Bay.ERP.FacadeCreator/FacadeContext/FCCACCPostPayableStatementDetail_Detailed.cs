// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jan-2013, 11:07:11




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCPostPayableStatementDetail_Detailed
    {

        public FCCACCPostPayableStatementDetail_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCPostPayableStatementDetail_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCPostPayableStatementDetail_DetailedFacade facade = context.Items["IACCPostPayableStatementDetail_DetailedFacade"] as Bay.ERP.BusinessFacade.IACCPostPayableStatementDetail_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCPostPayableStatementDetail_DetailedFacade();
                context.Items["IACCPostPayableStatementDetail_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
