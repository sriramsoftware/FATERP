// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 03:29:43




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCPostPayableStatementDetail
    {

        public FCCACCPostPayableStatementDetail()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCPostPayableStatementDetailFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCPostPayableStatementDetailFacade facade = context.Items["IACCPostPayableStatementDetailFacade"] as Bay.ERP.BusinessFacade.IACCPostPayableStatementDetailFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCPostPayableStatementDetailFacade();
                context.Items["IACCPostPayableStatementDetailFacade"] = facade;
            }
            return facade;
        }


    }
}
