// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Dec-2012, 10:46:38




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCPrePayableStatementDetail_Custom
    {

        public FCCACCPrePayableStatementDetail_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCPrePayableStatementDetail_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCPrePayableStatementDetail_CustomFacade facade = context.Items["IACCPrePayableStatementDetail_CustomFacade"] as Bay.ERP.BusinessFacade.IACCPrePayableStatementDetail_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCPrePayableStatementDetail_CustomFacade();
                context.Items["IACCPrePayableStatementDetail_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
