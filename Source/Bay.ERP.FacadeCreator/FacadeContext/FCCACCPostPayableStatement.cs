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
    public class FCCACCPostPayableStatement
    {

        public FCCACCPostPayableStatement()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCPostPayableStatementFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCPostPayableStatementFacade facade = context.Items["IACCPostPayableStatementFacade"] as Bay.ERP.BusinessFacade.IACCPostPayableStatementFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCPostPayableStatementFacade();
                context.Items["IACCPostPayableStatementFacade"] = facade;
            }
            return facade;
        }


    }
}
