// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Dec-2012, 03:53:03




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCPrePayableStatementDetailByWorkOrderNo_Custom
    {

        public FCCACCPrePayableStatementDetailByWorkOrderNo_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCPrePayableStatementDetailByWorkOrderNo_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCPrePayableStatementDetailByWorkOrderNo_CustomFacade facade = context.Items["IACCPrePayableStatementDetailByWorkOrderNo_CustomFacade"] as Bay.ERP.BusinessFacade.IACCPrePayableStatementDetailByWorkOrderNo_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCPrePayableStatementDetailByWorkOrderNo_CustomFacade();
                context.Items["IACCPrePayableStatementDetailByWorkOrderNo_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}