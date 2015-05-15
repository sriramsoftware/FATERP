// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCPrePayableStatement
    {

        public FCCACCPrePayableStatement()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCPrePayableStatementFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCPrePayableStatementFacade facade = context.Items["IACCPrePayableStatementFacade"] as Bay.ERP.BusinessFacade.IACCPrePayableStatementFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCPrePayableStatementFacade();
                context.Items["IACCPrePayableStatementFacade"] = facade;
            }
            return facade;
        }


    }
}
