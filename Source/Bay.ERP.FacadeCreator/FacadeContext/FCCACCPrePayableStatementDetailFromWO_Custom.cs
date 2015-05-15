// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Dec-2012, 09:55:31




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCPrePayableStatementDetailFromWO_Custom
    {

        public FCCACCPrePayableStatementDetailFromWO_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCPrePayableStatementDetailFromWO_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCPrePayableStatementDetailFromWO_CustomFacade facade = context.Items["IACCPrePayableStatementDetailFromWO_CustomFacade"] as Bay.ERP.BusinessFacade.IACCPrePayableStatementDetailFromWO_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCPrePayableStatementDetailFromWO_CustomFacade();
                context.Items["IACCPrePayableStatementDetailFromWO_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
